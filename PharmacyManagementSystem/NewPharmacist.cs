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
    public partial class NewPharmacist : Form
    {
        public NewPharmacist()
        {
            InitializeComponent();
        }

        private void exitNewPharmacist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewPharmacistBack_Click(object sender, EventArgs e)
        {
            Admin bfcp = new Admin();
            bfcp.Show();
            this.Hide();
        }

        private void btnNewPharmacistReset_Click(object sender, EventArgs e)
        {
            newOwnerNameTextBox.Clear();
            nidTextBox.Clear();
            shopNameTextBox.Clear();
            locationTextBox.Clear();
            mobileTextBox.Clear();
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
            string query = "insert into PharmacistInfo(OwnerName, NID," +
                " ShopName, Contact, Location, Email, password) " +
                "values (@ownername, @nid, @shopname, @contact, @location, @email, @password)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@ownername", newOwnerNameTextBox.Text);
            cmd.Parameters.AddWithValue("@nid", nidTextBox.Text);
            cmd.Parameters.AddWithValue("@shopname", shopNameTextBox.Text);
            cmd.Parameters.AddWithValue("@contact", mobileTextBox.Text);
            cmd.Parameters.AddWithValue("@location", locationTextBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
            //con.Close();
            //SqlConnection conc = new SqlConnection(conString);
            //conc.Open();
            //SqlCommand ncmd = new SqlCommand();
            //ncmd.Connection = con;
            //string nextQuery = "create table "+emailTextBox.Text+"med ( Name varchar(250), quantity int )" ;
            //ncmd.CommandText = nextQuery;
            //conc.Close();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New pharmacy is inserted");
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
