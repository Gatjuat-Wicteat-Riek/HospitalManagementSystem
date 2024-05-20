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
    public partial class DocorForm : Form
    {
        public DocorForm()
        {
            InitializeComponent();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomForm wel = new WelcomForm();
            wel.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (docbnt.Text == " " && docpassbtn.Text == " ")
            {
                MessageBox.Show("User field and Password Cannot be null.");
            }
            else if (docbnt.Text == "Doctor1" || docbnt.Text == "Doctor2" || docbnt.Text == "Doctor3" && docpassbtn.Text == "Password1" || docpassbtn.Text == "Password2" || docpassbtn.Text == "Password3")
            {
                DoctorHome obj = new DoctorHome();
                obj.Show();
                this.Hide(); // this is for hidding the current login page when you have successfully

            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            docbnt.Text = " ";  
            docpassbtn.Text = " ";  
        }
    }
    
}
