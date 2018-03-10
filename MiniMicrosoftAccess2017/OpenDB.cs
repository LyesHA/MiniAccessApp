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
    public partial class OpenDB : Form
    {
        public OpenDB()
        {
            InitializeComponent();
        }
        DBEngine Dbe;
        Database MyDB;
        Recordset Myrec;

        private void OpenDB_Load(object sender, EventArgs e)
        {
            
            Dbe = new DBEngine();
            MyDB = Dbe.OpenDatabase(FrmMain.GetPath);
            DisplayTables(CBOTables, MyDB);
            GridTable.Columns.Add("colFields", "Fields");
            GridTable.Columns.Add("colSize", "Size");
            GridTable.Columns.Add("colType", "Type");
        }

        //Function to display Tables
        public static void DisplayTables(ComboBox lb,Database mydb)
        {
            for(int i = 0; i < mydb.TableDefs.Count; i++)
            {
                if (mydb.TableDefs[i].Attributes == 0)
                {
                    lb.Items.Add(mydb.TableDefs[i].Name.ToString());
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the application ?", "End of the program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Function to display Fields
        private void DisplayFields(DataGridView Grid,Recordset Myrec)
        {
            Grid.Rows.Clear();
            Myrec = MyDB.OpenRecordset("SELECT * FROM " + CBOTables.SelectedItem.ToString(), DAO.RecordsetTypeEnum.dbOpenDynaset);
            for (int i = 0; i < Myrec.Fields.Count; i++)
            {
                Grid.Rows.Add();
                Grid.Rows[i].Cells[0].Value= Myrec.Fields[i].Name.ToString();
                Grid.Rows[i].Cells[1].Value= Myrec.Fields[i].Size.ToString();
                Grid.Rows[i].Cells[2].Value = Enum.GetName(typeof(DataTypeEnum), Myrec.Fields[i].Type);
                
            }

            
        }
 
        private void BtnCreateTB_Click(object sender, EventArgs e)
        {
            CreateTB Ctb = new CreateTB();
            Ctb.ShowDialog();
            MyDB.Close();
            MyDB = Dbe.OpenDatabase(FrmMain.GetPath);
            CBOTables.Items.Clear();
            DisplayTables(CBOTables, MyDB);
        }

        private void BtnCreateRel_Click(object sender, EventArgs e)
        {
            CreateRelations CR = new CreateRelations();
            CR.ShowDialog();
        }

        private void LBFields_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnDisplayRelation_Click(object sender, EventArgs e)
        {
            FrmDisplayRelations DR = new FrmDisplayRelations();
            DR.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the application ?", "End of the program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CBOTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFields(GridTable, Myrec);
        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            FrmAddRecord AR = new FrmAddRecord();
            AR.ShowDialog();
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTB Ctb = new CreateTB();
            Ctb.ShowDialog();
        }

        private void createRelationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateRelations CR = new CreateRelations();
            CR.ShowDialog();
        }

        private void displayRelationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayRelations DR = new FrmDisplayRelations();
            DR.ShowDialog();
        }

        private void displyAddRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddRecord AR = new FrmAddRecord();
            AR.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            //MyDB.Close();
            //MyDB = Dbe.OpenDatabase(FrmMain.GetPath);
            //CBOTables.Items.Clear();
            //DisplayTables(CBOTables, MyDB);
        }

        private void OpenDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyDB.Close();
        }
    }
}
