namespace MiniMicrosoftAccess2017
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.BtnOpenDB = new System.Windows.Forms.Button();
            this.BtnCreateDB = new System.Windows.Forms.Button();
            this.SaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            resources.ApplyResources(this.BtnExit, "BtnExit");
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.BtnBrowse);
            this.panel3.Controls.Add(this.txtPath);
            this.panel3.Controls.Add(this.BtnExit);
            this.panel3.Controls.Add(this.BtnOpenDB);
            this.panel3.Controls.Add(this.BtnCreateDB);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniMicrosoftAccess2017.Properties.Resources.Sans_titre;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BtnBrowse
            // 
            resources.ApplyResources(this.BtnBrowse, "BtnBrowse");
            this.BtnBrowse.ForeColor = System.Drawing.Color.Black;
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtPath
            // 
            resources.ApplyResources(this.txtPath, "txtPath");
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            // 
            // BtnOpenDB
            // 
            resources.ApplyResources(this.BtnOpenDB, "BtnOpenDB");
            this.BtnOpenDB.ForeColor = System.Drawing.Color.Black;
            this.BtnOpenDB.Name = "BtnOpenDB";
            this.BtnOpenDB.UseVisualStyleBackColor = true;
            this.BtnOpenDB.Click += new System.EventHandler(this.BtnOpenDB_Click_1);
            // 
            // BtnCreateDB
            // 
            resources.ApplyResources(this.BtnCreateDB, "BtnCreateDB");
            this.BtnCreateDB.ForeColor = System.Drawing.Color.Black;
            this.BtnCreateDB.Name = "BtnCreateDB";
            this.BtnCreateDB.UseVisualStyleBackColor = true;
            this.BtnCreateDB.Click += new System.EventHandler(this.BtnCreateDB_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnOpenDB;
        private System.Windows.Forms.Button BtnCreateDB;
        private System.Windows.Forms.SaveFileDialog SaveFileDlg;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}