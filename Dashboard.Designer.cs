namespace HMS
{
    partial class Dashboard
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.PendingAppProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.PendingNum = new System.Windows.Forms.Label();
            this.PatientGunna = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.PatientNum = new System.Windows.Forms.Label();
            this.DoctorGunna = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.DoctorNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NextAppGuna = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.NextNum = new System.Windows.Forms.Label();
            this.HOMEbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HomeImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PendingAppProgress.SuspendLayout();
            this.PatientGunna.SuspendLayout();
            this.DoctorGunna.SuspendLayout();
            this.NextAppGuna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Indigo;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(-1, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 659);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(12, 353);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(271, 52);
            this.HomeTitle.TabIndex = 14;
            this.HomeTitle.Text = "DASHBOARD";
            // 
            // PendingAppProgress
            // 
            this.PendingAppProgress.Controls.Add(this.PendingNum);
            this.PendingAppProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PendingAppProgress.FillColor = System.Drawing.Color.Indigo;
            this.PendingAppProgress.FillThickness = 18;
            this.PendingAppProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PendingAppProgress.ForeColor = System.Drawing.Color.Red;
            this.PendingAppProgress.Location = new System.Drawing.Point(344, 125);
            this.PendingAppProgress.Minimum = 0;
            this.PendingAppProgress.Name = "PendingAppProgress";
            this.PendingAppProgress.ProgressColor = System.Drawing.Color.DeepPink;
            this.PendingAppProgress.ProgressColor2 = System.Drawing.Color.DarkBlue;
            this.PendingAppProgress.ProgressThickness = 18;
            this.PendingAppProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PendingAppProgress.Size = new System.Drawing.Size(199, 199);
            this.PendingAppProgress.TabIndex = 17;
            this.PendingAppProgress.Text = "GunaProgress";
            // 
            // PendingNum
            // 
            this.PendingNum.AutoSize = true;
            this.PendingNum.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PendingNum.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingNum.Location = new System.Drawing.Point(81, 81);
            this.PendingNum.Name = "PendingNum";
            this.PendingNum.Size = new System.Drawing.Size(35, 30);
            this.PendingNum.TabIndex = 23;
            this.PendingNum.Text = "N";
            // 
            // PatientGunna
            // 
            this.PatientGunna.Controls.Add(this.PatientNum);
            this.PatientGunna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientGunna.FillColor = System.Drawing.Color.Indigo;
            this.PatientGunna.FillThickness = 18;
            this.PatientGunna.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PatientGunna.ForeColor = System.Drawing.Color.White;
            this.PatientGunna.Location = new System.Drawing.Point(629, 125);
            this.PatientGunna.Minimum = 0;
            this.PatientGunna.Name = "PatientGunna";
            this.PatientGunna.ProgressColor = System.Drawing.Color.DarkMagenta;
            this.PatientGunna.ProgressColor2 = System.Drawing.Color.MidnightBlue;
            this.PatientGunna.ProgressThickness = 18;
            this.PatientGunna.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PatientGunna.Size = new System.Drawing.Size(199, 199);
            this.PatientGunna.TabIndex = 18;
            this.PatientGunna.Text = "GunaProgress";
            // 
            // PatientNum
            // 
            this.PatientNum.AutoSize = true;
            this.PatientNum.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PatientNum.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNum.ForeColor = System.Drawing.Color.DarkRed;
            this.PatientNum.Location = new System.Drawing.Point(82, 81);
            this.PatientNum.Name = "PatientNum";
            this.PatientNum.Size = new System.Drawing.Size(35, 30);
            this.PatientNum.TabIndex = 24;
            this.PatientNum.Text = "N";
            // 
            // DoctorGunna
            // 
            this.DoctorGunna.Controls.Add(this.DoctorNum);
            this.DoctorGunna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorGunna.FillColor = System.Drawing.Color.Indigo;
            this.DoctorGunna.FillThickness = 18;
            this.DoctorGunna.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DoctorGunna.ForeColor = System.Drawing.Color.White;
            this.DoctorGunna.Location = new System.Drawing.Point(305, 389);
            this.DoctorGunna.Minimum = 0;
            this.DoctorGunna.Name = "DoctorGunna";
            this.DoctorGunna.ProgressColor = System.Drawing.Color.MediumSlateBlue;
            this.DoctorGunna.ProgressColor2 = System.Drawing.Color.Blue;
            this.DoctorGunna.ProgressThickness = 18;
            this.DoctorGunna.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DoctorGunna.Size = new System.Drawing.Size(269, 269);
            this.DoctorGunna.TabIndex = 18;
            this.DoctorGunna.Text = "GunaProgress";
            // 
            // DoctorNum
            // 
            this.DoctorNum.AutoSize = true;
            this.DoctorNum.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoctorNum.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNum.ForeColor = System.Drawing.Color.Maroon;
            this.DoctorNum.Location = new System.Drawing.Point(120, 136);
            this.DoctorNum.Name = "DoctorNum";
            this.DoctorNum.Size = new System.Drawing.Size(35, 30);
            this.DoctorNum.TabIndex = 24;
            this.DoctorNum.Text = "N";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pending Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Patients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Doctors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "NextApp";
            // 
            // NextAppGuna
            // 
            this.NextAppGuna.Controls.Add(this.NextNum);
            this.NextAppGuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextAppGuna.FillColor = System.Drawing.Color.Indigo;
            this.NextAppGuna.FillThickness = 18;
            this.NextAppGuna.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NextAppGuna.ForeColor = System.Drawing.Color.White;
            this.NextAppGuna.Location = new System.Drawing.Point(603, 381);
            this.NextAppGuna.Minimum = 0;
            this.NextAppGuna.Name = "NextAppGuna";
            this.NextAppGuna.ProgressColor = System.Drawing.Color.MidnightBlue;
            this.NextAppGuna.ProgressColor2 = System.Drawing.Color.MediumVioletRed;
            this.NextAppGuna.ProgressThickness = 18;
            this.NextAppGuna.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NextAppGuna.Size = new System.Drawing.Size(277, 277);
            this.NextAppGuna.TabIndex = 18;
            this.NextAppGuna.Text = "GunaProgress";
            // 
            // NextNum
            // 
            this.NextNum.AutoSize = true;
            this.NextNum.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NextNum.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextNum.ForeColor = System.Drawing.Color.Red;
            this.NextNum.Location = new System.Drawing.Point(16, 115);
            this.NextNum.Name = "NextNum";
            this.NextNum.Size = new System.Drawing.Size(110, 32);
            this.NextNum.TabIndex = 24;
            this.NextNum.Text = "NextApp";
            // 
            // HOMEbtn
            // 
            this.HOMEbtn.BackColor = System.Drawing.Color.Teal;
            this.HOMEbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HOMEbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOMEbtn.ForeColor = System.Drawing.Color.Crimson;
            this.HOMEbtn.Location = new System.Drawing.Point(12, 490);
            this.HOMEbtn.Name = "HOMEbtn";
            this.HOMEbtn.Size = new System.Drawing.Size(271, 43);
            this.HOMEbtn.TabIndex = 38;
            this.HOMEbtn.Text = "BACK";
            this.HOMEbtn.UseVisualStyleBackColor = false;
            this.HOMEbtn.Click += new System.EventHandler(this.HOMEbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(869, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeImage
            // 
            this.HomeImage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HomeImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeImage.Image = global::HMS.Properties.Resources.dashboard1;
            this.HomeImage.Location = new System.Drawing.Point(-1, -1);
            this.HomeImage.Name = "HomeImage";
            this.HomeImage.Size = new System.Drawing.Size(300, 312);
            this.HomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeImage.TabIndex = 15;
            this.HomeImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(393, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 37);
            this.label5.TabIndex = 40;
            this.label5.Text = "Welcome to Admin Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(902, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HOMEbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextAppGuna);
            this.Controls.Add(this.DoctorGunna);
            this.Controls.Add(this.PatientGunna);
            this.Controls.Add(this.PendingAppProgress);
            this.Controls.Add(this.HomeImage);
            this.Controls.Add(this.HomeTitle);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.PendingAppProgress.ResumeLayout(false);
            this.PendingAppProgress.PerformLayout();
            this.PatientGunna.ResumeLayout(false);
            this.PatientGunna.PerformLayout();
            this.DoctorGunna.ResumeLayout(false);
            this.DoctorGunna.PerformLayout();
            this.NextAppGuna.ResumeLayout(false);
            this.NextAppGuna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox HomeImage;
        private System.Windows.Forms.Label HomeTitle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PendingAppProgress;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PatientGunna;
        private Guna.UI2.WinForms.Guna2CircleProgressBar DoctorGunna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar NextAppGuna;
        private System.Windows.Forms.Label PendingNum;
        private System.Windows.Forms.Label PatientNum;
        private System.Windows.Forms.Label DoctorNum;
        private System.Windows.Forms.Label NextNum;
        private System.Windows.Forms.Button HOMEbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}