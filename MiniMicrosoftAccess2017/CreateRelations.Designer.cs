namespace MiniMicrosoftAccess2017
{
    partial class CreateRelations
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBOForeignKey = new System.Windows.Forms.ComboBox();
            this.CBOPrimaryKey = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBOForeignTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBOParentTable = new System.Windows.Forms.ComboBox();
            this.txtRelationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CBOForeignKey);
            this.panel1.Controls.Add(this.CBOPrimaryKey);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CBOForeignTable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CBOParentTable);
            this.panel1.Controls.Add(this.txtRelationName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 444);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniMicrosoftAccess2017.Properties.Resources.Sans_titre;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(141, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CBOForeignKey
            // 
            this.CBOForeignKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CBOForeignKey.FormattingEnabled = true;
            this.CBOForeignKey.Location = new System.Drawing.Point(202, 333);
            this.CBOForeignKey.Name = "CBOForeignKey";
            this.CBOForeignKey.Size = new System.Drawing.Size(275, 26);
            this.CBOForeignKey.TabIndex = 5;
            // 
            // CBOPrimaryKey
            // 
            this.CBOPrimaryKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CBOPrimaryKey.FormattingEnabled = true;
            this.CBOPrimaryKey.Location = new System.Drawing.Point(202, 258);
            this.CBOPrimaryKey.Name = "CBOPrimaryKey";
            this.CBOPrimaryKey.Size = new System.Drawing.Size(275, 26);
            this.CBOPrimaryKey.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft NeoGothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 44);
            this.label6.TabIndex = 14;
            this.label6.Text = "Creating Relation ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Primary Key :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Foreign Key :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Foreign Table :";
            // 
            // CBOForeignTable
            // 
            this.CBOForeignTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CBOForeignTable.FormattingEnabled = true;
            this.CBOForeignTable.Location = new System.Drawing.Point(202, 295);
            this.CBOForeignTable.Name = "CBOForeignTable";
            this.CBOForeignTable.Size = new System.Drawing.Size(275, 26);
            this.CBOForeignTable.TabIndex = 4;
            this.CBOForeignTable.SelectedIndexChanged += new System.EventHandler(this.CBOForeignTable_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parent Table :";
            // 
            // CBOParentTable
            // 
            this.CBOParentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CBOParentTable.FormattingEnabled = true;
            this.CBOParentTable.Location = new System.Drawing.Point(202, 222);
            this.CBOParentTable.Name = "CBOParentTable";
            this.CBOParentTable.Size = new System.Drawing.Size(275, 26);
            this.CBOParentTable.TabIndex = 2;
            this.CBOParentTable.SelectedIndexChanged += new System.EventHandler(this.CBOParentTable_SelectedIndexChanged);
            // 
            // txtRelationName
            // 
            this.txtRelationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRelationName.Location = new System.Drawing.Point(202, 185);
            this.txtRelationName.Multiline = true;
            this.txtRelationName.Name = "txtRelationName";
            this.txtRelationName.Size = new System.Drawing.Size(275, 25);
            this.txtRelationName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Relation Name :";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.Color.Black;
            this.BtnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCreate.Location = new System.Drawing.Point(13, 392);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(172, 35);
            this.BtnCreate.TabIndex = 6;
            this.BtnCreate.Text = "&Create Relation";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExit.Location = new System.Drawing.Point(316, 392);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(161, 35);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CreateRelations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 444);
            this.Controls.Add(this.panel1);
            this.Name = "CreateRelations";
            this.Text = "Create Relation";
            this.Load += new System.EventHandler(this.CreateRelations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBOForeignTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBOParentTable;
        private System.Windows.Forms.TextBox txtRelationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBOForeignKey;
        private System.Windows.Forms.ComboBox CBOPrimaryKey;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}