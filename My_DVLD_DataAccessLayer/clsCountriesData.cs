using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsCountriesData
    {
        public static bool FindCountryByID(int CountryID , ref string CountryName)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Countries where CountryID=@CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryName = reader["CountryName"].ToString();
                }
                result = true;
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Countries;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public static bool FindCountryByName(ref int CountryID, string CountryName)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Countries where CountryName=@CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryID = int.Parse(reader["CountryID"].ToString());
                }
                result = true;
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


    }
}
