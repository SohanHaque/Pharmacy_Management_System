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
    public partial class Form1 : Form
    {
        Functions fn = new Functions();
        String query;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-KU8ITD4\\SQLEXPRESS01;Initial Catalog=PBSdb;User ID=sa;Password=asdf1234";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            query = "select password from UserInfo where UserName=\'" + userNameTextBox.Text + "\'";
            cmd.CommandText = query;
            string password = (string)cmd.ExecuteScalar();
            if (password != null)
            {
                if (password == passwordTextBox.Text)
                {
                    User a = new User();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "select password from PharmacistInfo where ShopName=\'" + userNameTextBox.Text + "\'";
                cmd.CommandText = query;
                password = (string)cmd.ExecuteScalar();
                if(password!=null)
                {
                    if (password == passwordTextBox.Text)
                    {
                        Pharmacist a = new Pharmacist();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    query = "select password from AdminInfo where name=\'" + userNameTextBox.Text + "\'";
                    cmd.CommandText = query;
                    password = (string)cmd.ExecuteScalar();
                    if (password != null)
                    {
                        if (password == passwordTextBox.Text)
                        {
                            Admin a = new Admin(userNameTextBox.Text);
                            a.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong user name / Shop name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenNewAccount_Click(object sender, EventArgs e)
        {
            NewUser a = new NewUser();
            a.Show();
            this.Hide();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passwordTextBox.Focus();
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
