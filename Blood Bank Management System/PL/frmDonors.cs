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

namespace Blood_Bank_Management_System.UI
{
    public partial class frmDonors : Form
    {
        public frmDonors()
        {
            InitializeComponent();
        }
        //Object for DAL and BLL
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        userDAL udal = new userDAL();
        
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmDonors_Load(object sender, EventArgs e)
        {
            //Display in dgv
            DataTable dt = dal.Select();
            dgbDonors.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add new Donor
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastname.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;
            
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromusername(loggedInUser);
            d.added_by = usr.user_id;



            //inserting data into database
            bool isSuccess = dal.Insert(d);

            if (isSuccess == true)
            {
                MessageBox.Show("New Donor Added Succesfully");
                //For Gridview
                DataTable dt = dal.Select();
                dgbDonors.DataSource = dt;

                Clear();

               
            }
            else
            {
                MessageBox.Show("Failed to Add new donor");
            }

        }
        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtDonorID.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
        }

        private void dgbDonors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.donor_id=int.Parse(txtDonorID.Text);
            d.first_name=txtFirstName.Text;
            d.last_name = txtLastname.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group= cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;
            
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromusername(loggedInUser);
            d.added_by = usr.user_id;

            bool isSuccess = dal.Update(d);

            //Check data updated or not
            if (isSuccess == true)
            {
                MessageBox.Show("Donor Updated Succesfully");

                //Clear 
                Clear();

                //Refresh gridview
                DataTable dt = dal.Select();
                dgbDonors.DataSource = dt;

                
            }
            else
            {
                MessageBox.Show("Failed Updation");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get donorid to delete
            d.donor_id = int.Parse(txtDonorID.Text);

            //create to check deleted or not
            bool isSuccess = dal.Delete(d);

            //check deleted or not
            if (isSuccess == true)
            {
                MessageBox.Show("Deleted Succesfully");

                //refresh
                DataTable dt = dal.Select();
                dgbDonors.DataSource = dt;

                //Clear
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete");
            }
        }

        private void dgbDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtDonorID.Text = dgbDonors.Rows[RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgbDonors.Rows[RowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dgbDonors.Rows[RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgbDonors.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgbDonors.Rows[RowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgbDonors.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgbDonors.Rows[RowIndex].Cells[6].Value.ToString();
            cmbBloodGroup.Text = dgbDonors.Rows[RowIndex].Cells[7].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords =txtSearch.Text;

            //Check empty or full
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
    }
    }

