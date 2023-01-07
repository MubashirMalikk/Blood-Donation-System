using Blood_Bank_Management_System.DAL;
using Blood_Bank_Management_System.PL;
using Blood_Bank_Management_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        donorDAL dal = new donorDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Code to Close the Application
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Users Form
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Manage Donoe Form
            frmDonors donors = new frmDonors();
            donors.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Load the blood group count
            allDonorCount();

            //Display All Donors
            DataTable dt = dal.Select();
            dgbDonors.DataSource = dt;

            lblUser.Text = frmLogin.loggedInUser;

        }
        public void allDonorCount()
        {
            //get donor count from database and set it
            lblOpositveCount.Text = dal.countDonors("O+");
            lblOnegativeCount.Text = dal.countDonors("O-");
            lblApostiveCount.Text = dal.countDonors("A+");
            lblAnegativeCount.Text = dal.countDonors("A-");
            lblBpostiveCount.Text = dal.countDonors("B+");
            lblBnegativeCount.Text = dal.countDonors("B-");
            lblABpostiveCount.Text = dal.countDonors("AB+");
            lblABnegativeCount.Text = dal.countDonors("AB-");
        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            //Call donors count
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords=txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgbDonors.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgbDonors.DataSource=dt;    
            }
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewPatients view = new frmViewPatients();
            view.Show();
        }
    }
}
