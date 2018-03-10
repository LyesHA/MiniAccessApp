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
    public partial class CreateTB : Form
    {
        public CreateTB()
        {
            InitializeComponent();        
        }

        DBEngine Dbe = new DBEngine();
        Database MyDB;
        TableDef MyTb;

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            CreateTable();
            Enable(true, true, true, false, true, false, true, true);
        }

        private Database CreateTable()
        {
            MyDB = Dbe.OpenDatabase(FrmMain.GetPath);
            string Tablename = txtTableName.Text;
            MyTb = MyDB.CreateTableDef(Tablename);
            MessageBox.Show("The table " + txtTableName.Text + " has been created!", "Successful creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTableName.Enabled = false;
            return MyDB;
        }

        private TableDef CreateFields()
        {
            Field MyFL;
            if (CHKPrimaryKey.Checked && !CHKAutoIncrement.Checked)
            {
                MyFL = MyTb.CreateField(txtFieldsName.Text, CBOType.SelectedItem, txtLength.Text);
                MyTb.Fields.Append(MyFL);
                Index MyInd = MyTb.CreateIndex("PK" + txtFieldsName.Text);
                MyFL = MyInd.CreateField(txtFieldsName.Text);
                ((IndexFields)(MyInd.Fields)).Append(MyFL);
                MyInd.Primary = true;
                MyTb.Indexes.Append(MyInd);
                MessageBox.Show("The field & the index have been created !", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CHKPrimaryKey.Checked && CHKAutoIncrement.Checked)
            {
                MyFL = MyTb.CreateField(txtFieldsName.Text, FieldAttributeEnum.dbAutoIncrField);
                MyTb.Fields.Append(MyFL);
                Index MyInd = MyTb.CreateIndex("PK" + txtFieldsName.Text);
                MyFL = MyInd.CreateField(txtFieldsName.Text);
                ((IndexFields)(MyInd.Fields)).Append(MyFL);
                MyInd.Primary = true;
                MyTb.Indexes.Append(MyInd);
                MessageBox.Show("The field & the index have been created !", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CHKAutoIncrement.Checked && !CHKPrimaryKey.Checked)
            {
                MyFL = MyTb.CreateField(txtFieldsName.Text, FieldAttributeEnum.dbAutoIncrField);
                MyTb.Fields.Append(MyFL);
                MessageBox.Show("The field has been created !", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyFL = MyTb.CreateField(txtFieldsName.Text, CBOType.SelectedItem, txtLength.Text);
                MyTb.Fields.Append(MyFL);
                MessageBox.Show("The field has been created !", "Successful Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return MyTb;
        }

        private void CreateTB_Load(object sender, EventArgs e)
        {
            AddItemToCBOType(CBOType);
            Enable(false, false, false, true,false, true, false, false);    
        }

        //Function to add Field's type to ComboBox
        private void AddItemToCBOType(ComboBox CBOType)
        {
            foreach (DataTypeEnum item in Enum.GetValues(typeof(DataTypeEnum)))
            {
                CBOType.Items.Add(item);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtTableName.Text != "")
                {
                    MyDB.TableDefs.Append(MyTb);
                }
                
                this.Close();
                
            }
            
        }

        private void BtnAddFields_Click(object sender, EventArgs e)
        {
            CreateFields();
            txtFieldsName.Clear();
            txtLength.Clear();
            CBOType.Text = "";
            
        }

        private void CHKAutoIncrement_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKAutoIncrement.Checked)
            {
                txtLength.Enabled = false;
                CBOType.Enabled = false;
            }
            else if (!CHKAutoIncrement.Checked)
            {
                txtLength.Enabled = true;
                CBOType.Enabled = true;
            }
        }

        //Function that enable buttons 
        private void Enable(bool FieldsName,bool Length,bool cboType,bool TableName,bool AddFields, bool CreateTable, bool chkPK,bool chkAuto)
        {
            txtFieldsName.Enabled = FieldsName;
            txtLength.Enabled = Length;
            CBOType.Enabled = cboType;
            txtTableName.Enabled = TableName;
            BtnAddFields.Enabled = AddFields;
            BtnCreate.Enabled = CreateTable;
            CHKAutoIncrement.Enabled =chkAuto;
            CHKPrimaryKey.Enabled = chkPK;
        }

        private void txtFieldsName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
