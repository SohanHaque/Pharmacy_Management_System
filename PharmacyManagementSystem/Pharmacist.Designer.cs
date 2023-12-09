
namespace PharmacyManagementSystem
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.exitPharmacist = new System.Windows.Forms.PictureBox();
            this.picBoxPharmacist = new System.Windows.Forms.PictureBox();
            this.panelPharmacist = new System.Windows.Forms.Panel();
            this.btnRemoveFromStore = new System.Windows.Forms.Button();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEmployeeList = new System.Windows.Forms.Button();
            this.btnAddToStore = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pharmacistText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMedicins = new System.Windows.Forms.Button();
            this.medNameTextBox = new System.Windows.Forms.TextBox();
            this.medQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitPharmacist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPharmacist)).BeginInit();
            this.panelPharmacist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitPharmacist
            // 
            this.exitPharmacist.Image = ((System.Drawing.Image)(resources.GetObject("exitPharmacist.Image")));
            this.exitPharmacist.Location = new System.Drawing.Point(1042, 12);
            this.exitPharmacist.Name = "exitPharmacist";
            this.exitPharmacist.Size = new System.Drawing.Size(19, 18);
            this.exitPharmacist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPharmacist.TabIndex = 9;
            this.exitPharmacist.TabStop = false;
            this.exitPharmacist.Click += new System.EventHandler(this.exitPharmacist_Click);
            // 
            // picBoxPharmacist
            // 
            this.picBoxPharmacist.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPharmacist.Image")));
            this.picBoxPharmacist.Location = new System.Drawing.Point(53, 47);
            this.picBoxPharmacist.Name = "picBoxPharmacist";
            this.picBoxPharmacist.Size = new System.Drawing.Size(196, 160);
            this.picBoxPharmacist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPharmacist.TabIndex = 0;
            this.picBoxPharmacist.TabStop = false;
            // 
            // panelPharmacist
            // 
            this.panelPharmacist.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelPharmacist.Controls.Add(this.btnRemoveFromStore);
            this.panelPharmacist.Controls.Add(this.btnReportIssues);
            this.panelPharmacist.Controls.Add(this.btnEmployeeList);
            this.panelPharmacist.Controls.Add(this.btnAddToStore);
            this.panelPharmacist.Controls.Add(this.btnLogOut);
            this.panelPharmacist.Controls.Add(this.pharmacistText);
            this.panelPharmacist.Controls.Add(this.picBoxPharmacist);
            this.panelPharmacist.Location = new System.Drawing.Point(0, 0);
            this.panelPharmacist.Name = "panelPharmacist";
            this.panelPharmacist.Size = new System.Drawing.Size(309, 771);
            this.panelPharmacist.TabIndex = 11;
            // 
            // btnRemoveFromStore
            // 
            this.btnRemoveFromStore.BackColor = System.Drawing.Color.Yellow;
            this.btnRemoveFromStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFromStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromStore.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveFromStore.Location = new System.Drawing.Point(41, 355);
            this.btnRemoveFromStore.Name = "btnRemoveFromStore";
            this.btnRemoveFromStore.Size = new System.Drawing.Size(208, 47);
            this.btnRemoveFromStore.TabIndex = 9;
            this.btnRemoveFromStore.Text = "Remove From Store";
            this.btnRemoveFromStore.UseVisualStyleBackColor = false;
            this.btnRemoveFromStore.Click += new System.EventHandler(this.btnRemoveFromStore_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.Yellow;
            this.btnReportIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.Black;
            this.btnReportIssues.Location = new System.Drawing.Point(41, 493);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(208, 47);
            this.btnReportIssues.TabIndex = 8;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEmployeeList
            // 
            this.btnEmployeeList.BackColor = System.Drawing.Color.Yellow;
            this.btnEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeList.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeList.Location = new System.Drawing.Point(41, 424);
            this.btnEmployeeList.Name = "btnEmployeeList";
            this.btnEmployeeList.Size = new System.Drawing.Size(208, 47);
            this.btnEmployeeList.TabIndex = 7;
            this.btnEmployeeList.Text = "Employee List";
            this.btnEmployeeList.UseVisualStyleBackColor = false;
            this.btnEmployeeList.Click += new System.EventHandler(this.btnEmployeeList_Click);
            // 
            // btnAddToStore
            // 
            this.btnAddToStore.BackColor = System.Drawing.Color.Yellow;
            this.btnAddToStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToStore.ForeColor = System.Drawing.Color.Black;
            this.btnAddToStore.Location = new System.Drawing.Point(41, 286);
            this.btnAddToStore.Name = "btnAddToStore";
            this.btnAddToStore.Size = new System.Drawing.Size(208, 47);
            this.btnAddToStore.TabIndex = 5;
            this.btnAddToStore.Text = "Add To Store";
            this.btnAddToStore.UseVisualStyleBackColor = false;
            this.btnAddToStore.Click += new System.EventHandler(this.btnAddToStore_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Yellow;
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
            // pharmacistText
            // 
            this.pharmacistText.AutoSize = true;
            this.pharmacistText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pharmacistText.Location = new System.Drawing.Point(80, 224);
            this.pharmacistText.Name = "pharmacistText";
            this.pharmacistText.Size = new System.Drawing.Size(112, 24);
            this.pharmacistText.TabIndex = 1;
            this.pharmacistText.Text = "Pharmacist";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(307, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1073, 544);
            this.dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.medQuantityTextBox);
            this.panel1.Controls.Add(this.medNameTextBox);
            this.panel1.Controls.Add(this.btnMedicins);
            this.panel1.Controls.Add(this.exitPharmacist);
            this.panel1.Location = new System.Drawing.Point(307, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 228);
            this.panel1.TabIndex = 13;
            // 
            // btnMedicins
            // 
            this.btnMedicins.BackColor = System.Drawing.Color.Yellow;
            this.btnMedicins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicins.ForeColor = System.Drawing.Color.Black;
            this.btnMedicins.Location = new System.Drawing.Point(923, 160);
            this.btnMedicins.Name = "btnMedicins";
            this.btnMedicins.Size = new System.Drawing.Size(123, 47);
            this.btnMedicins.TabIndex = 10;
            this.btnMedicins.Text = "My Store";
            this.btnMedicins.UseVisualStyleBackColor = false;
            this.btnMedicins.Click += new System.EventHandler(this.btnMedicins_Click);
            // 
            // medNameTextBox
            // 
            this.medNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medNameTextBox.Location = new System.Drawing.Point(90, 47);
            this.medNameTextBox.Name = "medNameTextBox";
            this.medNameTextBox.Size = new System.Drawing.Size(244, 26);
            this.medNameTextBox.TabIndex = 11;
            // 
            // medQuantityTextBox
            // 
            this.medQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medQuantityTextBox.Location = new System.Drawing.Point(90, 124);
            this.medQuantityTextBox.Name = "medQuantityTextBox";
            this.medQuantityTextBox.Size = new System.Drawing.Size(244, 26);
            this.medQuantityTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Medicine Quantity";
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelPharmacist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.Text = "Pharmacist";
            ((System.ComponentModel.ISupportInitialize)(this.exitPharmacist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPharmacist)).EndInit();
            this.panelPharmacist.ResumeLayout(false);
            this.panelPharmacist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitPharmacist;
        private System.Windows.Forms.PictureBox picBoxPharmacist;
        private System.Windows.Forms.Panel panelPharmacist;
        private System.Windows.Forms.Button btnEmployeeList;
        private System.Windows.Forms.Button btnAddToStore;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label pharmacistText;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnRemoveFromStore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMedicins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox medQuantityTextBox;
        private System.Windows.Forms.TextBox medNameTextBox;
    }
}