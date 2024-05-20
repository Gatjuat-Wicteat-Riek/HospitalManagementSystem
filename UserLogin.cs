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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (UserBnt.Text == " " && PasswordUserBtn.Text == " ")
            {
                MessageBox.Show("User field and Password Cannot be null.");
            }
            else if (UserBnt.Text == "User1" || UserBnt.Text == "User2" || UserBnt.Text== "User3" && PasswordUserBtn.Text == "Password1" || PasswordUserBtn.Text =="Password2" || PasswordUserBtn.Text=="Password3")
            {
                PatientHome home = new PatientHome();
                home.Show();
                this.Hide(); // this is for hidding the current login page when you have successfully

            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
            }

        }

        private void clear_Click(object sender, EventArgs e)

        {
            UserBnt.Text = " ";
            PasswordUserBtn.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomForm wel = new WelcomForm();
            wel.Show();
            this.Hide();
        }
    }
}
