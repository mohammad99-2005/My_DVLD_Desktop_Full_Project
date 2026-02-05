using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsDriversData
    {


        public static bool FindByDriverID(int DriverID, ref int PersonID, ref DateTime CreatedDate,ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Drivers where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static bool FindByPersonID(ref int DriverID, int PersonID, ref DateTime CreatedDate, ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Drivers where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DriverID = (int)reader["DriverID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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


        public static int AddNewDriver(int PersonID, DateTime CreatedDate, int CreatedByUserID)
        {
            int NewDriverID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);
            string query = @"insert into Drivers (PersonID, CreatedDate,CreatedByUserID)
                           values (@PersonID, @CreatedDate, @CreatedByUserID)
                           SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connect.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int AddedDriverID))
                {
                    NewDriverID = AddedDriverID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return NewDriverID;
        }

        public static bool UpdateDriverInfo(int DriverID, int PersonID, int CreatedByUserID)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            // if it have to edit like to Update just the AppointmentDate did it.
            string query = @"Update Drivers
                            set PersonID = @PersonID,
                                CreatedByUserID = @CreatedByUserID,
                                where DriverID = @DriverID; ";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connect.Open();

                int AffectedRow = command.ExecuteNonQuery();
                Updated = AffectedRow > 0;

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return Updated;
        }

        public static DataTable GetAllDrivers()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Drivers;";

            SqlCommand command = new SqlCommand(query, connect);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    datatable.Load(reader);
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
            return datatable;
        }

        public static DataTable GetAllDriversWithPersonalInfo()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"SELECT * FROM Drivers_View order by FullName";

            SqlCommand command = new SqlCommand(query, connect);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    datatable.Load(reader);
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
            return datatable;
        }


        public static bool IsExist(int DriverID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from Drivers where DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
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


    }
}
