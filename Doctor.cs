using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            DisplayDoctor();
        }
        readonly SqlConnection connectDb = new SqlConnection("Data Source=COLOMBIA-RIEK\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");
        private void DisplayDoctor()
        {
            try
            {
                connectDb.Open();
                string query = "SELECT * FROM Doctor";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectDb);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                DoctordataGridView.DataSource = ds.Tables[0];
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
        private void Doctor_Load(object sender, EventArgs e)
        {
            DisplayDoctor();
        }

        private void Doctorbnt_Click(object sender, EventArgs e)
        {
            try
            {
                if (DOCID.Text == " " || DOCNAME.Text == " " || docGender.Text == " " || YOEXP.Text == " " || MLICSNO.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }
                else
                {
                    connectDb.Open();
                    string query = "INSERT INTO Doctor VALUES('" + DOCID.Text + "', '" + DOCNAME.Text + "', '" + docGender.Text + "', '" + YOEXP.Text + "', '" + MLICSNO.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record added successfully");
                    DisplayDoctor();
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

        private void HOMEbtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void RESETbtn_Click(object sender, EventArgs e)
        {
            DOCID.Text = " ";
            DOCNAME.Text = " ";
            docGender.Text = " ";
            YOEXP.Text = " ";
            MLICSNO.Text = "";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DELETEbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DOCID.Text== " ")
                {
                    MessageBox.Show("Enter the Doctor ID");
                }
                else
                {
                    connectDb.Open();
                    string query = "DELETE FROM Doctor WHERE DocId='" + DOCID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record Deleted Successfully");

                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error! can't Delete the record.", ex.Message);
            }
            finally
            {
                connectDb.Close();
            }
            DisplayDoctor();
        }

        private void UPDATEbtN_Click(object sender, EventArgs e)
        {
            try
            {
                if (DOCID.Text == " " || DOCNAME.Text == " " || docGender.Text == " " || YOEXP.Text == " " || MLICSNO.Text == " ")
                {
                    MessageBox.Show("Missing information, Please fill all the fields");
                }
                else
                {
                    connectDb.Open();
                    string query = "UPDATE Doctor SET DocName =@DocName, DocGen =@DocGen, Experience =@Experience, License =@License WHERE DocId =@DocId";
                   
                    SqlCommand cmd = new SqlCommand(query, connectDb);
                    cmd.Parameters.AddWithValue("@DocId", DOCID.Text);
                    cmd.Parameters.AddWithValue("@DocName", DOCNAME.Text);
                    cmd.Parameters.AddWithValue("@DocGen", docGender.Text);
                    cmd.Parameters.AddWithValue("@Experience", YOEXP.Text);
                    cmd.Parameters.AddWithValue("@License", MLICSNO.Text);
                    cmd.ExecuteNonQuery();
                    connectDb.Close();
                    MessageBox.Show("Record Updated Successfully!!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Cannot Update the Record", ex.Message);

            }
            finally { connectDb.Close(); }
            DisplayDoctor();
        }

        private void DoctordataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DOCID.Text = DoctordataGridView.SelectedRows[0].Cells[0].Value.ToString();
                DOCNAME.Text = DoctordataGridView.SelectedRows[0].Cells[1].Value.ToString();
                docGender.Text = DoctordataGridView.SelectedRows[0].Cells[2].Value.ToString();
                YOEXP.Text = DoctordataGridView.SelectedRows[0].Cells[3].Value.ToString();
                MLICSNO.Text = DoctordataGridView.SelectedRows[0].Cells[4].Value.ToString();

            }catch(Exception ex)
            {
                MessageBox.Show("An error ocurred", ex.Message);
            }finally { connectDb.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Doctor_Load_1(object sender, EventArgs e)
        {

        }
    }
}
