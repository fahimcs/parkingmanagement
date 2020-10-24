namespace ParkingManagement
{
    partial class frmparkingcontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmparkingcontrol));
            this.panelAddnew = new System.Windows.Forms.Panel();
            this.lblAddnew = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLicenseNew = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLicenseCheckout = new System.Windows.Forms.Label();
            this.txtLicensecheckout = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblParkingmap = new System.Windows.Forms.Label();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnBackMainMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAddnew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddnew
            // 
            this.panelAddnew.BackColor = System.Drawing.Color.Transparent;
            this.panelAddnew.Controls.Add(this.lblAddnew);
            this.panelAddnew.Controls.Add(this.lblPhone);
            this.panelAddnew.Controls.Add(this.textBox1);
            this.panelAddnew.Controls.Add(this.lblLicenseNew);
            this.panelAddnew.Controls.Add(this.textBox2);
            this.panelAddnew.Controls.Add(this.dataGridView2);
            this.panelAddnew.Controls.Add(this.btnAddnew);
            this.panelAddnew.Location = new System.Drawing.Point(55, 76);
            this.panelAddnew.Name = "panelAddnew";
            this.panelAddnew.Size = new System.Drawing.Size(854, 238);
            this.panelAddnew.TabIndex = 7;
            this.panelAddnew.Tag = "ADD NEW";
            // 
            // lblAddnew
            // 
            this.lblAddnew.BackColor = System.Drawing.Color.Transparent;
            this.lblAddnew.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddnew.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblAddnew.Location = new System.Drawing.Point(7, 4);
            this.lblAddnew.Name = "lblAddnew";
            this.lblAddnew.Size = new System.Drawing.Size(216, 42);
            this.lblAddnew.TabIndex = 13;
            this.lblAddnew.Text = "New Vehicle";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(10, 120);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(156, 25);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone Number";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(225, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 25);
            this.textBox1.TabIndex = 11;
            // 
            // lblLicenseNew
            // 
            this.lblLicenseNew.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblLicenseNew.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseNew.ForeColor = System.Drawing.Color.Transparent;
            this.lblLicenseNew.Location = new System.Drawing.Point(10, 63);
            this.lblLicenseNew.Name = "lblLicenseNew";
            this.lblLicenseNew.Size = new System.Drawing.Size(156, 25);
            this.lblLicenseNew.TabIndex = 10;
            this.lblLicenseNew.Text = "License Number";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(225, 63);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 25);
            this.textBox2.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(447, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(394, 166);
            this.dataGridView2.TabIndex = 8;
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddnew.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.Location = new System.Drawing.Point(14, 175);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(358, 50);
            this.btnAddnew.TabIndex = 7;
            this.btnAddnew.Text = "New Parking Slip";
            this.btnAddnew.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblLicenseCheckout);
            this.panel1.Controls.Add(this.txtLicensecheckout);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.lblCheckout);
            this.panel1.Location = new System.Drawing.Point(55, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 229);
            this.panel1.TabIndex = 8;
            // 
            // lblLicenseCheckout
            // 
            this.lblLicenseCheckout.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblLicenseCheckout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseCheckout.ForeColor = System.Drawing.Color.Transparent;
            this.lblLicenseCheckout.Location = new System.Drawing.Point(21, 74);
            this.lblLicenseCheckout.Name = "lblLicenseCheckout";
            this.lblLicenseCheckout.Size = new System.Drawing.Size(156, 25);
            this.lblLicenseCheckout.TabIndex = 15;
            this.lblLicenseCheckout.Text = "License Number";
            // 
            // txtLicensecheckout
            // 
            this.txtLicensecheckout.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLicensecheckout.Location = new System.Drawing.Point(236, 74);
            this.txtLicensecheckout.Multiline = true;
            this.txtLicensecheckout.Name = "txtLicensecheckout";
            this.txtLicensecheckout.Size = new System.Drawing.Size(147, 25);
            this.txtLicensecheckout.TabIndex = 14;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCheckout.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(25, 114);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(358, 48);
            this.btnCheckout.TabIndex = 15;
            this.btnCheckout.Text = "Checkout ";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // lblCheckout
            // 
            this.lblCheckout.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckout.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblCheckout.Location = new System.Drawing.Point(17, 10);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(216, 42);
            this.lblCheckout.TabIndex = 14;
            this.lblCheckout.Text = "Checkout";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DimGray;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(912, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 50);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // lblParkingmap
            // 
            this.lblParkingmap.BackColor = System.Drawing.Color.Transparent;
            this.lblParkingmap.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingmap.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblParkingmap.Location = new System.Drawing.Point(469, 334);
            this.lblParkingmap.Name = "lblParkingmap";
            this.lblParkingmap.Size = new System.Drawing.Size(236, 42);
            this.lblParkingmap.TabIndex = 14;
            this.lblParkingmap.Text = "Parking Map";
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.LightGray;
            this.btnLevel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.Location = new System.Drawing.Point(667, 334);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(77, 32);
            this.btnLevel1.TabIndex = 15;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.LightGray;
            this.btnLevel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.Location = new System.Drawing.Point(750, 334);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(77, 32);
            this.btnLevel2.TabIndex = 16;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            // 
            // btnBackMainMenu
            // 
            this.btnBackMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackMainMenu.BackgroundImage")));
            this.btnBackMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMainMenu.Location = new System.Drawing.Point(55, 22);
            this.btnBackMainMenu.Name = "btnBackMainMenu";
            this.btnBackMainMenu.Size = new System.Drawing.Size(50, 30);
            this.btnBackMainMenu.TabIndex = 17;
            this.btnBackMainMenu.UseVisualStyleBackColor = true;
            this.btnBackMainMenu.Click += new System.EventHandler(this.btnBackMainMenu_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(746, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Parking Management System. v1.0.0.0";
            // 
            // frmparkingcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBackMainMenu);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel1);
            this.Controls.Add(this.lblParkingmap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAddnew);
            this.Controls.Add(this.btnHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmparkingcontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmparkingcontrol_FormClosing);
            this.panelAddnew.ResumeLayout(false);
            this.panelAddnew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddnew;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLicenseNew;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Label lblAddnew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblLicenseCheckout;
        private System.Windows.Forms.TextBox txtLicensecheckout;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblParkingmap;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnBackMainMenu;
        private System.Windows.Forms.Label label3;

    }
}