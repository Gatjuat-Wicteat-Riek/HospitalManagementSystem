namespace HMS
{
    partial class Doctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DOCID = new System.Windows.Forms.TextBox();
            this.DOCNAME = new System.Windows.Forms.TextBox();
            this.YOEXP = new System.Windows.Forms.TextBox();
            this.MLICSNO = new System.Windows.Forms.TextBox();
            this.docGender = new System.Windows.Forms.ComboBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.DoctordataGridView = new System.Windows.Forms.DataGridView();
            this.ADDbnt = new System.Windows.Forms.Button();
            this.UPDATEbtN = new System.Windows.Forms.Button();
            this.DELETEbtn = new System.Windows.Forms.Button();
            this.RESETbtn = new System.Windows.Forms.Button();
            this.HOMEbtn = new System.Windows.Forms.Button();
            this.DoctorPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoctordataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(125, 80);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(121, 31);
            this.HomeTitle.TabIndex = 4;
            this.HomeTitle.Text = "DOCTOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOCTOR GENDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOCTOR NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "DOCTOR ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(678, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "MEDICAL LICENSE NUMBER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "YEARS OF EXPERIENCE";
            // 
            // DOCID
            // 
            this.DOCID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DOCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOCID.Location = new System.Drawing.Point(26, 198);
            this.DOCID.Name = "DOCID";
            this.DOCID.Size = new System.Drawing.Size(75, 26);
            this.DOCID.TabIndex = 11;
            // 
            // DOCNAME
            // 
            this.DOCNAME.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DOCNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOCNAME.Location = new System.Drawing.Point(134, 198);
            this.DOCNAME.Name = "DOCNAME";
            this.DOCNAME.Size = new System.Drawing.Size(180, 26);
            this.DOCNAME.TabIndex = 12;
            // 
            // YOEXP
            // 
            this.YOEXP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.YOEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YOEXP.Location = new System.Drawing.Point(490, 198);
            this.YOEXP.Name = "YOEXP";
            this.YOEXP.Size = new System.Drawing.Size(167, 26);
            this.YOEXP.TabIndex = 13;
            // 
            // MLICSNO
            // 
            this.MLICSNO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MLICSNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLICSNO.Location = new System.Drawing.Point(682, 198);
            this.MLICSNO.Name = "MLICSNO";
            this.MLICSNO.Size = new System.Drawing.Size(208, 26);
            this.MLICSNO.TabIndex = 14;
            // 
            // docGender
            // 
            this.docGender.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.docGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docGender.FormattingEnabled = true;
            this.docGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.docGender.Location = new System.Drawing.Point(333, 196);
            this.docGender.Name = "docGender";
            this.docGender.Size = new System.Drawing.Size(129, 28);
            this.docGender.TabIndex = 15;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(886, -3);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(35, 36);
            this.clearbtn.TabIndex = 16;
            this.clearbtn.Text = "X";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // DoctordataGridView
            // 
            this.DoctordataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoctordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctordataGridView.Location = new System.Drawing.Point(26, 249);
            this.DoctordataGridView.Name = "DoctordataGridView";
            this.DoctordataGridView.Size = new System.Drawing.Size(864, 220);
            this.DoctordataGridView.TabIndex = 17;
            this.DoctordataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctordataGridView_CellContentClick);
            // 
            // ADDbnt
            // 
            this.ADDbnt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ADDbnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDbnt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbnt.Location = new System.Drawing.Point(26, 496);
            this.ADDbnt.Name = "ADDbnt";
            this.ADDbnt.Size = new System.Drawing.Size(129, 43);
            this.ADDbnt.TabIndex = 18;
            this.ADDbnt.Text = "ADD";
            this.ADDbnt.UseVisualStyleBackColor = false;
            this.ADDbnt.Click += new System.EventHandler(this.Doctorbnt_Click);
            // 
            // UPDATEbtN
            // 
            this.UPDATEbtN.BackColor = System.Drawing.Color.Teal;
            this.UPDATEbtN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATEbtN.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbtN.Location = new System.Drawing.Point(211, 496);
            this.UPDATEbtN.Name = "UPDATEbtN";
            this.UPDATEbtN.Size = new System.Drawing.Size(129, 43);
            this.UPDATEbtN.TabIndex = 19;
            this.UPDATEbtN.Text = "UPDATE";
            this.UPDATEbtN.UseVisualStyleBackColor = false;
            this.UPDATEbtN.Click += new System.EventHandler(this.UPDATEbtN_Click);
            // 
            // DELETEbtn
            // 
            this.DELETEbtn.BackColor = System.Drawing.Color.Red;
            this.DELETEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DELETEbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEbtn.Location = new System.Drawing.Point(391, 496);
            this.DELETEbtn.Name = "DELETEbtn";
            this.DELETEbtn.Size = new System.Drawing.Size(129, 43);
            this.DELETEbtn.TabIndex = 20;
            this.DELETEbtn.Text = "DELETE";
            this.DELETEbtn.UseVisualStyleBackColor = false;
            this.DELETEbtn.Click += new System.EventHandler(this.DELETEbtn_Click);
            // 
            // RESETbtn
            // 
            this.RESETbtn.BackColor = System.Drawing.Color.Red;
            this.RESETbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESETbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESETbtn.Location = new System.Drawing.Point(567, 496);
            this.RESETbtn.Name = "RESETbtn";
            this.RESETbtn.Size = new System.Drawing.Size(129, 43);
            this.RESETbtn.TabIndex = 21;
            this.RESETbtn.Text = "RESET";
            this.RESETbtn.UseVisualStyleBackColor = false;
            this.RESETbtn.Click += new System.EventHandler(this.RESETbtn_Click);
            // 
            // HOMEbtn
            // 
            this.HOMEbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.HOMEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HOMEbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOMEbtn.Location = new System.Drawing.Point(761, 496);
            this.HOMEbtn.Name = "HOMEbtn";
            this.HOMEbtn.Size = new System.Drawing.Size(129, 43);
            this.HOMEbtn.TabIndex = 22;
            this.HOMEbtn.Text = "HOME";
            this.HOMEbtn.UseVisualStyleBackColor = false;
            this.HOMEbtn.Click += new System.EventHandler(this.HOMEbtn_Click);
            // 
            // DoctorPic
            // 
            this.DoctorPic.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoctorPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DoctorPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorPic.Image = global::HMS.Properties.Resources.doctor;
            this.DoctorPic.Location = new System.Drawing.Point(0, -1);
            this.DoctorPic.Name = "DoctorPic";
            this.DoctorPic.Size = new System.Drawing.Size(125, 96);
            this.DoctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DoctorPic.TabIndex = 5;
            this.DoctorPic.TabStop = false;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(919, 597);
            this.Controls.Add(this.HOMEbtn);
            this.Controls.Add(this.RESETbtn);
            this.Controls.Add(this.DELETEbtn);
            this.Controls.Add(this.UPDATEbtN);
            this.Controls.Add(this.ADDbnt);
            this.Controls.Add(this.DoctordataGridView);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.docGender);
            this.Controls.Add(this.MLICSNO);
            this.Controls.Add(this.YOEXP);
            this.Controls.Add(this.DOCNAME);
            this.Controls.Add(this.DOCID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorPic);
            this.Controls.Add(this.HomeTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DoctordataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DoctorPic;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DOCID;
        private System.Windows.Forms.TextBox DOCNAME;
        private System.Windows.Forms.TextBox YOEXP;
        private System.Windows.Forms.TextBox MLICSNO;
        private System.Windows.Forms.ComboBox docGender;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.DataGridView DoctordataGridView;
        private System.Windows.Forms.Button ADDbnt;
        private System.Windows.Forms.Button UPDATEbtN;
        private System.Windows.Forms.Button DELETEbtn;
        private System.Windows.Forms.Button RESETbtn;
        private System.Windows.Forms.Button HOMEbtn;
    }
}