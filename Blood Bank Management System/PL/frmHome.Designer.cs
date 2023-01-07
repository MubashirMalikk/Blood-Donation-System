namespace Blood_Bank_Management_System
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblDevTitle = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOpositveCount = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.lblOnegative = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnegativeCount = new System.Windows.Forms.Label();
            this.lblAnegative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApostiveCount = new System.Windows.Forms.Label();
            this.lblApositve = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABnegativeCount = new System.Windows.Forms.Label();
            this.lblABnegative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBnegativeCount = new System.Windows.Forms.Label();
            this.lblBnegative = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblABpostiveCount = new System.Windows.Forms.Label();
            this.lblABpostive = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBpostiveCount = new System.Windows.Forms.Label();
            this.lblBpostive = new System.Windows.Forms.Label();
            this.dgbDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.donorsToolStripMenuItem,
            this.patientsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(1135, 41);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.patientsToolStripMenuItem.Text = "ViewPatients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.lblDeveloper);
            this.panelFooter.Controls.Add(this.lblDevTitle);
            this.panelFooter.Controls.Add(this.lblAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 569);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1135, 41);
            this.panelFooter.TabIndex = 1;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDeveloper.Location = new System.Drawing.Point(712, 2);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(240, 30);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Mubashir,Aleena,Bakht";
            // 
            // lblDevTitle
            // 
            this.lblDevTitle.AutoSize = true;
            this.lblDevTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDevTitle.Location = new System.Drawing.Point(552, 2);
            this.lblDevTitle.Name = "lblDevTitle";
            this.lblDevTitle.Size = new System.Drawing.Size(154, 30);
            this.lblDevTitle.TabIndex = 1;
            this.lblDevTitle.Text = "Developed By -";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAppName.Location = new System.Drawing.Point(228, 2);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(318, 30);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Blood Bank Management System";
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpositive.Controls.Add(this.lblName);
            this.panelOpositive.Controls.Add(this.lblOpositveCount);
            this.panelOpositive.Controls.Add(this.lblBloodGroup);
            this.panelOpositive.Location = new System.Drawing.Point(13, 107);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(200, 100);
            this.panelOpositive.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(117, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Donors";
            // 
            // lblOpositveCount
            // 
            this.lblOpositveCount.AutoSize = true;
            this.lblOpositveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpositveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOpositveCount.Location = new System.Drawing.Point(107, 36);
            this.lblOpositveCount.Name = "lblOpositveCount";
            this.lblOpositveCount.Size = new System.Drawing.Size(77, 47);
            this.lblOpositveCount.TabIndex = 1;
            this.lblOpositveCount.Text = "100";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBloodGroup.Location = new System.Drawing.Point(3, 36);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(98, 65);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "O+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOnegativeCount);
            this.panel1.Controls.Add(this.lblOnegative);
            this.panel1.Location = new System.Drawing.Point(233, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donors";
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegativeCount.Location = new System.Drawing.Point(107, 36);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblOnegativeCount.TabIndex = 1;
            this.lblOnegativeCount.Text = "100";
            // 
            // lblOnegative
            // 
            this.lblOnegative.AutoSize = true;
            this.lblOnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegative.Location = new System.Drawing.Point(3, 36);
            this.lblOnegative.Name = "lblOnegative";
            this.lblOnegative.Size = new System.Drawing.Size(83, 65);
            this.lblOnegative.TabIndex = 0;
            this.lblOnegative.Text = "O-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAnegativeCount);
            this.panel2.Controls.Add(this.lblAnegative);
            this.panel2.Location = new System.Drawing.Point(233, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Donors";
            // 
            // lblAnegativeCount
            // 
            this.lblAnegativeCount.AutoSize = true;
            this.lblAnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegativeCount.Location = new System.Drawing.Point(107, 29);
            this.lblAnegativeCount.Name = "lblAnegativeCount";
            this.lblAnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblAnegativeCount.TabIndex = 1;
            this.lblAnegativeCount.Text = "100";
            // 
            // lblAnegative
            // 
            this.lblAnegative.AutoSize = true;
            this.lblAnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegative.Location = new System.Drawing.Point(3, 29);
            this.lblAnegative.Name = "lblAnegative";
            this.lblAnegative.Size = new System.Drawing.Size(81, 65);
            this.lblAnegative.TabIndex = 0;
            this.lblAnegative.Text = "A-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblApostiveCount);
            this.panel3.Controls.Add(this.lblApositve);
            this.panel3.Location = new System.Drawing.Point(13, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Donors";
            // 
            // lblApostiveCount
            // 
            this.lblApostiveCount.AutoSize = true;
            this.lblApostiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApostiveCount.Location = new System.Drawing.Point(107, 29);
            this.lblApostiveCount.Name = "lblApostiveCount";
            this.lblApostiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblApostiveCount.TabIndex = 1;
            this.lblApostiveCount.Text = "100";
            // 
            // lblApositve
            // 
            this.lblApositve.AutoSize = true;
            this.lblApositve.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApositve.Location = new System.Drawing.Point(3, 29);
            this.lblApositve.Name = "lblApositve";
            this.lblApositve.Size = new System.Drawing.Size(96, 65);
            this.lblApositve.TabIndex = 0;
            this.lblApositve.Text = "A+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblABnegativeCount);
            this.panel4.Controls.Add(this.lblABnegative);
            this.panel4.Location = new System.Drawing.Point(233, 439);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Donors";
            // 
            // lblABnegativeCount
            // 
            this.lblABnegativeCount.AutoSize = true;
            this.lblABnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegativeCount.Location = new System.Drawing.Point(107, 26);
            this.lblABnegativeCount.Name = "lblABnegativeCount";
            this.lblABnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblABnegativeCount.TabIndex = 1;
            this.lblABnegativeCount.Text = "100";
            // 
            // lblABnegative
            // 
            this.lblABnegative.AutoSize = true;
            this.lblABnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegative.Location = new System.Drawing.Point(3, 26);
            this.lblABnegative.Name = "lblABnegative";
            this.lblABnegative.Size = new System.Drawing.Size(112, 65);
            this.lblABnegative.TabIndex = 0;
            this.lblABnegative.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblBnegativeCount);
            this.panel5.Controls.Add(this.lblBnegative);
            this.panel5.Location = new System.Drawing.Point(233, 330);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(117, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            this.lblBnegativeCount.AutoSize = true;
            this.lblBnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegativeCount.Location = new System.Drawing.Point(107, 35);
            this.lblBnegativeCount.Name = "lblBnegativeCount";
            this.lblBnegativeCount.Size = new System.Drawing.Size(77, 47);
            this.lblBnegativeCount.TabIndex = 1;
            this.lblBnegativeCount.Text = "100";
            // 
            // lblBnegative
            // 
            this.lblBnegative.AutoSize = true;
            this.lblBnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegative.Location = new System.Drawing.Point(3, 35);
            this.lblBnegative.Name = "lblBnegative";
            this.lblBnegative.Size = new System.Drawing.Size(78, 65);
            this.lblBnegative.TabIndex = 0;
            this.lblBnegative.Text = "B-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.lblABpostiveCount);
            this.panel6.Controls.Add(this.lblABpostive);
            this.panel6.Location = new System.Drawing.Point(13, 439);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(117, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Donors";
            // 
            // lblABpostiveCount
            // 
            this.lblABpostiveCount.AutoSize = true;
            this.lblABpostiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpostiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABpostiveCount.Location = new System.Drawing.Point(107, 26);
            this.lblABpostiveCount.Name = "lblABpostiveCount";
            this.lblABpostiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblABpostiveCount.TabIndex = 1;
            this.lblABpostiveCount.Text = "100";
            // 
            // lblABpostive
            // 
            this.lblABpostive.AutoSize = true;
            this.lblABpostive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpostive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABpostive.Location = new System.Drawing.Point(3, 26);
            this.lblABpostive.Name = "lblABpostive";
            this.lblABpostive.Size = new System.Drawing.Size(127, 65);
            this.lblABpostive.TabIndex = 0;
            this.lblABpostive.Text = "AB+";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblBpostiveCount);
            this.panel7.Controls.Add(this.lblBpostive);
            this.panel7.Location = new System.Drawing.Point(13, 330);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(117, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "Donors";
            // 
            // lblBpostiveCount
            // 
            this.lblBpostiveCount.AutoSize = true;
            this.lblBpostiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpostiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpostiveCount.Location = new System.Drawing.Point(107, 35);
            this.lblBpostiveCount.Name = "lblBpostiveCount";
            this.lblBpostiveCount.Size = new System.Drawing.Size(77, 47);
            this.lblBpostiveCount.TabIndex = 1;
            this.lblBpostiveCount.Text = "100";
            // 
            // lblBpostive
            // 
            this.lblBpostive.AutoSize = true;
            this.lblBpostive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpostive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpostive.Location = new System.Drawing.Point(3, 35);
            this.lblBpostive.Name = "lblBpostive";
            this.lblBpostive.Size = new System.Drawing.Size(93, 65);
            this.lblBpostive.TabIndex = 0;
            this.lblBpostive.Text = "B+";
            // 
            // dgbDonors
            // 
            this.dgbDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDonors.Location = new System.Drawing.Point(467, 140);
            this.dgbDonors.Name = "dgbDonors";
            this.dgbDonors.Size = new System.Drawing.Size(646, 393);
            this.dgbDonors.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(472, 91);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(109, 21);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Donor";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(609, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(504, 29);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1093, 8);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(37, 28);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitle.Location = new System.Drawing.Point(14, 50);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(109, 20);
            this.lblUserTitle.TabIndex = 14;
            this.lblUserTitle.Text = "Logged In As :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblUser.Location = new System.Drawing.Point(124, 46);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(17, 25);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(165, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Blood Stock";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgbDonors);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblDevTitle;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOpositveCount;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.Label lblOnegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnegativeCount;
        private System.Windows.Forms.Label lblAnegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApostiveCount;
        private System.Windows.Forms.Label lblApositve;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABnegativeCount;
        private System.Windows.Forms.Label lblABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBnegativeCount;
        private System.Windows.Forms.Label lblBnegative;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblABpostiveCount;
        private System.Windows.Forms.Label lblABpostive;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBpostiveCount;
        private System.Windows.Forms.Label lblBpostive;
        private System.Windows.Forms.DataGridView dgbDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
    }
}

