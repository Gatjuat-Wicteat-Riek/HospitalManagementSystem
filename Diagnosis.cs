using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
            DisplayDiagnosis();
        }
        readonly SqlConnection connectDb = new SqlConnection("Data Source=COLOMBIA-RIEK\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");
        private void DisplayDiagnosis()
        {
            try
            {
                connectDb.Open();
                string query = "SELECT * FROM Diagnosis";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectDb);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                DiagnosisdataGridView.DataSource = ds.Tables[0];
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
        private void Diagnosis_Load(object sender, EventArgs e)
        {
            //DisplayDiagnosis();
            DisplayPatientId();
        }

        private void ADDbnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (DIAID.Text == " " || DIAPATID.Text == " " || DIAPATNAME.Text == " " || DIASYM.Text == " " || DIATEST.Text == " " || DIAMED.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }
                else
                {
                    connectDb.Open();
                    string query = "INSERT INTO Diagnosis VALUES('" + DIAID.Text + "', '" + DIAPATID.Text + "', '" + DIAPATNAME.Text + "', '" + DIASYM.Text + "', '" + DIATEST.Text + "', '" + DIAMED.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record added successfully");
                    DisplayDiagnosis();

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

        void DisplayPatientId()
        {
            string query = "SELECT * FROM Patient";
            SqlCommand sqlCommand = new SqlCommand(query, connectDb);
            SqlDataReader reader;
            try
            {
                connectDb.Open();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("PatId", typeof(int));
                reader = sqlCommand.ExecuteReader();
                dataTable.Load(reader);
                DIAPATID.ValueMember = "PatId";
                DIAPATID.DataSource = dataTable;
                connectDb.Close();

            } catch(Exception ex)
            {
                MessageBox.Show("Error: Cannot Read From Patient", ex.Message);

            }
            finally
            {
                connectDb.Close();
            }
        }
        string pname;
        void DisplayPatientName()
        {
            try
            {
                connectDb.Open();
                string ss = "SELECT * FROM Patient WHERE PatId =" + DIAPATID.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand(ss, connectDb);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                foreach(DataRow dr in data.Rows)
                {
                    pname = dr["PName"].ToString();
                   

                }
                connectDb.Close();

            } catch( Exception ex )
            {
                MessageBox.Show("Error: Cannot display patientName", ex.Message);
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
                if (DIAID.Text == " " || DIAPATNAME.Text == " " || DIASYM.Text == " " || DIATEST.Text == " " || DIAPATID.Text == " " || DIAMED.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }


                else
                {
                    connectDb.Open();
                    string query = "UPDATE Diagnosis SET DiaId =@DiaId, PatientId =@PatientId, PatientName =@PatientName, Symptoms =@Symptoms, DiagnosticTest =@DiagnosticTest, Medicines =@Medicines WHERE DiaId =@DiaId";

                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.Parameters.AddWithValue("@DiaId", DIAID.Text);
                    cmd.Parameters.AddWithValue("@PatientName", DIAPATNAME.Text);
                    cmd.Parameters.AddWithValue("@PatientId", DIAPATID.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", DIASYM.Text);
                    cmd.Parameters.AddWithValue("@DiagnosticTest", DIATEST.Text);
                    cmd.Parameters.AddWithValue("@Medicines", DIAMED.Text);
                   
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
            DisplayDiagnosis();
        }

        private void DELETEbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DIAID.Text == " ")
                {
                    MessageBox.Show("Enter the Diagnostic ID");
                }
                else
                {
                    connectDb.Open();
                    string query = "DELETE FROM Diagnosis WHERE DiaId='" + DIAID.Text + "';";
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
            DisplayDiagnosis();
        }

        private void RESETbtn_Click(object sender, EventArgs e)
        {
            DIAID.Text = " ";
            DIAPATID.Text = " ";
            DIAPATNAME.Text = " ";
            DIASYM.Text = " ";
            DIATEST.Text = " ";
            DIAMED.Text = " ";

        }

        private void HOMEbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void DiagnosisdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DIAID.Text = DiagnosisdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DIAPATID.Text = DiagnosisdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                DIAPATNAME.Text = DiagnosisdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                DIASYM.Text = DiagnosisdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                DIATEST.Text = DiagnosisdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                DIAMED.Text = DiagnosisdataGridView.SelectedRows[0].Cells[5].Value.ToString();
                //Label to be displayed as a summary
                SMPATNAM.Text = DIAPATNAME.Text;
                SMDIATEST.Text = DIATEST.Text;
                SMSYM.Text = DIASYM.Text;
                SMMED.Text = DIAMED.Text;
                DisplayDiagnosis();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurred", ex.Message);
            }
            finally { connectDb.Close(); }
        }

        private void DIAPATNAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPatientName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
    
}
