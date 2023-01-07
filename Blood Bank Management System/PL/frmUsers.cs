using Blood_Bank_Management_System.BLL;
using Blood_Bank_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        //object of userBusinessLinkLayer and userDataAccessLayer
        userBLL u = new userBLL();
        userDAL dal=new userDAL();


        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Add functionallity to close form
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from UI
            u.full_name = txtFullName.Text;
            u.email =  txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address=txtAddress.Text;
            u.added_date = DateTime.Now;

            //Adding value to Database
            bool success = dal.Insert(u);

            //Check is Data inserted
            if (success == true)
            {
                MessageBox.Show("New User added succesfully");

                //Display User in grid view
                DataTable dt = dal.Select();
                dgbUsers.DataSource = dt;

                //Clear textboxes
                Clear();


            }
            else
            {
                MessageBox.Show("Failed to Add New User");
            }

        }
        //Fucntion to Clear textbox
        public void Clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";
        }

        private void dgbUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Find The index which row is clicked on grid view
            int RowIndex=e.RowIndex;
            txtUserID.Text = dgbUsers.Rows[RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgbUsers.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgbUsers.Rows[RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgbUsers.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgbUsers.Rows[RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgbUsers.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgbUsers.Rows[RowIndex].Cells[6].Value.ToString();

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //Display in grid view when form loaded
            DataTable dt=dal.Select();
            dgbUsers.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get values from UI
            u.user_id=int.Parse(txtUserID.Text);
            u.full_name=txtFullName.Text;
            u.email=txtEmail.Text;
            u.username=txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact=txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;

            //bool var to check data updated or not
            bool success = dal.Update(u);

            //Check data updated or not
            if (success == true)
            {
                MessageBox.Show("User Updated Succesfully");

                //Refresh gridview
                DataTable dt = dal.Select();
                dgbUsers.DataSource = dt;

                //Clear 
                Clear();
            }
            else
            {
                MessageBox.Show("Failed Updation");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get userid to delete
            u.user_id = int.Parse(txtUserID.Text);

            //create to check deleted or not
            bool success=dal.Delete(u);

            //check deleted or not
            if (success == true)
            {
                MessageBox.Show("Deleted Succesfully");

                //refresh
                DataTable dt = dal.Select();
                dgbUsers.DataSource = dt;

                //Clear
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call Clear Funtion    
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Code to Get user based on keywords
            //Get the Keywords
            String keywords = txtSearch.Text;

            //Check textbox empty or not
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgbUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgbUsers.DataSource = dt;
            }
        }
    }
}
