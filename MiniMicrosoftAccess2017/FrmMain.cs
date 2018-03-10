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
using System.IO;

namespace MiniMicrosoftAccess2017
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string path;

        private Database CreateDB(string path)
        {
            DBEngine Dbe = new DBEngine();
            Database myDB;
            myDB = Dbe.CreateDatabase(path, DAO.LanguageConstants.dbLangGeneral);
            myDB.Close();
            return myDB;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }


 

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the application ?", "End of the program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            SaveFileDlg.Filter = "FichierAccess|*.mdb|Tous fichiers|*.*";
            SaveFileDlg.ShowDialog();
            string Creationpath = SaveFileDlg.FileName;
            CreateDB(Creationpath);
            MessageBox.Show("The database has been created !", "Successful creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getPath = Creationpath;
            OpenDB f1 = new OpenDB();
            f1.ShowDialog();
        }

        private void BtnOpenDB_Click_1(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("You have to chose the database you want to open by clicking on browse...", "Missing step!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                path = txtPath.Text;
                OpenDB f1 = new OpenDB();
                f1.ShowDialog();
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the application ?", "End of the program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static string getPath;

        public static string GetPath
        {
            get {
                return getPath;
                }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDlg.Filter = "FichierAccess|*.mdb|Tous fichiers|*.*";
            OpenFileDlg.ShowDialog();
            txtPath.Text = OpenFileDlg.FileName;
            getPath = txtPath.Text;
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("You have to chose the database you want to open by clicking on browse...", "Missing step!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                path = txtPath.Text;
                OpenDB f1 = new OpenDB();
                f1.ShowDialog();
            }
        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
