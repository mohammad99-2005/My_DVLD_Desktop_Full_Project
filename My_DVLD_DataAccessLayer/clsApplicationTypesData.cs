using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsApplicationTypesData
    {

        public static bool FindByApplicationID(int ApplicationID,ref string ApplicationTypeTitle,ref int ApplicationFees)
        {

            bool Finded = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connect);
            
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();
                    ApplicationFees = Convert.ToInt32(reader["ApplicationFees"]);
                    Finded = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return Finded;
        }

        public static bool FindByApplicationTitle(ref int ApplicationID, string ApplicationTypeTitle, ref int ApplicationFees)
        {
            bool Finded = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from ApplicationTypes where ApplicationTypeTitle = @ApplicationTypeTitle";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    ApplicationFees = Convert.ToInt32(reader["ApplicationFees"]);
                    Finded =true;   
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return Finded;
        }

        public static bool UpdateApplicationType( int ApplicationID, string ApplicationTypeTitle, int ApplicationFees)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection( clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"update ApplicationTypes
                        set ApplicationTypeTitle = @ApplicationTypeTitle,
                            ApplicationFees = @ApplicationFees
                            where ApplicationTypeID = @ApplicationID";

            SqlCommand command = new SqlCommand(query,connect);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connect.Open();

                int AffectedRows = command.ExecuteNonQuery();
                if(AffectedRows > 0)
                {
                    Updated = true;
                }
            }
            catch(Exception ex)
            {

            }
            finally { connect.Close(); }
            return Updated;
        }

        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from ApplicationTypes";

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
            catch(Exception ex)
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
