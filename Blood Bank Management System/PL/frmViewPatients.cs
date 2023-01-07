using Blood_Bank_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.PL
{
    public partial class frmViewPatients : Form
    {
        public frmViewPatients()
        {
            InitializeComponent();
        }
        patientsDAL dal = new patientsDAL();

        private void txtSearchPatients_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearchPatients.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgbPatients.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgbPatients.DataSource = dt;
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgbPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmViewPatients_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgbPatients.DataSource = dt;
        }
    }
}
