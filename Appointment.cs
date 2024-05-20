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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            DisplayAppointment();
        }
        readonly SqlConnection connectDb = new SqlConnection("Data Source=COLOMBIA-RIEK\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");
        private void DisplayAppointment()
        {
            try
            {
                connectDb.Open();
                string query = "SELECT * FROM Appointment";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectDb);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                AppointmentdataGridView.DataSource = ds.Tables[0];
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

        private void fillpatient()
        {
            connectDb.Open();
            string query = "SELECT PName FROM Patient";
            SqlCommand cmd = new SqlCommand(query, connectDb);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("PName", typeof(string));
            dataTable.Load(reader);
            APPPATNAME.ValueMember = "PName";
            APPPATNAME.DataSource = dataTable;
            connectDb.Close();

        }
        private void fillTreatment()
        {
            connectDb.Open();
            string query = "SELECT Medicines FROM Diagnosis";
            SqlCommand cmd = new SqlCommand(query, connectDb);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Medicines", typeof(string));
            dataTable.Load(reader);
            APPTREAMENT.ValueMember = "Medicines";
            APPTREAMENT.DataSource = dataTable;
            connectDb.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            DisplayAppointment();   
            fillpatient();
            fillTreatment();
        }

        private void ADDbnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (APPID.Text == " " || APPPATNAME.Text == " " || APPTREAMENT.Text == " " || APPDATE.Text == " " || APPTIME.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }
                else
                {
                    connectDb.Open();
                    string query = "INSERT INTO Appointment VALUES('" + APPID.Text + "', '" + APPPATNAME.Text + "', '" + APPTREAMENT.Text + "', '" + APPDATE.Text + "', '" + APPTIME.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record added successfully");
                    DisplayAppointment();
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

        private void UPDATEbtN_Click(object sender, EventArgs e)
        {

            try
            {
                if (APPID.Text == " " || APPPATNAME.Text == " " || APPTREAMENT.Text == " " || APPDATE.Text == " " || APPTIME.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }


                else
                {
                    connectDb.Open();
                    string query = "UPDATE Appointment SET AppId =@AppId, PatientName =@PatientName, Treatment =@Treatment, AppDate =@AppDate, AppTime =@AppTime WHERE AppId =@AppId";

                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.Parameters.AddWithValue("@AppId", APPID.Text);
                    cmd.Parameters.AddWithValue("@PatientName", APPPATNAME.Text);
                    cmd.Parameters.AddWithValue("@Treatment", APPTREAMENT.Text);
                    cmd.Parameters.AddWithValue("@AppDate", APPDATE.Text);
                    cmd.Parameters.AddWithValue("@AppTime", APPTIME.Text);
                 

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
            DisplayAppointment();
        }

        private void DELETEbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (APPID.Text == " ")
                {
                    MessageBox.Show("Enter the Diagnostic ID");
                }
                else
                {
                    connectDb.Open();
                    string query = "DELETE FROM Appointment WHERE AppId='" + APPID.Text + "';";
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
            DisplayAppointment();
        }

        private void RESETbtn_Click(object sender, EventArgs e)
        {
            APPID.Text = " ";
           
           
        }

        private void HOMEbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AppointmentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                APPID.Text = AppointmentdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                APPPATNAME.Text = AppointmentdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                APPTREAMENT.Text = AppointmentdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                APPDATE.Text = AppointmentdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                APPTIME.Text = AppointmentdataGridView.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred", ex.Message);
            }
            finally { connectDb.Close(); }
        }
    }
    
}
