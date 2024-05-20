namespace HMS
{
    partial class Diagnosis
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
            this.HomeTitle = new System.Windows.Forms.Label();
            this.DiagonosisPic = new System.Windows.Forms.PictureBox();
            this.DIAID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DIATEST = new System.Windows.Forms.TextBox();
            this.DIAMED = new System.Windows.Forms.TextBox();
            this.DIASYM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UPDATEbtN = new System.Windows.Forms.Button();
            this.HOMEbtn = new System.Windows.Forms.Button();
            this.RESETbtn = new System.Windows.Forms.Button();
            this.DELETEbtn = new System.Windows.Forms.Button();
            this.ADDbnt = new System.Windows.Forms.Button();
            this.DiagnosisdataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.SMPATNAM = new System.Windows.Forms.Label();
            this.SMDIATEST = new System.Windows.Forms.Label();
            this.SMSYM = new System.Windows.Forms.Label();
            this.SMMED = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.DIAPATID = new System.Windows.Forms.ComboBox();
            this.DIAPATNAME = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DiagonosisPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(128, 86);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(153, 31);
            this.HomeTitle.TabIndex = 11;
            this.HomeTitle.Text = "DIAGNOSIS";
            // 
            // DiagonosisPic
            // 
            this.DiagonosisPic.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DiagonosisPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiagonosisPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiagonosisPic.Image = global::HMS.Properties.Resources.diagonsis;
            this.DiagonosisPic.Location = new System.Drawing.Point(-1, 0);
            this.DiagonosisPic.Name = "DiagonosisPic";
            this.DiagonosisPic.Size = new System.Drawing.Size(125, 108);
            this.DiagonosisPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiagonosisPic.TabIndex = 12;
            this.DiagonosisPic.TabStop = false;
            // 
            // DIAID
            // 
            this.DIAID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DIAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIAID.Location = new System.Drawing.Point(218, 159);
            this.DIAID.Name = "DIAID";
            this.DIAID.Size = new System.Drawing.Size(180, 26);
            this.DIAID.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "DIAGNOSIS ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "PATIENT NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "PATIENT ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "DIAGNOSIS TEST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "MEDICINES";
            // 
            // DIATEST
            // 
            this.DIATEST.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DIATEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIATEST.Location = new System.Drawing.Point(218, 364);
            this.DIATEST.Name = "DIATEST";
            this.DIATEST.Size = new System.Drawing.Size(180, 26);
            this.DIATEST.TabIndex = 25;
            // 
            // DIAMED
            // 
            this.DIAMED.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DIAMED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIAMED.Location = new System.Drawing.Point(218, 417);
            this.DIAMED.Name = "DIAMED";
            this.DIAMED.Size = new System.Drawing.Size(180, 26);
            this.DIAMED.TabIndex = 26;
            // 
            // DIASYM
            // 
            this.DIASYM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DIASYM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIASYM.Location = new System.Drawing.Point(218, 315);
            this.DIASYM.Name = "DIASYM";
            this.DIASYM.Size = new System.Drawing.Size(180, 26);
            this.DIASYM.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "SYMPTOMS";
            // 
            // UPDATEbtN
            // 
            this.UPDATEbtN.BackColor = System.Drawing.Color.Teal;
            this.UPDATEbtN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATEbtN.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbtN.Location = new System.Drawing.Point(255, 486);
            this.UPDATEbtN.Name = "UPDATEbtN";
            this.UPDATEbtN.Size = new System.Drawing.Size(129, 43);
            this.UPDATEbtN.TabIndex = 38;
            this.UPDATEbtN.Text = "UPDATE";
            this.UPDATEbtN.UseVisualStyleBackColor = false;
            this.UPDATEbtN.Click += new System.EventHandler(this.UPDATEbtN_Click);
            // 
            // HOMEbtn
            // 
            this.HOMEbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.HOMEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HOMEbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOMEbtn.Location = new System.Drawing.Point(840, 486);
            this.HOMEbtn.Name = "HOMEbtn";
            this.HOMEbtn.Size = new System.Drawing.Size(129, 43);
            this.HOMEbtn.TabIndex = 37;
            this.HOMEbtn.Text = "HOME";
            this.HOMEbtn.UseVisualStyleBackColor = false;
            this.HOMEbtn.Click += new System.EventHandler(this.HOMEbtn_Click);
            // 
            // RESETbtn
            // 
            this.RESETbtn.BackColor = System.Drawing.Color.Red;
            this.RESETbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESETbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESETbtn.Location = new System.Drawing.Point(649, 486);
            this.RESETbtn.Name = "RESETbtn";
            this.RESETbtn.Size = new System.Drawing.Size(129, 43);
            this.RESETbtn.TabIndex = 36;
            this.RESETbtn.Text = "RESET";
            this.RESETbtn.UseVisualStyleBackColor = false;
            this.RESETbtn.Click += new System.EventHandler(this.RESETbtn_Click);
            // 
            // DELETEbtn
            // 
            this.DELETEbtn.BackColor = System.Drawing.Color.Red;
            this.DELETEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETEbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEbtn.Location = new System.Drawing.Point(446, 486);
            this.DELETEbtn.Name = "DELETEbtn";
            this.DELETEbtn.Size = new System.Drawing.Size(129, 43);
            this.DELETEbtn.TabIndex = 35;
            this.DELETEbtn.Text = "DELETE";
            this.DELETEbtn.UseVisualStyleBackColor = false;
            this.DELETEbtn.Click += new System.EventHandler(this.DELETEbtn_Click);
            // 
            // ADDbnt
            // 
            this.ADDbnt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ADDbnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDbnt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbnt.Location = new System.Drawing.Point(53, 486);
            this.ADDbnt.Name = "ADDbnt";
            this.ADDbnt.Size = new System.Drawing.Size(129, 43);
            this.ADDbnt.TabIndex = 34;
            this.ADDbnt.Text = "ADD";
            this.ADDbnt.UseVisualStyleBackColor = false;
            this.ADDbnt.Click += new System.EventHandler(this.ADDbnt_Click);
            // 
            // DiagnosisdataGridView
            // 
            this.DiagnosisdataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DiagnosisdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosisdataGridView.Location = new System.Drawing.Point(53, 554);
            this.DiagnosisdataGridView.Name = "DiagnosisdataGridView";
            this.DiagnosisdataGridView.Size = new System.Drawing.Size(921, 220);
            this.DiagnosisdataGridView.TabIndex = 39;
            this.DiagnosisdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisdataGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(675, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "DIAGNOSIS SUMMARY";
            // 
            // SMPATNAM
            // 
            this.SMPATNAM.AutoSize = true;
            this.SMPATNAM.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMPATNAM.Location = new System.Drawing.Point(622, 178);
            this.SMPATNAM.Name = "SMPATNAM";
            this.SMPATNAM.Size = new System.Drawing.Size(121, 21);
            this.SMPATNAM.TabIndex = 41;
            this.SMPATNAM.Text = "PATIENT NAME";
            // 
            // SMDIATEST
            // 
            this.SMDIATEST.AutoSize = true;
            this.SMDIATEST.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMDIATEST.Location = new System.Drawing.Point(815, 178);
            this.SMDIATEST.Name = "SMDIATEST";
            this.SMDIATEST.Size = new System.Drawing.Size(134, 21);
            this.SMDIATEST.TabIndex = 42;
            this.SMDIATEST.Text = "DIAGNOSIS TEST";
            // 
            // SMSYM
            // 
            this.SMSYM.AutoSize = true;
            this.SMSYM.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMSYM.Location = new System.Drawing.Point(622, 349);
            this.SMSYM.Name = "SMSYM";
            this.SMSYM.Size = new System.Drawing.Size(97, 21);
            this.SMSYM.TabIndex = 43;
            this.SMSYM.Text = "SYMPTOMS";
            // 
            // SMMED
            // 
            this.SMMED.AutoSize = true;
            this.SMMED.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMMED.Location = new System.Drawing.Point(856, 349);
            this.SMMED.Name = "SMMED";
            this.SMMED.Size = new System.Drawing.Size(93, 21);
            this.SMMED.TabIndex = 44;
            this.SMMED.Text = "MEDICINES";
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(998, -1);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(35, 36);
            this.clearbtn.TabIndex = 46;
            this.clearbtn.Text = "X";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // DIAPATID
            // 
            this.DIAPATID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DIAPATID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIAPATID.FormattingEnabled = true;
            this.DIAPATID.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.DIAPATID.Location = new System.Drawing.Point(218, 213);
            this.DIAPATID.Name = "DIAPATID";
            this.DIAPATID.Size = new System.Drawing.Size(180, 28);
            this.DIAPATID.TabIndex = 47;
            // 
            // DIAPATNAME
            // 
            this.DIAPATNAME.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DIAPATNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIAPATNAME.Location = new System.Drawing.Point(218, 263);
            this.DIAPATNAME.Name = "DIAPATNAME";
            this.DIAPATNAME.Size = new System.Drawing.Size(180, 26);
            this.DIAPATNAME.TabIndex = 48;
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1030, 788);
            this.Controls.Add(this.DIAPATNAME);
            this.Controls.Add(this.DIAPATID);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.SMMED);
            this.Controls.Add(this.SMSYM);
            this.Controls.Add(this.SMDIATEST);
            this.Controls.Add(this.SMPATNAM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DiagnosisdataGridView);
            this.Controls.Add(this.UPDATEbtN);
            this.Controls.Add(this.HOMEbtn);
            this.Controls.Add(this.RESETbtn);
            this.Controls.Add(this.DELETEbtn);
            this.Controls.Add(this.ADDbnt);
            this.Controls.Add(this.DIASYM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DIAMED);
            this.Controls.Add(this.DIATEST);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DIAID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiagonosisPic);
            this.Controls.Add(this.HomeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiagonosisPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.PictureBox DiagonosisPic;
        private System.Windows.Forms.TextBox DIAID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DIATEST;
        private System.Windows.Forms.TextBox DIAMED;
        private System.Windows.Forms.TextBox DIASYM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UPDATEbtN;
        private System.Windows.Forms.Button HOMEbtn;
        private System.Windows.Forms.Button RESETbtn;
        private System.Windows.Forms.Button DELETEbtn;
        private System.Windows.Forms.Button ADDbnt;
        private System.Windows.Forms.DataGridView DiagnosisdataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SMPATNAM;
        private System.Windows.Forms.Label SMDIATEST;
        private System.Windows.Forms.Label SMSYM;
        private System.Windows.Forms.Label SMMED;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.ComboBox DIAPATID;
        private System.Windows.Forms.TextBox DIAPATNAME;
    }
}