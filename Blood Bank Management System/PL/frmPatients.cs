using Blood_Bank_Management_System.BLL;
using Blood_Bank_Management_System.DAL;
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
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }
        patientsBLL b = new patientsBLL();
        patientsDAL dal = new patientsDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the value from UI
            b.fullname = txtFullName.Text;
            b.age = txtAge.Text;
            b.blood_group = cmbBloodGroup.Text;
            b.gender = cmbGender.Text;
            b.contact = txtContact.Text;
            b.address = txtAddress.Text;

            //Adding value to Database
            bool success = dal.Submit(b);

            if (success == true)
            {
                MessageBox.Show("Submitted Successfully");
            }
            else
            {
                MessageBox.Show("Try Again..");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtAge.Text = "";
            cmbBloodGroup.Text = "";
            cmbGender.Text = "";
            txtAddress.Text = "";
            txtAddress.Text = "";
        }

        private void frmPatients_Load(object sender, EventArgs e)
        {

        }
    }
}
