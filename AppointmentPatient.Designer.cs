namespace HMS
{
    partial class AppointmentPatient
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
            this.AppointmentdataGridView = new System.Windows.Forms.DataGridView();
            this.APID = new System.Windows.Forms.Label();
            this.APPID = new System.Windows.Forms.TextBox();
            this.APPTREAMENT = new System.Windows.Forms.ComboBox();
            this.HOMEbtn = new System.Windows.Forms.Button();
            this.RESETbtn = new System.Windows.Forms.Button();
            this.UPDATEbtN = new System.Windows.Forms.Button();
            this.ADDbnt = new System.Windows.Forms.Button();
            this.APPTIME = new System.Windows.Forms.DateTimePicker();
            this.APPDATE = new System.Windows.Forms.DateTimePicker();
            this.Treatment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.APPPATNAME = new System.Windows.Forms.ComboBox();
            this.HomeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentdataGridView
            // 
            this.AppointmentdataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.AppointmentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentdataGridView.Location = new System.Drawing.Point(30, 389);
            this.AppointmentdataGridView.Name = "AppointmentdataGridView";
            this.AppointmentdataGridView.Size = new System.Drawing.Size(682, 220);
            this.AppointmentdataGridView.TabIndex = 60;
            this.AppointmentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentdataGridView_CellContentClick);
            // 
            // APID
            // 
            this.APID.AutoSize = true;
            this.APID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APID.Location = new System.Drawing.Point(29, 157);
            this.APID.Name = "APID";
            this.APID.Size = new System.Drawing.Size(55, 21);
            this.APID.TabIndex = 59;
            this.APID.Text = "APPID";
            // 
            // APPID
            // 
            this.APPID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.APPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPID.Location = new System.Drawing.Point(169, 157);
            this.APPID.Name = "APPID";
            this.APPID.Size = new System.Drawing.Size(185, 26);
            this.APPID.TabIndex = 58;
            // 
            // APPTREAMENT
            // 
            this.APPTREAMENT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.APPTREAMENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPTREAMENT.FormattingEnabled = true;
            this.APPTREAMENT.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.APPTREAMENT.Location = new System.Drawing.Point(169, 251);
            this.APPTREAMENT.Name = "APPTREAMENT";
            this.APPTREAMENT.Size = new System.Drawing.Size(185, 28);
            this.APPTREAMENT.TabIndex = 57;
            // 
            // HOMEbtn
            // 
            this.HOMEbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.HOMEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HOMEbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOMEbtn.Location = new System.Drawing.Point(610, 319);
            this.HOMEbtn.Name = "HOMEbtn";
            this.HOMEbtn.Size = new System.Drawing.Size(102, 43);
            this.HOMEbtn.TabIndex = 56;
            this.HOMEbtn.Text = "BACK";
            this.HOMEbtn.UseVisualStyleBackColor = false;
            // 
            // RESETbtn
            // 
            this.RESETbtn.BackColor = System.Drawing.Color.Red;
            this.RESETbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESETbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESETbtn.Location = new System.Drawing.Point(393, 319);
            this.RESETbtn.Name = "RESETbtn";
            this.RESETbtn.Size = new System.Drawing.Size(94, 43);
            this.RESETbtn.TabIndex = 55;
            this.RESETbtn.Text = "RESET";
            this.RESETbtn.UseVisualStyleBackColor = false;
            this.RESETbtn.Click += new System.EventHandler(this.RESETbtn_Click);
            // 
            // UPDATEbtN
            // 
            this.UPDATEbtN.BackColor = System.Drawing.Color.Teal;
            this.UPDATEbtN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATEbtN.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbtN.Location = new System.Drawing.Point(204, 319);
            this.UPDATEbtN.Name = "UPDATEbtN";
            this.UPDATEbtN.Size = new System.Drawing.Size(108, 43);
            this.UPDATEbtN.TabIndex = 53;
            this.UPDATEbtN.Text = "UPDATE";
            this.UPDATEbtN.UseVisualStyleBackColor = false;
            this.UPDATEbtN.Click += new System.EventHandler(this.UPDATEbtN_Click);
            // 
            // ADDbnt
            // 
            this.ADDbnt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ADDbnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDbnt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbnt.Location = new System.Drawing.Point(30, 319);
            this.ADDbnt.Name = "ADDbnt";
            this.ADDbnt.Size = new System.Drawing.Size(91, 43);
            this.ADDbnt.TabIndex = 52;
            this.ADDbnt.Text = "ADD";
            this.ADDbnt.UseVisualStyleBackColor = false;
            this.ADDbnt.Click += new System.EventHandler(this.ADDbnt_Click);
            // 
            // APPTIME
            // 
            this.APPTIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.APPTIME.Location = new System.Drawing.Point(512, 250);
            this.APPTIME.Name = "APPTIME";
            this.APPTIME.Size = new System.Drawing.Size(200, 29);
            this.APPTIME.TabIndex = 51;
            // 
            // APPDATE
            // 
            this.APPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.APPDATE.Location = new System.Drawing.Point(512, 194);
            this.APPDATE.Name = "APPDATE";
            this.APPDATE.Size = new System.Drawing.Size(200, 29);
            this.APPDATE.TabIndex = 50;
            // 
            // Treatment
            // 
            this.Treatment.AutoSize = true;
            this.Treatment.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatment.Location = new System.Drawing.Point(26, 256);
            this.Treatment.Name = "Treatment";
            this.Treatment.Size = new System.Drawing.Size(100, 21);
            this.Treatment.TabIndex = 49;
            this.Treatment.Text = "TREATMENT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "PATIENT NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "APP DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "APP TIME";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(773, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 45;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(111, 72);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(201, 31);
            this.HomeTitle.TabIndex = 43;
            this.HomeTitle.Text = "APPOINTMENT";
            // 
            // APPPATNAME
            // 
            this.APPPATNAME.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.APPPATNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPPATNAME.FormattingEnabled = true;
            this.APPPATNAME.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.APPPATNAME.Location = new System.Drawing.Point(169, 199);
            this.APPPATNAME.Name = "APPPATNAME";
            this.APPPATNAME.Size = new System.Drawing.Size(185, 28);
            this.APPPATNAME.TabIndex = 61;
            // 
            // HomeImage
            // 
            this.HomeImage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HomeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeImage.Image = global::HMS.Properties.Resources.appointment;
            this.HomeImage.Location = new System.Drawing.Point(-1, 0);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(111, 86);
            this.HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeImage.TabIndex = 44;
            this.HomeImage.TabStop = false;
            // 
            // AppointmentPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(807, 634);
            this.Controls.Add(this.APPPATNAME);
            this.Controls.Add(this.AppointmentdataGridView);
            this.Controls.Add(this.APID);
            this.Controls.Add(this.APPID);
            this.Controls.Add(this.APPTREAMENT);
            this.Controls.Add(this.HOMEbtn);
            this.Controls.Add(this.RESETbtn);
            this.Controls.Add(this.UPDATEbtN);
            this.Controls.Add(this.ADDbnt);
            this.Controls.Add(this.APPTIME);
            this.Controls.Add(this.APPDATE);
            this.Controls.Add(this.Treatment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HomeImage);
            this.Controls.Add(this.HomeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentPatient";
            this.Text = "AppointmentPatient";
            this.Load += new System.EventHandler(this.AppointmentPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentdataGridView;
        private System.Windows.Forms.Label APID;
        private System.Windows.Forms.TextBox APPID;
        private System.Windows.Forms.ComboBox APPTREAMENT;
        private System.Windows.Forms.Button HOMEbtn;
        private System.Windows.Forms.Button RESETbtn;
        private System.Windows.Forms.Button UPDATEbtN;
        private System.Windows.Forms.Button ADDbnt;
        private System.Windows.Forms.DateTimePicker APPTIME;
        private System.Windows.Forms.DateTimePicker APPDATE;
        private System.Windows.Forms.Label Treatment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox HomeImage;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.ComboBox APPPATNAME;
    }
}