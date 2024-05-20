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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        readonly SqlConnection connectDb = new SqlConnection("Data Source=COLOMBIA-RIEK\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True;TrustServerCertificate=True");

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PendingAppProgress.Value = 100;
            PatientGunna.Value = 100;
            DoctorGunna.Value = 100;
            NextAppGuna.Value = 100;
            string query1 = "SELECT COUNT(*) FROM Appointment";

            connectDb.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query1, connectDb);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            PendingNum.Text = dataTable.Rows[0][0].ToString();

            string query2 = "SELECT COUNT(*) FROM Patient";
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, connectDb);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            PatientNum.Text = dataTable2.Rows[0][0].ToString();


            string query3 = "SELECT COUNT(*) FROM Doctor";
            SqlDataAdapter adp = new SqlDataAdapter(query3, connectDb);
            DataTable dataTable3 = new DataTable();
            adp.Fill(dataTable3);
            DoctorNum.Text = dataTable3.Rows[0][0].ToString();

            string query4 = "SELECT MAX(AppDate) FROM Appointment";
            SqlDataAdapter adapter4 = new SqlDataAdapter(query4, connectDb);
            DataTable dataTable4= new DataTable();
            adapter4.Fill(dataTable4);
            NextNum.Text = dataTable4.Rows[0][0].ToString();
            
            connectDb.Close();


        }

        private void HOMEbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
