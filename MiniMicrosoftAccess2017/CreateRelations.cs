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
    public partial class CreateRelations : Form
    {
        public CreateRelations()
        {
            InitializeComponent();
        }

        Database MyDB;
        Recordset MyRec;

        private void CreateRelations_Load(object sender, EventArgs e)
        {
            DBEngine Dbe = new DBEngine();
            MyDB = Dbe.OpenDatabase(FrmMain.GetPath);
            ShowTable(CBOParentTable);
            ShowTable(CBOForeignTable);
        }

        //Function that create the relation
        private Database CreateRelation()
        {
            MyDB.Close();
            DBEngine Dbe = new DBEngine();
            MyDB = Dbe.OpenDatabase(FrmMain.GetPath);
            Field MyFL;
            Relation MyRL = MyDB.CreateRelation(txtRelationName.Text, CBOParentTable.SelectedItem, CBOForeignTable.SelectedItem);
            MyFL = MyRL.CreateField(CBOPrimaryKey.SelectedItem.ToString());
            MyFL.ForeignName = CBOForeignKey.SelectedItem.ToString();
            MyRL.Fields.Append(MyFL);
            MyDB.Relations.Append(MyRL);
            return MyDB;
        }

        //Function that add tables in a ComboBox
        private void ShowTable(ComboBox CBOItems)
        {
            for (int i = 0; i < MyDB.TableDefs.Count; i++)
            {
                if (MyDB.TableDefs[i].Attributes == 0)
                {
                    CBOItems.Items.Add(MyDB.TableDefs[i].Name.ToString());
                }
            }
        }

        //Function that add fields in a ComboBox
        private void ShowFields(ComboBox CBOTable,ComboBox CBOFields,Recordset MyRec)
        {
            MyRec = MyDB.OpenRecordset("SELECT * FROM " + CBOTable.SelectedItem.ToString(), DAO.RecordsetTypeEnum.dbOpenDynaset);
            for (int i = 0; i < MyRec.Fields.Count; i++)
            {
                CBOFields.Items.Add(MyRec.Fields[i].Name.ToString());
            }
        }

        private void CBOParentTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFields(CBOParentTable, CBOPrimaryKey, MyRec);
        }

        private void CBOForeignTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFields(CBOForeignTable, CBOForeignKey, MyRec);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateRelation();
            MessageBox.Show("The relation has been created!!","Succesfull creation!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MyDB.Close();
                this.Close();
            }
        }
    }
}
