using Blood_Bank_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.DAL
{
    internal class patientsDAL
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
                String sql = "SELECT * FROM tbl_patients";
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
        #region Submit Data Into Database for User Modeule
        public bool Submit(patientsBLL p)
        {
            //Create a boolean variable and set value to false
            bool isSuccess = false;
            //Create and object sql connection to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a string variable to store insert query

                SqlCommand cmd = new SqlCommand("patientsSubmit", conn);
                //Create a Sql comand to pass value
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullname", p.fullname);
                cmd.Parameters.AddWithValue("@age", p.age);
                cmd.Parameters.AddWithValue("@blood_group", p.blood_group);
                cmd.Parameters.AddWithValue("@gender", p.gender);
                cmd.Parameters.AddWithValue("@contact", p.contact);
                cmd.Parameters.AddWithValue("@address", p.address);

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
        #region Method to Search Donors
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_patients WHERE fullname LIKE '%" + keywords + "%'OR blood_group LIKE'%" + keywords + "%' OR age LIKE '%" + keywords + "%'";//concatinating
                ;//concatinating

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

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
    }
}
