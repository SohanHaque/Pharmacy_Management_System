
namespace PharmacyManagementSystem
{
    partial class Issues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issues));
            this.exitLogin = new System.Windows.Forms.PictureBox();
            this.reportText = new System.Windows.Forms.Label();
            this.issueTypeText = new System.Windows.Forms.Label();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.writeDiscriptionText = new System.Windows.Forms.Label();
            this.descriptionReport = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.noteFullText = new System.Windows.Forms.Label();
            this.noteLabelText = new System.Windows.Forms.Label();
            this.btnCancelReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // exitLogin
            // 
            this.exitLogin.Image = ((System.Drawing.Image)(resources.GetObject("exitLogin.Image")));
            this.exitLogin.Location = new System.Drawing.Point(1349, 12);
            this.exitLogin.Name = "exitLogin";
            this.exitLogin.Size = new System.Drawing.Size(19, 18);
            this.exitLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitLogin.TabIndex = 9;
            this.exitLogin.TabStop = false;
            this.exitLogin.Click += new System.EventHandler(this.exitLogin_Click);
            // 
            // reportText
            // 
            this.reportText.AutoSize = true;
            this.reportText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportText.ForeColor = System.Drawing.Color.Red;
            this.reportText.Location = new System.Drawing.Point(658, 30);
            this.reportText.Name = "reportText";
            this.reportText.Size = new System.Drawing.Size(175, 55);
            this.reportText.TabIndex = 10;
            this.reportText.Text = "Report";
            // 
            // issueTypeText
            // 
            this.issueTypeText.AutoSize = true;
            this.issueTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueTypeText.Location = new System.Drawing.Point(122, 143);
            this.issueTypeText.Name = "issueTypeText";
            this.issueTypeText.Size = new System.Drawing.Size(163, 20);
            this.issueTypeText.TabIndex = 11;
            this.issueTypeText.Text = "Select Report Type";
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "Technical Issues",
            "Overpricing",
            "Misdelivery",
            "Expired Medicine",
            "Others"});
            this.comboBoxReportType.Location = new System.Drawing.Point(126, 177);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(159, 21);
            this.comboBoxReportType.TabIndex = 12;
            // 
            // writeDiscriptionText
            // 
            this.writeDiscriptionText.AutoSize = true;
            this.writeDiscriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeDiscriptionText.Location = new System.Drawing.Point(122, 249);
            this.writeDiscriptionText.Name = "writeDiscriptionText";
            this.writeDiscriptionText.Size = new System.Drawing.Size(147, 20);
            this.writeDiscriptionText.TabIndex = 13;
            this.writeDiscriptionText.Text = "Write Description";
            // 
            // descriptionReport
            // 
            this.descriptionReport.Location = new System.Drawing.Point(126, 284);
            this.descriptionReport.Name = "descriptionReport";
            this.descriptionReport.Size = new System.Drawing.Size(1211, 334);
            this.descriptionReport.TabIndex = 14;
            this.descriptionReport.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(414, 652);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(263, 45);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // noteFullText
            // 
            this.noteFullText.AutoSize = true;
            this.noteFullText.Location = new System.Drawing.Point(1153, 233);
            this.noteFullText.Name = "noteFullText";
            this.noteFullText.Size = new System.Drawing.Size(158, 26);
            this.noteFullText.TabIndex = 19;
            this.noteFullText.Text = "You will automaticly log out after\r\nyou submit or cancel a report.";
            this.noteFullText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // noteLabelText
            // 
            this.noteLabelText.AutoSize = true;
            this.noteLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabelText.ForeColor = System.Drawing.Color.Red;
            this.noteLabelText.Location = new System.Drawing.Point(1204, 202);
            this.noteLabelText.Name = "noteLabelText";
            this.noteLabelText.Size = new System.Drawing.Size(52, 20);
            this.noteLabelText.TabIndex = 20;
            this.noteLabelText.Text = "Note:";
            // 
            // btnCancelReport
            // 
            this.btnCancelReport.BackColor = System.Drawing.Color.Lime;
            this.btnCancelReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReport.Location = new System.Drawing.Point(835, 652);
            this.btnCancelReport.Name = "btnCancelReport";
            this.btnCancelReport.Size = new System.Drawing.Size(263, 45);
            this.btnCancelReport.TabIndex = 21;
            this.btnCancelReport.Text = "Cancel";
            this.btnCancelReport.UseVisualStyleBackColor = false;
            this.btnCancelReport.Click += new System.EventHandler(this.btnCancelReport_Click);
            // 
            // Issues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.btnCancelReport);
            this.Controls.Add(this.noteLabelText);
            this.Controls.Add(this.noteFullText);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.descriptionReport);
            this.Controls.Add(this.writeDiscriptionText);
            this.Controls.Add(this.comboBoxReportType);
            this.Controls.Add(this.issueTypeText);
            this.Controls.Add(this.reportText);
            this.Controls.Add(this.exitLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Issues";
            this.Text = "Issues";
            ((System.ComponentModel.ISupportInitialize)(this.exitLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitLogin;
        private System.Windows.Forms.Label reportText;
        private System.Windows.Forms.Label issueTypeText;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Label writeDiscriptionText;
        private System.Windows.Forms.RichTextBox descriptionReport;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label noteFullText;
        private System.Windows.Forms.Label noteLabelText;
        private System.Windows.Forms.Button btnCancelReport;
    }
}