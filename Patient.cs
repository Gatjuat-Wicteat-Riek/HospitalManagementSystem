using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            DisplayPatient();
        }
        readonly SqlConnection connectDb = new SqlConnection("Data Source=COLOMBIA-RIEK\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");
        private void DisplayPatient()
        {
            try
            {
                connectDb.Open();
                string query = "SELECT * FROM Patient";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectDb);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                PatientdataGridView.DataSource = ds.Tables[0];
                connectDb.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectDb.Close();
            }
        }
        

        private void Patientbtn_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ADDbnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (PATID.Text == " " || PATNAME.Text == " " || PATAGE.Text == " " || PATGEN.Text == " " || PATADD.Text == " " || PATPHONE.Text == " " || BLOODGROUP.Text == " " || PATMDSE.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }
                else
                {
                    connectDb.Open();
                    string query = "INSERT INTO Patient VALUES('" + PATID.Text + "', '" + PATNAME.Text + "', '" + PATADD.Text + "', '" + PATAGE.Text + "', '" + PATPHONE.Text + "', '" + PATGEN.Text + "', '" + BLOODGROUP.Text + "', '" + PATMDSE.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record added successfully");
                    DisplayPatient();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connectDb.Close();
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            DisplayPatient();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UPDATEbtN_Click(object sender, EventArgs e)
        {

            try
            {

                if (PATID.Text == " " || PATNAME.Text == " " || PATAGE.Text == " " || PATGEN.Text == " " || PATADD.Text == " " || PATPHONE.Text == " " || BLOODGROUP.Text == " " || PATMDSE.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }

                else
                {
                    connectDb.Open();
                    string query = "UPDATE Patient SET PName =@PName, PAddress =@PAddress, PAge =@PAge, PGender =@PGender, PPhone =@PPhone, BLoodGroup =@BloodGroup, MajorDisease =@MajorDisease WHERE PatId =@PatId";

                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.Parameters.AddWithValue("@PatId", PATID.Text);
                    cmd.Parameters.AddWithValue("@PName", PATNAME.Text);
                    cmd.Parameters.AddWithValue("@PAddress", PATADD.Text);
                    cmd.Parameters.AddWithValue("@PAge", PATAGE.Text);
                    cmd.Parameters.AddWithValue("@PGender", PATGEN.Text);
                    cmd.Parameters.AddWithValue("@PPhone", PATPHONE.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", BLOODGROUP.Text);
                    cmd.Parameters.AddWithValue("@MajorDisease", PATMDSE.Text);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record Updated Successfully!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Cannot Update the Record", ex.Message);

            }
            finally { connectDb.Close(); }
            DisplayPatient();
        }

        private void DELETEbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PATID.Text == " ")
                {
                    MessageBox.Show("Enter the Patient ID");
                }
                else
                {
                    connectDb.Open();
                    string query = "DELETE FROM Patient WHERE PatId='" + PATID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record Deleted Successfully");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! can't Delete the record.", ex.Message);
            }
            finally
            {
                connectDb.Close();
            }
            DisplayPatient();
        }

        private void RESETbtn_Click(object sender, EventArgs e)
        {
            PATID.Text = " ";
            PATNAME.Text = " ";
            PATADD.Text = "";
            PATGEN.Text = "";
            PATPHONE.Text = "";
            BLOODGROUP.Text = "";
            PATAGE.Text = "";
            PATMDSE.Text = "";
        }

        private void HOMEbtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void PatientdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PATID.Text = PatientdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                PATNAME.Text = PatientdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                PATADD.Text = PatientdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                PATAGE.Text = PatientdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                PATPHONE.Text = PatientdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                PATGEN.Text = PatientdataGridView.SelectedRows[0].Cells[5].Value.ToString();
                BLOODGROUP.Text = PatientdataGridView.SelectedRows[0].Cells[6].Value.ToString();
                PATMDSE.Text = PatientdataGridView.SelectedRows[0].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred", ex.Message);
            }
            finally { connectDb.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }

        

}
