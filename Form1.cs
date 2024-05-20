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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Admin.Text = " ";
            Password.Text = " ";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Admin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(Admin.Text ==" " && Password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if(Admin.Text == "Admin" && Password.Text == "Password")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide(); // this is for hidding the current login page when you have successfully

            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomForm welcom = new WelcomForm();
            welcom.Show();
            this.Close();
        }
    }
}
