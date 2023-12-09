using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void exitUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOutUser_Click(object sender, EventArgs e)
        {
            Form1 efUser = new Form1();
            efUser.Show();
            this.Hide();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            Issues uissue = new Issues();
            uissue.Show();
            this.Hide();
        }
    }
}
