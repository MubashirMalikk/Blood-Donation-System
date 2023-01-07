using Blood_Bank_Management_System.BLL;
using Blood_Bank_Management_System.DAL;
using Blood_Bank_Management_System.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        loginBLL l=new loginBLL();
        loginDAL dal = new loginDAL();

         public static string loggedInUser;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username=txtUsername.Text;
            l.password = txtPassword.Text;

            

            bool isSuccess = dal.loginCheck(l);

            if (isSuccess == true)
            {
                MessageBox.Show("Login Succesfull");

                loggedInUser=l.username;

                frmHome home = new frmHome();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed.Try Again..");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoginPatient patients = new frmLoginPatient();
            patients.Show();
        }
    }
}
