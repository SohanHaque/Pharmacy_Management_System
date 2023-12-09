using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string s)
        {
            InitializeComponent();
            adminLabelText.Text = s;
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

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void exitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 admToLog = new Form1();
            admToLog.Show();
            this.Hide();
        }

        private void btnAddPharmacist_Click(object sender, EventArgs e)
        {
            NewPharmacist anf = new NewPharmacist();
            anf.Show();
            this.Hide();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            NewAdmin cna = new NewAdmin();
            cna.Show();
            this.Hide();
        }

        private void btnResolveIssues_Click(object sender, EventArgs e)
        {
            string query = "select * from Issues";
            showTable(query);
        }

        private void btnAdminList_Click(object sender, EventArgs e)
        {
            string query = "select Name, Post, Phone, Email from AdminInfo";
            showTable(query);
        }

        private void btnPharmacyList_Click(object sender, EventArgs e)
        {
            string query = "select OwnerName, NID, ShopName, Contact, Location, Email from PharmacistInfo";
            showTable(query);
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            string query = "select Name, DOB, Mobile, Email, UserName from UserInfo";
            showTable(query);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            try
            {
                con.Open();
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM AdminInfo where EId=@EId", con);
                cmd.Parameters.AddWithValue("@EId", int.Parse(searchTextBox.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
