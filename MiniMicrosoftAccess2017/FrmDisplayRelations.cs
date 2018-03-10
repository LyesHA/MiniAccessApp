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
    public partial class FrmDisplayRelations : Form
    {
        public FrmDisplayRelations()
        {
            InitializeComponent();
        }

        private void FrmDisplayRelations_Load(object sender, EventArgs e)
        {
            DBEngine Dbe = new DBEngine();
            Database MyDB = Dbe.OpenDatabase(FrmMain.GetPath);

            GridRelations.Columns.Add("ColParentTable", "Parent Table");
            GridRelations.Columns.Add("ColPrimary Key", "Primary Key");
            GridRelations.Columns.Add("ColForeign Table", "Foreign Table");
            GridRelations.Columns.Add("ColForeign Key", "Foreign Key");
            DisplayRel(MyDB, GridRelations);
        }


        private void DisplayRel(Database db, DataGridView grid) {
            for (int i = 0; i < db.Relations.Count; i++)
            {
                if (db.Relations[i].Attributes == 0)
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells[0].Value = db.Relations[i].Table.ToString();
                    grid.Rows[i].Cells[1].Value = db.Relations[i].Fields[i].Name.ToString();
                    grid.Rows[i].Cells[2].Value = db.Relations[i].ForeignTable.ToString();
                    grid.Rows[i].Cells[3].Value = db.Relations[i].Fields[i].ForeignName.ToString();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
