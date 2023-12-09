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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void exitNewUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnNewUserReset_Click(object sender, EventArgs e)
        {
            newUserNameTextBox.Clear();
            dobTextBox.Clear();
            newUserMobileNumberTextBox.Clear();
            newUserEmailAddressTextBox.Clear();
            newUserUserNameTextBox.Clear();
            newUserPasswordTextBox.Clear();
            newUserConfirmPasswordTextBox.Clear();
        }

        private void btnNewUserBack_Click(object sender, EventArgs e)
        {
            Form1 goBack = new Form1();
            goBack.Show();
            this.Hide();
        }

        private void btnNewUserSignIn_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "insert into UserInfo(Name, DOB," +
                " Mobile, Email, UserName, password) " +
                "values (@name, @dob, @mobile, @email, @username, @password)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name", newUserNameTextBox.Text);
            cmd.Parameters.AddWithValue("@dob", dobTextBox.Text);
            cmd.Parameters.AddWithValue("@mobile", newUserMobileNumberTextBox.Text);
            cmd.Parameters.AddWithValue("@email", newUserEmailAddressTextBox.Text);
            cmd.Parameters.AddWithValue("@username", newUserUserNameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", newUserPasswordTextBox);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your account has been created");
            }
            catch
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
