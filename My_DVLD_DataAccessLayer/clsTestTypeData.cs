using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsTestTypeData
    {

        public static bool FindByTestTypeID(int TestTypeID,ref string TestTypeTitle,ref string TestTypeDescription,ref int TestTypeFees)
        {
            bool exist = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from TestTypes where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query,connect);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeTitle = reader["TestTypeTitle"].ToString();
                    TestTypeDescription = reader["TestTypeDescription"].ToString();
                    TestTypeFees = Convert.ToInt32(reader["TestTypeFees"]);
                    exist = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                
            }
            finally { connect.Close(); }
            return exist;
        }


        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle,  string TestTypeDescription, int TestTypeFees)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"update TestTypes
                        set TestTypeTitle = @TestTypeTitle,
                            TestTypeFees = @TestTypeFees,
                            TestTypeDescription = @TestTypeDescription
                            where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);

            try
            {
                connect.Open();

                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows > 0)
                {
                    Updated = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally { connect.Close(); }
            return Updated;
        }


        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from TestTypes";

            SqlCommand command = new SqlCommand(query, connect);

            try
            {
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return dt;
        }




    }
}
