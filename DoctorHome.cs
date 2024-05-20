using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class DoctorHome : Form
    {
        public DoctorHome()
        {
            InitializeComponent();
        }

        private void Patientbtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();

        }

        private void Doctorbnt_Click(object sender, EventArgs e)
        {
            DoctorDoctor bnt = new DoctorDoctor();
            bnt.Show();
            this.Hide();
        }

        private void Diagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            diagnosis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();    
        }
    }
}
