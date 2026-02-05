using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsDetainLicensesData
    {

        public static bool FindDetainedLicenseByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate,
                                           ref int FineFees, ref int CreatedByUserID,
                                           ref bool IsReleased, ref DateTime ReleaseDate,
                                           ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from DetainedLicenses where DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = DateTime.Parse(reader["DetainDate"].ToString());
                    FineFees = Convert.ToInt32(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    // Handle Nullable Fields
                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = DateTime.Parse(reader["ReleaseDate"].ToString());

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);

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

        public static bool GetDetainedLicenseByLicenseID(ref int DetainID, int LicenseID, ref DateTime DetainDate,
                                           ref int FineFees, ref int CreatedByUserID,
                                           ref bool IsReleased, ref DateTime ReleaseDate,
                                           ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    DetainDate = DateTime.Parse(reader["DetainDate"].ToString());
                    FineFees = Convert.ToInt32(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsReleased = (bool)reader["IsReleased"];

                    // Handle Nullable Fields
                    if (reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = DateTime.Parse(reader["ReleaseDate"].ToString());

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);

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


        public static int AddNewDetainLicense(int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID)
        {
            int NewDetainID = -1;
            bool IsReleased = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);
            string query = "insert into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased) " +
                           "values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased); " +
                           "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            try
            {
                connect.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int AddDetainID))
                {
                    NewDetainID = AddDetainID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return NewDetainID;
        }



        public static bool ReleaseLicense(int DetainID,int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool Updated = false;

            DateTime ReleaseDate = DateTime.Now;
            bool IsReleased = true;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update DetainedLicenses  
                     set IsReleased = @IsReleased,
                         ReleaseDate = @ReleaseDate,
                         ReleasedByUserID = @ReleasedByUserID,
                         ReleaseApplicationID = @ReleaseApplicationID
                         where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

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

        public static bool UpdateDetainedLicense(int DetainID,int LicenseID, DateTime DetainDate, int FineFees, int CreatedByUserID)
        {
            bool Updated = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update DetainedLicenses  
                     set LicenseID = @LicenseID,
                         DetainDate = @DetainDate,
                         FineFees = @FineFees,
                         CreatedByUserID = @CreatedByUserID
                         where DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connect);


            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@DetainID", DetainID);
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



        public static DataTable GetAllDetainedLicenses()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select DetainedLicenses.DetainID,DetainedLicenses.LicenseID,DetainedLicenses.DetainDate,DetainedLicenses.IsReleased,
				DetainedLicenses.FineFees,DetainedLicenses.ReleaseDate,People.NationalNo,
				People.FirstName+' '+People.SecondName +' '+People.ThirdName+' '+People.LastName as FullName,
				DetainedLicenses.ReleaseApplicationID
				from People join
				Drivers on Drivers.PersonID = People.PersonID join
				Licenses on Licenses.DriverID = Drivers.DriverID right join
				DetainedLicenses on Licenses.LicenseID = DetainedLicenses.LicenseID
				order by DetainedLicenses.DetainID desc;";

            SqlCommand command = new SqlCommand(query, connect);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();
                datatable.Load(reader);

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


        public static bool IsDetained(int LicenseID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from DetainedLicenses where DetainedLicenses.LicenseID = @LicenseID and DetainedLicenses.IsReleased=0;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseID",LicenseID);

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
