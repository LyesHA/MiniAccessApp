namespace MiniMicrosoftAccess2017
{
    partial class CreateTB
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
            this.CHKAutoIncrement = new System.Windows.Forms.CheckBox();
            this.BtnAddFields = new System.Windows.Forms.Button();
            this.CHKPrimaryKey = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFieldsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBOType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.CHKAutoIncrement);
            this.panel1.Controls.Add(this.BtnAddFields);
            this.panel1.Controls.Add(this.CHKPrimaryKey);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFieldsName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CBOType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 485);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniMicrosoftAccess2017.Properties.Resources.Sans_titre;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(139, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // CHKAutoIncrement
            // 
            this.CHKAutoIncrement.AutoSize = true;
            this.CHKAutoIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.CHKAutoIncrement.Location = new System.Drawing.Point(351, 259);
            this.CHKAutoIncrement.Name = "CHKAutoIncrement";
            this.CHKAutoIncrement.Size = new System.Drawing.Size(129, 22);
            this.CHKAutoIncrement.TabIndex = 11;
            this.CHKAutoIncrement.Text = "Auto Increment";
            this.CHKAutoIncrement.UseVisualStyleBackColor = true;
            this.CHKAutoIncrement.CheckedChanged += new System.EventHandler(this.CHKAutoIncrement_CheckedChanged);
            // 
            // BtnAddFields
            // 
            this.BtnAddFields.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFields.ForeColor = System.Drawing.Color.Black;
            this.BtnAddFields.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAddFields.Location = new System.Drawing.Point(17, 433);
            this.BtnAddFields.Name = "BtnAddFields";
            this.BtnAddFields.Size = new System.Drawing.Size(142, 38);
            this.BtnAddFields.TabIndex = 5;
            this.BtnAddFields.Text = "&Add Fields";
            this.BtnAddFields.UseVisualStyleBackColor = true;
            this.BtnAddFields.Click += new System.EventHandler(this.BtnAddFields_Click);
            // 
            // CHKPrimaryKey
            // 
            this.CHKPrimaryKey.AutoSize = true;
            this.CHKPrimaryKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.CHKPrimaryKey.Location = new System.Drawing.Point(205, 259);
            this.CHKPrimaryKey.Name = "CHKPrimaryKey";
            this.CHKPrimaryKey.Size = new System.Drawing.Size(110, 22);
            this.CHKPrimaryKey.TabIndex = 10;
            this.CHKPrimaryKey.Text = "Primary Key";
            this.CHKPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft NeoGothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "Table Creation";
            // 
            // txtFieldsName
            // 
            this.txtFieldsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFieldsName.Location = new System.Drawing.Point(205, 287);
            this.txtFieldsName.Multiline = true;
            this.txtFieldsName.Name = "txtFieldsName";
            this.txtFieldsName.Size = new System.Drawing.Size(275, 25);
            this.txtFieldsName.TabIndex = 2;
            this.txtFieldsName.TextChanged += new System.EventHandler(this.txtFieldsName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(77, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(72, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Length :";
            // 
            // CBOType
            // 
            this.CBOType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBOType.FormattingEnabled = true;
            this.CBOType.Location = new System.Drawing.Point(205, 327);
            this.CBOType.Name = "CBOType";
            this.CBOType.Size = new System.Drawing.Size(275, 28);
            this.CBOType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(87, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type :";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLength.Location = new System.Drawing.Point(205, 369);
            this.txtLength.Multiline = true;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(275, 25);
            this.txtLength.TabIndex = 4;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.Color.Black;
            this.BtnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCreate.Location = new System.Drawing.Point(171, 433);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(152, 38);
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "&Create Table";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Name :";
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTableName.Location = new System.Drawing.Point(205, 204);
            this.txtTableName.Multiline = true;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(275, 29);
            this.txtTableName.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft NeoGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnExit.Location = new System.Drawing.Point(338, 433);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(142, 38);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CreateTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 485);
            this.Controls.Add(this.panel1);
            this.Name = "CreateTB";
            this.Text = "Create Tables";
            this.Load += new System.EventHandler(this.CreateTB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.CheckBox CHKAutoIncrement;
        private System.Windows.Forms.CheckBox CHKPrimaryKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFieldsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBOType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button BtnAddFields;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}