
namespace PharmacyManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aiubLogo = new System.Windows.Forms.PictureBox();
            this.poweredByText = new System.Windows.Forms.Label();
            this.medLogo = new System.Windows.Forms.PictureBox();
            this.pmsText = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.exitLogin = new System.Windows.Forms.PictureBox();
            this.btnOpenNewAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aiubLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.aiubLogo);
            this.panel1.Controls.Add(this.poweredByText);
            this.panel1.Controls.Add(this.medLogo);
            this.panel1.Controls.Add(this.pmsText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // aiubLogo
            // 
            this.aiubLogo.Image = ((System.Drawing.Image)(resources.GetObject("aiubLogo.Image")));
            this.aiubLogo.Location = new System.Drawing.Point(139, 543);
            this.aiubLogo.Name = "aiubLogo";
            this.aiubLogo.Size = new System.Drawing.Size(137, 124);
            this.aiubLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aiubLogo.TabIndex = 3;
            this.aiubLogo.TabStop = false;
            // 
            // poweredByText
            // 
            this.poweredByText.AutoSize = true;
            this.poweredByText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poweredByText.Location = new System.Drawing.Point(147, 487);
            this.poweredByText.Name = "poweredByText";
            this.poweredByText.Size = new System.Drawing.Size(129, 24);
            this.poweredByText.TabIndex = 2;
            this.poweredByText.Text = "Powered By";
            // 
            // medLogo
            // 
            this.medLogo.Image = ((System.Drawing.Image)(resources.GetObject("medLogo.Image")));
            this.medLogo.Location = new System.Drawing.Point(93, 217);
            this.medLogo.Name = "medLogo";
            this.medLogo.Size = new System.Drawing.Size(232, 225);
            this.medLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medLogo.TabIndex = 1;
            this.medLogo.TabStop = false;
            // 
            // pmsText
            // 
            this.pmsText.AutoSize = true;
            this.pmsText.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmsText.Location = new System.Drawing.Point(98, 91);
            this.pmsText.Name = "pmsText";
            this.pmsText.Size = new System.Drawing.Size(227, 123);
            this.pmsText.TabIndex = 0;
            this.pmsText.Text = "Pharmacy\r\nManagement\r\nSystem";
            this.pmsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginLogo
            // 
            this.loginLogo.Image = ((System.Drawing.Image)(resources.GetObject("loginLogo.Image")));
            this.loginLogo.Location = new System.Drawing.Point(833, 91);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(165, 146);
            this.loginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginLogo.TabIndex = 1;
            this.loginLogo.TabStop = false;
            this.loginLogo.Click += new System.EventHandler(this.loginLogo_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.AutoSize = true;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(796, 389);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(114, 25);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.Text = "Password";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(801, 323);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(235, 29);
            this.userNameTextBox.TabIndex = 4;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(801, 424);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(235, 29);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Red;
            this.btnLogin.Location = new System.Drawing.Point(773, 501);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 51);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(945, 501);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 51);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // exitLogin
            // 
            this.exitLogin.Image = ((System.Drawing.Image)(resources.GetObject("exitLogin.Image")));
            this.exitLogin.Location = new System.Drawing.Point(1349, 12);
            this.exitLogin.Name = "exitLogin";
            this.exitLogin.Size = new System.Drawing.Size(19, 18);
            this.exitLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitLogin.TabIndex = 8;
            this.exitLogin.TabStop = false;
            this.exitLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOpenNewAccount
            // 
            this.btnOpenNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpenNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNewAccount.ForeColor = System.Drawing.Color.Red;
            this.btnOpenNewAccount.Location = new System.Drawing.Point(801, 580);
            this.btnOpenNewAccount.Name = "btnOpenNewAccount";
            this.btnOpenNewAccount.Size = new System.Drawing.Size(235, 51);
            this.btnOpenNewAccount.TabIndex = 9;
            this.btnOpenNewAccount.Text = "Open New Account";
            this.btnOpenNewAccount.UseVisualStyleBackColor = false;
            this.btnOpenNewAccount.Click += new System.EventHandler(this.btnOpenNewAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(796, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name/ Shop Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenNewAccount);
            this.Controls.Add(this.exitLogin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aiubLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox aiubLogo;
        private System.Windows.Forms.Label poweredByText;
        private System.Windows.Forms.PictureBox medLogo;
        private System.Windows.Forms.Label pmsText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.Label passwordTxt;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox exitLogin;
        private System.Windows.Forms.Button btnOpenNewAccount;
        private System.Windows.Forms.Label label1;
    }
}

