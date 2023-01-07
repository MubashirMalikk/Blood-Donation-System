using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.PL
{
    public partial class frmLoginPatient : Form
    {
        public frmLoginPatient()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Mubashir" && txtPassword.Text == "123")
            {
                MessageBox.Show("Login Succesfull");
                frmPatients p = new frmPatients();
                p.Show();
            }
           
        }
    }
}
