
namespace PharmacyManagementSystem
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.exitAdmin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminLabelText = new System.Windows.Forms.Label();
            this.btnResolveIssues = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnAddPharmacist = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.adminText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchTagText = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.btnUserList = new System.Windows.Forms.Button();
            this.btnPharmacyList = new System.Windows.Forms.Button();
            this.btnAdminList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.exitAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitAdmin
            // 
            this.exitAdmin.Image = ((System.Drawing.Image)(resources.GetObject("exitAdmin.Image")));
            this.exitAdmin.Location = new System.Drawing.Point(1030, 12);
            this.exitAdmin.Name = "exitAdmin";
            this.exitAdmin.Size = new System.Drawing.Size(19, 18);
            this.exitAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitAdmin.TabIndex = 9;
            this.exitAdmin.TabStop = false;
            this.exitAdmin.Click += new System.EventHandler(this.exitAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.adminLabelText);
            this.panel1.Controls.Add(this.btnResolveIssues);
            this.panel1.Controls.Add(this.btnAddAdmin);
            this.panel1.Controls.Add(this.btnAddPharmacist);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.adminText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 768);
            this.panel1.TabIndex = 10;
            // 
            // adminLabelText
            // 
            this.adminLabelText.AutoSize = true;
            this.adminLabelText.BackColor = System.Drawing.Color.White;
            this.adminLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adminLabelText.Location = new System.Drawing.Point(50, 28);
            this.adminLabelText.Name = "adminLabelText";
            this.adminLabelText.Size = new System.Drawing.Size(104, 16);
            this.adminLabelText.TabIndex = 8;
            this.adminLabelText.Text = "Default Admin";
            // 
            // btnResolveIssues
            // 
            this.btnResolveIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResolveIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolveIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolveIssues.ForeColor = System.Drawing.Color.Black;
            this.btnResolveIssues.Location = new System.Drawing.Point(41, 455);
            this.btnResolveIssues.Name = "btnResolveIssues";
            this.btnResolveIssues.Size = new System.Drawing.Size(208, 47);
            this.btnResolveIssues.TabIndex = 7;
            this.btnResolveIssues.Text = "Resolve Issues";
            this.btnResolveIssues.UseVisualStyleBackColor = false;
            this.btnResolveIssues.Click += new System.EventHandler(this.btnResolveIssues_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAddAdmin.Location = new System.Drawing.Point(41, 382);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(208, 47);
            this.btnAddAdmin.TabIndex = 6;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnAddPharmacist
            // 
            this.btnAddPharmacist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddPharmacist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPharmacist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPharmacist.ForeColor = System.Drawing.Color.Black;
            this.btnAddPharmacist.Location = new System.Drawing.Point(41, 307);
            this.btnAddPharmacist.Name = "btnAddPharmacist";
            this.btnAddPharmacist.Size = new System.Drawing.Size(208, 47);
            this.btnAddPharmacist.TabIndex = 5;
            this.btnAddPharmacist.Text = "Add Pharmacy";
            this.btnAddPharmacist.UseVisualStyleBackColor = false;
            this.btnAddPharmacist.Click += new System.EventHandler(this.btnAddPharmacist_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(41, 617);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(208, 47);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // adminText
            // 
            this.adminText.AutoSize = true;
            this.adminText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminText.Location = new System.Drawing.Point(80, 224);
            this.adminText.Name = "adminText";
            this.adminText.Size = new System.Drawing.Size(132, 24);
            this.adminText.TabIndex = 1;
            this.adminText.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.searchTagText);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.btnUserList);
            this.panel2.Controls.Add(this.btnPharmacyList);
            this.panel2.Controls.Add(this.btnAdminList);
            this.panel2.Controls.Add(this.exitAdmin);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(319, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 230);
            this.panel2.TabIndex = 11;
            // 
            // searchTagText
            // 
            this.searchTagText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTagText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTagText.ForeColor = System.Drawing.Color.White;
            this.searchTagText.Location = new System.Drawing.Point(340, 143);
            this.searchTagText.Name = "searchTagText";
            this.searchTagText.Size = new System.Drawing.Size(225, 18);
            this.searchTagText.TabIndex = 9;
            this.searchTagText.Text = "default";
            this.searchTagText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(581, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 31);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(340, 164);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '*';
            this.searchTextBox.Size = new System.Drawing.Size(225, 29);
            this.searchTextBox.TabIndex = 13;
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.ForeColor = System.Drawing.Color.Black;
            this.btnUserList.Location = new System.Drawing.Point(906, 164);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(134, 31);
            this.btnUserList.TabIndex = 11;
            this.btnUserList.Text = "User List";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnPharmacyList
            // 
            this.btnPharmacyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPharmacyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPharmacyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacyList.ForeColor = System.Drawing.Color.Black;
            this.btnPharmacyList.Location = new System.Drawing.Point(906, 116);
            this.btnPharmacyList.Name = "btnPharmacyList";
            this.btnPharmacyList.Size = new System.Drawing.Size(134, 31);
            this.btnPharmacyList.TabIndex = 10;
            this.btnPharmacyList.Text = "Pharmacy List";
            this.btnPharmacyList.UseVisualStyleBackColor = false;
            this.btnPharmacyList.Click += new System.EventHandler(this.btnPharmacyList_Click);
            // 
            // btnAdminList
            // 
            this.btnAdminList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdminList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminList.ForeColor = System.Drawing.Color.Black;
            this.btnAdminList.Location = new System.Drawing.Point(906, 67);
            this.btnAdminList.Name = "btnAdminList";
            this.btnAdminList.Size = new System.Drawing.Size(134, 31);
            this.btnAdminList.TabIndex = 9;
            this.btnAdminList.Text = "Admin List";
            this.btnAdminList.UseVisualStyleBackColor = false;
            this.btnAdminList.Click += new System.EventHandler(this.btnAdminList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(319, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label adminText;
        private System.Windows.Forms.Button btnResolveIssues;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnAddPharmacist;
        private System.Windows.Forms.Label adminLabelText;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.Button btnPharmacyList;
        private System.Windows.Forms.Button btnAdminList;
        private System.Windows.Forms.Label searchTagText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}