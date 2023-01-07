using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blood_Bank_Management_System.BLL;
using System.Drawing;

namespace Blood_Bank_Management_System.DAL
{
    internal class userDAL
    {
        //Create a Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region SELECT data from database
        public DataTable Select()
        {
            //Object to connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a DataTable to Hold the Data fro Database
            DataTable dt = new DataTable();

            try
            {
                //Sql Query to Get Data from Database
                String sql = "SELECT * FROM tbl_user";
                //Sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open connection
                conn.Open();

                //tranfer data from adapter to datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Error Message from exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data Into Database for User Modeule
        public bool Insert(userBLL u)
        {
            //Create a boolean variable and set value to false
            bool isSuccess = false;
            //Create and object sql connection to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a string variable to store insert query

                SqlCommand cmd = new SqlCommand("addUsers", conn);
                //Create a Sql comand to pass value
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);

                //open dataabase connection
                conn.Open();

                //Create an Integer Variable to hold the value after executed
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
                //Display Error Message if there any exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }


            return isSuccess;
        }
        #endregion

        #region UPDATE data in database (User Module)
        public bool Update(userBLL u)
        {
            //set bool to false
            bool isSuccess = false;

            //Create an object for connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                
                //Create a sql Command
                SqlCommand cmd = new SqlCommand("UpdatesUsers", conn);


                //Using Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //Open Connection
                conn.Open();

                //Create an interger
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
                //Display errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Delete Data from Database(User Module)
        public bool Delete(userBLL u)
        {
            //Create boolean variable
            bool isSuccess = false;

            //create object
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //to execute the query
                SqlCommand cmd = new SqlCommand("DeleteUsers",conn);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.AddWithValue("user_id", u.user_id);

                //open connection
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

        #region SEARCH
        public DataTable Search(string keywords)
        {
            //Create a sql connection for database
            SqlConnection conn=new SqlConnection(myconnstrng);

            //Create Data Table
            DataTable dt = new DataTable();

            //Code for Search
            try 
            {
                //Sql wuery to search
                String sql = "SELECT * FROM tbl_user WHERE user_id LIKE '%" + keywords + "%'OR full_name LIKE '%" + keywords + "%'OR address LIKE '%" + keywords + "%'";
                //Sql command to execute the query
                SqlCommand cmd =new SqlCommand(sql, conn);  
                //Create a DataAdapter to Get Data fro datatable
                SqlDataAdapter adapter=new SqlDataAdapter(cmd);

                //open connection
                conn.Open();

                //pass the data fro adapter to datatable
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                //Display Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;  
        }
        #endregion
        #region
        public userBLL GetIDFromusername(string username)
        {
            userBLL u = new userBLL();

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT user_id FROM tbl_user WHERE username='"+username+"'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    u.user_id = int.Parse(dt.Rows[0]["user_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                //Display Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return u;
        }

        #endregion

    }
}
