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

namespace PharmacyManagementSystem
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void exitPharmacist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void showTable(string s)
        {
            string conString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            string query = s;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conString;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 BFPharma = new Form1();
            BFPharma.Show();
            this.Hide();
        }

        private void btnAddToStore_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "insert into MedicineInfo(Name, Quantity) values (@name, @quantity)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name", medNameTextBox.Text);
            cmd.Parameters.AddWithValue("@quantity", medQuantityTextBox.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Medicine Added");
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            string query = "select * from DefaultEmployeeList";
            showTable(query);
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            Issues pissue = new Issues();
            pissue.Show();
            this.Hide();
        }

        private void btnRemoveFromStore_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "DELETE FROM MedicineInfo where Name="+ medNameTextBox.Text;
            cmd.CommandText = query;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Removed");
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void btnMedicins_Click(object sender, EventArgs e)
        {
            string query = "select * from MedicineInfo";
            showTable(query);
        }
    }
}
