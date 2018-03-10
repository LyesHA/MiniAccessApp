namespace MiniMicrosoftAccess2017
{
    partial class OpenDB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAddRecord = new System.Windows.Forms.Button();
            this.BtnDisplayRelation = new System.Windows.Forms.Button();
            this.BtnCreateRel = new System.Windows.Forms.Button();
            this.BtnCreateTB = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createRelationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRelationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displyAddRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBOTables = new System.Windows.Forms.ComboBox();
            this.GridTable = new System.Windows.Forms.DataGridView();
            this.PictureMiniAccess = new System.Windows.Forms.PictureBox();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMiniAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnAddRecord);
            this.panel1.Controls.Add(this.BtnDisplayRelation);
            this.panel1.Controls.Add(this.BtnCreateRel);
            this.panel1.Controls.Add(this.BtnCreateTB);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 366);
            this.panel1.TabIndex = 10;
            // 
            // BtnAddRecord
            // 
            this.BtnAddRecord.Font = new System.Drawing.Font("Microsoft NeoGothic", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddRecord.ForeColor = System.Drawing.Color.Black;
            this.BtnAddRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAddRecord.Location = new System.Drawing.Point(12, 175);
            this.BtnAddRecord.Name = "BtnAddRecord";
            this.BtnAddRecord.Size = new System.Drawing.Size(190, 45);
            this.BtnAddRecord.TabIndex = 4;
            this.BtnAddRecord.Text = "Display/Add Records";
            this.BtnAddRecord.UseVisualStyleBackColor = true;
            this.BtnAddRecord.Click += new System.EventHandler(this.BtnAddRecord_Click);
            // 
            // BtnDisplayRelation
            // 
            this.BtnDisplayRelation.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisplayRelation.ForeColor = System.Drawing.Color.Black;
            this.BtnDisplayRelation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDisplayRelation.Location = new System.Drawing.Point(12, 127);
            this.BtnDisplayRelation.Name = "BtnDisplayRelation";
            this.BtnDisplayRelation.Size = new System.Drawing.Size(190, 42);
            this.BtnDisplayRelation.TabIndex = 3;
            this.BtnDisplayRelation.Text = "&Display Relations";
            this.BtnDisplayRelation.UseVisualStyleBackColor = true;
            this.BtnDisplayRelation.Click += new System.EventHandler(this.BtnDisplayRelation_Click);
            // 
            // BtnCreateRel
            // 
            this.BtnCreateRel.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateRel.ForeColor = System.Drawing.Color.Black;
            this.BtnCreateRel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCreateRel.Location = new System.Drawing.Point(12, 79);
            this.BtnCreateRel.Name = "BtnCreateRel";
            this.BtnCreateRel.Size = new System.Drawing.Size(190, 42);
            this.BtnCreateRel.TabIndex = 2;
            this.BtnCreateRel.Text = "Create &Relations";
            this.BtnCreateRel.UseVisualStyleBackColor = true;
            this.BtnCreateRel.Click += new System.EventHandler(this.BtnCreateRel_Click);
            // 
            // BtnCreateTB
            // 
            this.BtnCreateTB.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateTB.ForeColor = System.Drawing.Color.Black;
            this.BtnCreateTB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCreateTB.Location = new System.Drawing.Point(12, 31);
            this.BtnCreateTB.Name = "BtnCreateTB";
            this.BtnCreateTB.Size = new System.Drawing.Size(190, 42);
            this.BtnCreateTB.TabIndex = 1;
            this.BtnCreateTB.Text = "Create &Table";
            this.BtnCreateTB.UseVisualStyleBackColor = true;
            this.BtnCreateTB.Click += new System.EventHandler(this.BtnCreateTB_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExit.Location = new System.Drawing.Point(12, 313);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(190, 42);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(215, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTableToolStripMenuItem,
            this.createRelationsToolStripMenuItem,
            this.displayRelationsToolStripMenuItem,
            this.displyAddRecordsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.createTableToolStripMenuItem.Text = "Create Table";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // createRelationsToolStripMenuItem
            // 
            this.createRelationsToolStripMenuItem.Name = "createRelationsToolStripMenuItem";
            this.createRelationsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.createRelationsToolStripMenuItem.Text = "Create Relations";
            this.createRelationsToolStripMenuItem.Click += new System.EventHandler(this.createRelationsToolStripMenuItem_Click);
            // 
            // displayRelationsToolStripMenuItem
            // 
            this.displayRelationsToolStripMenuItem.Name = "displayRelationsToolStripMenuItem";
            this.displayRelationsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.displayRelationsToolStripMenuItem.Text = "Display Relations";
            this.displayRelationsToolStripMenuItem.Click += new System.EventHandler(this.displayRelationsToolStripMenuItem_Click);
            // 
            // displyAddRecordsToolStripMenuItem
            // 
            this.displyAddRecordsToolStripMenuItem.Name = "displyAddRecordsToolStripMenuItem";
            this.displyAddRecordsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.displyAddRecordsToolStripMenuItem.Text = "Disply And Add Records";
            this.displyAddRecordsToolStripMenuItem.Click += new System.EventHandler(this.displyAddRecordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.CBOTables);
            this.panel3.Controls.Add(this.GridTable);
            this.panel3.Controls.Add(this.PictureMiniAccess);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 366);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Table";
            // 
            // CBOTables
            // 
            this.CBOTables.FormattingEnabled = true;
            this.CBOTables.Location = new System.Drawing.Point(607, 124);
            this.CBOTables.Name = "CBOTables";
            this.CBOTables.Size = new System.Drawing.Size(152, 24);
            this.CBOTables.TabIndex = 6;
            this.CBOTables.SelectedIndexChanged += new System.EventHandler(this.CBOTables_SelectedIndexChanged);
            // 
            // GridTable
            // 
            this.GridTable.AccessibleDescription = "";
            this.GridTable.AllowUserToOrderColumns = true;
            this.GridTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.GridTable.Location = new System.Drawing.Point(221, 155);
            this.GridTable.Name = "GridTable";
            this.GridTable.RowHeadersWidth = 100;
            this.GridTable.RowTemplate.Height = 24;
            this.GridTable.Size = new System.Drawing.Size(538, 200);
            this.GridTable.TabIndex = 7;
            // 
            // PictureMiniAccess
            // 
            this.PictureMiniAccess.Image = global::MiniMicrosoftAccess2017.Properties.Resources.Sans_titre;
            this.PictureMiniAccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureMiniAccess.Location = new System.Drawing.Point(363, 3);
            this.PictureMiniAccess.Name = "PictureMiniAccess";
            this.PictureMiniAccess.Size = new System.Drawing.Size(213, 118);
            this.PictureMiniAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureMiniAccess.TabIndex = 15;
            this.PictureMiniAccess.TabStop = false;
            // 
            // OpenDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Name = "OpenDB";
            this.Text = "Open Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenDB_FormClosing);
            this.Load += new System.EventHandler(this.OpenDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureMiniAccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCreateRel;
        private System.Windows.Forms.Button BtnCreateTB;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.Button BtnDisplayRelation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRelationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayRelationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox PictureMiniAccess;
        private System.Windows.Forms.DataGridView GridTable;
        private System.Windows.Forms.ComboBox CBOTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAddRecord;
        private System.Windows.Forms.ToolStripMenuItem displyAddRecordsToolStripMenuItem;
    }
}