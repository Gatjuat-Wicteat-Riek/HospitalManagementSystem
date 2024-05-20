namespace HMS
{
    partial class Appointment
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
            this.clearbtn = new System.Windows.Forms.Button();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HomeImage = new System.Windows.Forms.PictureBox();
            this.Treatment = new System.Windows.Forms.Label();
            this.APPDATE = new System.Windows.Forms.DateTimePicker();
            this.APPTIME = new System.Windows.Forms.DateTimePicker();
            this.HOMEbtn = new System.Windows.Forms.Button();
            this.RESETbtn = new System.Windows.Forms.Button();
            this.DELETEbtn = new System.Windows.Forms.Button();
            this.UPDATEbtN = new System.Windows.Forms.Button();
            this.ADDbnt = new System.Windows.Forms.Button();
            this.APPPATNAME = new System.Windows.Forms.ComboBox();
            this.APPTREAMENT = new System.Windows.Forms.ComboBox();
            this.APPID = new System.Windows.Forms.TextBox();
            this.APID = new System.Windows.Forms.Label();
            this.AppointmentdataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(888, 262);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(35, 36);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "X";
            this.clearbtn.UseVisualStyleBackColor = false;
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(117, 75);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(201, 31);
            this.HomeTitle.TabIndex = 12;
            this.HomeTitle.Text = "APPOINTMENT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(810, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "APP DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "APP TIME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "PATIENT NAME";
            // 
            // HomeImage
            // 
            this.HomeImage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HomeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeImage.Image = global::HMS.Properties.Resources.appointment;
            this.HomeImage.Location = new System.Drawing.Point(0, 0);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(111, 86);
            this.HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeImage.TabIndex = 13;
            this.HomeImage.TabStop = false;
            // 
            // Treatment
            // 
            this.Treatment.AutoSize = true;
            this.Treatment.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatment.Location = new System.Drawing.Point(63, 259);
            this.Treatment.Name = "Treatment";
            this.Treatment.Size = new System.Drawing.Size(100, 21);
            this.Treatment.TabIndex = 30;
            this.Treatment.Text = "TREATMENT";
            // 
            // APPDATE
            // 
            this.APPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.APPDATE.Location = new System.Drawing.Point(549, 197);
            this.APPDATE.Name = "APPDATE";
            this.APPDATE.Size = new System.Drawing.Size(200, 29);
            this.APPDATE.TabIndex = 31;
            // 
            // APPTIME
            // 
            this.APPTIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.APPTIME.Location = new System.Drawing.Point(549, 253);
            this.APPTIME.Name = "APPTIME";
            this.APPTIME.Size = new System.Drawing.Size(200, 29);
            this.APPTIME.TabIndex = 32;
            // 
            // HOMEbtn
            // 
            this.HOMEbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.HOMEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HOMEbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOMEbtn.Location = new System.Drawing.Point(647, 322);
            this.HOMEbtn.Name = "HOMEbtn";
            this.HOMEbtn.Size = new System.Drawing.Size(102, 43);
            this.HOMEbtn.TabIndex = 37;
            this.HOMEbtn.Text = "BACK";
            this.HOMEbtn.UseVisualStyleBackColor = false;
            this.HOMEbtn.Click += new System.EventHandler(this.HOMEbtn_Click);
            // 
            // RESETbtn
            // 
            this.RESETbtn.BackColor = System.Drawing.Color.Red;
            this.RESETbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESETbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESETbtn.Location = new System.Drawing.Point(497, 322);
            this.RESETbtn.Name = "RESETbtn";
            this.RESETbtn.Size = new System.Drawing.Size(94, 43);
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
            this.DELETEbtn.Location = new System.Drawing.Point(353, 322);
            this.DELETEbtn.Name = "DELETEbtn";
            this.DELETEbtn.Size = new System.Drawing.Size(97, 43);
            this.DELETEbtn.TabIndex = 35;
            this.DELETEbtn.Text = "DELETE";
            this.DELETEbtn.UseVisualStyleBackColor = false;
            this.DELETEbtn.Click += new System.EventHandler(this.DELETEbtn_Click);
            // 
            // UPDATEbtN
            // 
            this.UPDATEbtN.BackColor = System.Drawing.Color.Teal;
            this.UPDATEbtN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPDATEbtN.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEbtN.Location = new System.Drawing.Point(193, 322);
            this.UPDATEbtN.Name = "UPDATEbtN";
            this.UPDATEbtN.Size = new System.Drawing.Size(108, 43);
            this.UPDATEbtN.TabIndex = 34;
            this.UPDATEbtN.Text = "UPDATE";
            this.UPDATEbtN.UseVisualStyleBackColor = false;
            this.UPDATEbtN.Click += new System.EventHandler(this.UPDATEbtN_Click);
            // 
            // ADDbnt
            // 
            this.ADDbnt.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ADDbnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADDbnt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbnt.Location = new System.Drawing.Point(67, 322);
            this.ADDbnt.Name = "ADDbnt";
            this.ADDbnt.Size = new System.Drawing.Size(91, 43);
            this.ADDbnt.TabIndex = 33;
            this.ADDbnt.Text = "ADD";
            this.ADDbnt.UseVisualStyleBackColor = false;
            this.ADDbnt.Click += new System.EventHandler(this.ADDbnt_Click);
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
            this.APPPATNAME.Location = new System.Drawing.Point(206, 202);
            this.APPPATNAME.Name = "APPPATNAME";
            this.APPPATNAME.Size = new System.Drawing.Size(185, 28);
            this.APPPATNAME.TabIndex = 38;
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
            this.APPTREAMENT.Location = new System.Drawing.Point(206, 254);
            this.APPTREAMENT.Name = "APPTREAMENT";
            this.APPTREAMENT.Size = new System.Drawing.Size(185, 28);
            this.APPTREAMENT.TabIndex = 39;
            // 
            // APPID
            // 
            this.APPID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.APPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APPID.Location = new System.Drawing.Point(206, 160);
            this.APPID.Name = "APPID";
            this.APPID.Size = new System.Drawing.Size(185, 26);
            this.APPID.TabIndex = 40;
            // 
            // APID
            // 
            this.APID.AutoSize = true;
            this.APID.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APID.Location = new System.Drawing.Point(66, 160);
            this.APID.Name = "APID";
            this.APID.Size = new System.Drawing.Size(55, 21);
            this.APID.TabIndex = 41;
            this.APID.Text = "APPID";
            // 
            // AppointmentdataGridView
            // 
            this.AppointmentdataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.AppointmentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentdataGridView.Location = new System.Drawing.Point(67, 392);
            this.AppointmentdataGridView.Name = "AppointmentdataGridView";
            this.AppointmentdataGridView.Size = new System.Drawing.Size(682, 220);
            this.AppointmentdataGridView.TabIndex = 42;
            this.AppointmentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentdataGridView_CellContentClick);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(844, 638);
            this.Controls.Add(this.AppointmentdataGridView);
            this.Controls.Add(this.APID);
            this.Controls.Add(this.APPID);
            this.Controls.Add(this.APPTREAMENT);
            this.Controls.Add(this.APPPATNAME);
            this.Controls.Add(this.HOMEbtn);
            this.Controls.Add(this.RESETbtn);
            this.Controls.Add(this.DELETEbtn);
            this.Controls.Add(this.UPDATEbtN);
            this.Controls.Add(this.ADDbnt);
            this.Controls.Add(this.APPTIME);
            this.Controls.Add(this.APPDATE);
            this.Controls.Add(this.Treatment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.HomeImage);
            this.Controls.Add(this.HomeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.PictureBox HomeImage;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Treatment;
        private System.Windows.Forms.DateTimePicker APPDATE;
        private System.Windows.Forms.DateTimePicker APPTIME;
        private System.Windows.Forms.Button HOMEbtn;
        private System.Windows.Forms.Button RESETbtn;
        private System.Windows.Forms.Button DELETEbtn;
        private System.Windows.Forms.Button UPDATEbtN;
        private System.Windows.Forms.Button ADDbnt;
        private System.Windows.Forms.ComboBox APPPATNAME;
        private System.Windows.Forms.ComboBox APPTREAMENT;
        private System.Windows.Forms.TextBox APPID;
        private System.Windows.Forms.Label APID;
        private System.Windows.Forms.DataGridView AppointmentdataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}