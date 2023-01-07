namespace Blood_Bank_Management_System.PL
{
    partial class frmViewPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPatients));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.dgbPatients = new System.Windows.Forms.DataGridView();
            this.txtSearchPatients = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(357, 3);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(136, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "View Patients ";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.BlueViolet;
            this.paneltop.Controls.Add(this.pictureBoxClose);
            this.paneltop.Controls.Add(this.lblFormTitle);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(786, 37);
            this.paneltop.TabIndex = 31;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(754, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // dgbPatients
            // 
            this.dgbPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPatients.Location = new System.Drawing.Point(88, 115);
            this.dgbPatients.Name = "dgbPatients";
            this.dgbPatients.Size = new System.Drawing.Size(647, 312);
            this.dgbPatients.TabIndex = 32;
            this.dgbPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbPatients_CellContentClick);
            // 
            // txtSearchPatients
            // 
            this.txtSearchPatients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatients.Location = new System.Drawing.Point(212, 70);
            this.txtSearchPatients.Name = "txtSearchPatients";
            this.txtSearchPatients.Size = new System.Drawing.Size(523, 29);
            this.txtSearchPatients.TabIndex = 34;
            this.txtSearchPatients.TextChanged += new System.EventHandler(this.txtSearchPatients_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(85, 72);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(121, 21);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Search Patients";
            // 
            // frmViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.txtSearchPatients);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgbPatients);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewPatients";
            this.Load += new System.EventHandler(this.frmViewPatients_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.DataGridView dgbPatients;
        private System.Windows.Forms.TextBox txtSearchPatients;
        private System.Windows.Forms.Label lblSearch;
    }
}