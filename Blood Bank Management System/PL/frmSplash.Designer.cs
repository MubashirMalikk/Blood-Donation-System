namespace Blood_Bank_Management_System.UI
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBG = new System.Windows.Forms.Panel();
            this.panelMoveable = new System.Windows.Forms.Panel();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(224, 133);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 102);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(368, 133);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(260, 50);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "BLOOD BANK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Management System";
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBG.Controls.Add(this.panelMoveable);
            this.panelBG.Location = new System.Drawing.Point(1, 366);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(800, 39);
            this.panelBG.TabIndex = 3;
            // 
            // panelMoveable
            // 
            this.panelMoveable.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMoveable.Location = new System.Drawing.Point(1, 0);
            this.panelMoveable.Name = "panelMoveable";
            this.panelMoveable.Size = new System.Drawing.Size(31, 39);
            this.panelMoveable.TabIndex = 0;
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.Panel panelMoveable;
        private System.Windows.Forms.Timer timerSplash;
    }
}