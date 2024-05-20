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
    public partial class WelcomForm : Form
    {
        public WelcomForm()
        {
            InitializeComponent();
        }

        private void HOMEbtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         UserLogin login = new UserLogin();
            login.Show();
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DocorForm form = new DocorForm();
            form.Show();
            this.Hide();
        }
    }
}
