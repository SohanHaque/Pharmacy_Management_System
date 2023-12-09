
namespace PharmacyManagementSystem
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.exitUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.btnConfirmPurchase = new System.Windows.Forms.Button();
            this.btnLogOutUser = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.Label();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // exitUser
            // 
            this.exitUser.Image = ((System.Drawing.Image)(resources.GetObject("exitUser.Image")));
            this.exitUser.Location = new System.Drawing.Point(1349, 12);
            this.exitUser.Name = "exitUser";
            this.exitUser.Size = new System.Drawing.Size(19, 18);
            this.exitUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitUser.TabIndex = 9;
            this.exitUser.TabStop = false;
            this.exitUser.Click += new System.EventHandler(this.exitUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReportIssues);
            this.panel1.Controls.Add(this.btnEmptyCart);
            this.panel1.Controls.Add(this.btnConfirmPurchase);
            this.panel1.Controls.Add(this.btnLogOutUser);
            this.panel1.Controls.Add(this.userText);
            this.panel1.Controls.Add(this.picBoxUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 768);
            this.panel1.TabIndex = 11;
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReportIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.Black;
            this.btnReportIssues.Location = new System.Drawing.Point(41, 455);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(208, 47);
            this.btnReportIssues.TabIndex = 7;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmptyCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmptyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyCart.ForeColor = System.Drawing.Color.Black;
            this.btnEmptyCart.Location = new System.Drawing.Point(41, 382);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(208, 47);
            this.btnEmptyCart.TabIndex = 6;
            this.btnEmptyCart.Text = "Empty Cart";
            this.btnEmptyCart.UseVisualStyleBackColor = false;
            // 
            // btnConfirmPurchase
            // 
            this.btnConfirmPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPurchase.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmPurchase.Location = new System.Drawing.Point(41, 307);
            this.btnConfirmPurchase.Name = "btnConfirmPurchase";
            this.btnConfirmPurchase.Size = new System.Drawing.Size(208, 47);
            this.btnConfirmPurchase.TabIndex = 5;
            this.btnConfirmPurchase.Text = "Confirm Purchase";
            this.btnConfirmPurchase.UseVisualStyleBackColor = false;
            // 
            // btnLogOutUser
            // 
            this.btnLogOutUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogOutUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOutUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutUser.ForeColor = System.Drawing.Color.Black;
            this.btnLogOutUser.Location = new System.Drawing.Point(41, 617);
            this.btnLogOutUser.Name = "btnLogOutUser";
            this.btnLogOutUser.Size = new System.Drawing.Size(208, 47);
            this.btnLogOutUser.TabIndex = 4;
            this.btnLogOutUser.Text = "Log Out";
            this.btnLogOutUser.UseVisualStyleBackColor = false;
            this.btnLogOutUser.Click += new System.EventHandler(this.btnLogOutUser_Click);
            // 
            // userText
            // 
            this.userText.AutoSize = true;
            this.userText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.Location = new System.Drawing.Point(125, 222);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(53, 24);
            this.userText.TabIndex = 1;
            this.userText.Text = "User";
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUser.Image")));
            this.picBoxUser.Location = new System.Drawing.Point(53, 47);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(196, 160);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 0;
            this.picBoxUser.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.exitUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEmptyCart;
        private System.Windows.Forms.Button btnConfirmPurchase;
        private System.Windows.Forms.Button btnLogOutUser;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.PictureBox picBoxUser;
    }
}