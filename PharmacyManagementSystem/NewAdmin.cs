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
    public partial class NewAdmin : Form
    {
        public NewAdmin()
        {
            InitializeComponent();
        }

        private void exitNewAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewPharmacistBack_Click(object sender, EventArgs e)
        {
            Admin bfca = new Admin();
            bfca.Show();
            this.Hide();
        }

        private void btnNewPharmacistReset_Click(object sender, EventArgs e)
        {
            newNameTextBox.Clear();
            postTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
        }

        private void btnNewPharmacistCreate_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "insert into AdminInfo(Name, Post, Phone, Email, password) " +
                "values (@name, @post, @phone, @email, @password)";
            cmd.CommandText = query;
            //cmd.Parameters.AddWithValue("@id",);
            cmd.Parameters.AddWithValue("@name", newNameTextBox.Text);
            cmd.Parameters.AddWithValue("@post", postTextBox.Text);
            cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text) ;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New admin is inserted");
            }
            catch
            {
                MessageBox.Show("something is wrong");
            }
        }
    }
}
