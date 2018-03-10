using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace MiniMicrosoftAccess2017
{
    public partial class FrmAddRecord : Form
    {
        public FrmAddRecord()
        {
            InitializeComponent();
        }
        Database MyDB;
        Recordset MyRec;
        private void FrmAddRecord_Load(object sender, EventArgs e)
        {
            DBEngine Dbe = new DBEngine();
            MyDB= Dbe.OpenDatabase(FrmMain.GetPath);
            OpenDB.DisplayTables(CBOTables, MyDB);
            
        }

        private void AddColumns(DataGridView db,Recordset myrec)
        {
            db.Columns.Clear();
            for(int i = 0; i < myrec.Fields.Count; i++)
            {
                db.Columns.Add("col" + myrec.Fields[i].Name.ToString(), myrec.Fields[i].Name.ToString());
            }
        }

        //Add Data from the recordset to  the GridView
        private void DisplayDataRecToGrid(DataGridView db, Recordset myrec)
        {
            int i = 0;
            db.Rows.Clear();
            while (!myrec.EOF)
            {
                db.Rows.Add();
               
                for (int j = 0; j < myrec.Fields.Count; j++)
                {
                    db.Rows[i].Cells[j].Value = myrec.Fields[j].Value.ToString();   
                }
                i++;
                myrec.MoveNext();
            }           
        }

        //Add Data from the GridView to the recordset
        private void AddDataGridToRec(DataGridView db, Recordset myrec)
        {
           for(int i = 0; i < db.Rows.Count-1; i++)
            {
                myrec.AddNew();
                for(int j = 0; j < db.Rows[i].Cells.Count; j++)
                {
                    myrec.Fields[j].Value = db.Rows[i].Cells[j].Value.ToString();
                }
                myrec.Update();
            }
        }

        private void CBOTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyRec = MyDB.OpenRecordset("SELECT * FROM " + CBOTables.SelectedItem.ToString(), DAO.RecordsetTypeEnum.dbOpenDynaset);
            AddColumns(GridRecords, MyRec);
            DisplayDataRecToGrid(GridRecords, MyRec);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GridRecords.Rows.Clear();           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AddDataGridToRec(GridRecords, MyRec);
            MessageBox.Show("The Records have been created !!");
            DisplayDataRecToGrid(GridRecords, MyRec);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
