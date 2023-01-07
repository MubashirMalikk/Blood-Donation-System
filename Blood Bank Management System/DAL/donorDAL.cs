using Blood_Bank_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.DAL
{
    internal class donorDAL
    {
        //Create a Connection string to connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region SELECT to display data in DataGridView
        public DataTable Select()
        {
            //Create object to DataTable
            DataTable dt = new DataTable();

            //Create object of sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Sql Query to select data 
                string sql = "SELECT * FROM tbl_donors";

                //command to execute sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Sql Adapter to hold data Temporarliy
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Connection
                conn.Open();

                //pass the data from adapter to datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return dt;
        }
        #endregion
        #region INSERT Data to DataTable
        public bool Insert(donorBLL d)
        {
            //Create bool Variable
            bool isSuccess = false;

            //Sql Connection to Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {

                //sqlcommadn to excute query
                SqlCommand cmd = new SqlCommand("addsDonors", conn);

                //pass value to query
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@contact", d.contact);


                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region UPDATE donors in database
        public bool Update(donorBLL d)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                SqlCommand cmd = new SqlCommand("UpdateDonors", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);
                cmd.Parameters.AddWithValue("@contact", d.contact);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region DELETE donors from Database
        public bool Delete(donorBLL d)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                SqlCommand cmd=new SqlCommand("DeleteDonors", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess=true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
            #endregion

           
        }
        #region Count Donors for specific Blood Group
        public string countDonors(string blood_group)
        {
            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //string variable for donor count
            string donors = "0";
            try
            {
                //Sql query to count donor
                string sql = "SELECT * FROM tbl_donors WHERE blood_group = '" + blood_group + "'";//concatinating

                SqlCommand cmd = new SqlCommand(sql,conn);

                //Data Apadter to get data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Total Number of donor
                donors=dt.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return donors;
        }
        #endregion

        #region Method to Search Donors
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_donors WHERE donor_id LIKE '%" + keywords + "%'OR first_name LIKE'%"+keywords+"%'OR last_name LIKE '%"+keywords+"%' OR email LIKE '%"+keywords+"%'";//concatinating

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
          
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion

    }
}
