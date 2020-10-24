namespace ParkingManagement
{
    partial class frmparkingrecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmparkingrecord));
            this.label2 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLicenseNew = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblParkingRecord = new System.Windows.Forms.Label();
            this.btnBacklevel1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(746, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Parking Management System. v1.0.0.0";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(82, 201);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(156, 25);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone Number";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(297, 201);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 25);
            this.textBox1.TabIndex = 16;
            // 
            // lblLicenseNew
            // 
            this.lblLicenseNew.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblLicenseNew.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseNew.ForeColor = System.Drawing.Color.Transparent;
            this.lblLicenseNew.Location = new System.Drawing.Point(82, 144);
            this.lblLicenseNew.Name = "lblLicenseNew";
            this.lblLicenseNew.Size = new System.Drawing.Size(156, 25);
            this.lblLicenseNew.TabIndex = 15;
            this.lblLicenseNew.Text = "License Number";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(297, 144);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 25);
            this.textBox2.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(297, 253);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 32);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(501, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // lblParkingRecord
            // 
            this.lblParkingRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblParkingRecord.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingRecord.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblParkingRecord.Location = new System.Drawing.Point(78, 64);
            this.lblParkingRecord.Name = "lblParkingRecord";
            this.lblParkingRecord.Size = new System.Drawing.Size(270, 42);
            this.lblParkingRecord.TabIndex = 24;
            this.lblParkingRecord.Text = "Parking Records";
            // 
            // btnBacklevel1
            // 
            this.btnBacklevel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBacklevel1.BackgroundImage")));
            this.btnBacklevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBacklevel1.Location = new System.Drawing.Point(86, 22);
            this.btnBacklevel1.Name = "btnBacklevel1";
            this.btnBacklevel1.Size = new System.Drawing.Size(50, 30);
            this.btnBacklevel1.TabIndex = 25;
            this.btnBacklevel1.UseVisualStyleBackColor = true;
            this.btnBacklevel1.Click += new System.EventHandler(this.btnBacklevel1_Click);
            // 
            // frmparkingrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnBacklevel1);
            this.Controls.Add(this.lblParkingRecord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLicenseNew);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmparkingrecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmparkingrecord_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLicenseNew;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblParkingRecord;
        private System.Windows.Forms.Button btnBacklevel1;
    }
}