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
    public partial class Issues : Form
    {
        public Issues()
        {
            InitializeComponent();
        }

        private void exitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "insert into Issues(Catagory, Complain) values (@catagory, @complain)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@catagory", comboBoxReportType.Text);
            cmd.Parameters.AddWithValue("@complain", descriptionReport.Text);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your report Has Been Submitted. ", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("something is wrong");
            }

            Form1 bfreport = new Form1();
            bfreport.Show();
            this.Hide();
        }

        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your report queue has been canceled. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Form1 bfreport = new Form1();
            bfreport.Show();
            this.Hide();
        }
    }
}
