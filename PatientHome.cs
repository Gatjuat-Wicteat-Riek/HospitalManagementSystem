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
    public partial class PatientHome : Form
    {
        public PatientHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentPatient app = new AppointmentPatient();
            app.Show(); 
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
