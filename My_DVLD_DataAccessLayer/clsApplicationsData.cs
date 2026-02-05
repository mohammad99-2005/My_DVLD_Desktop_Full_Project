using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace My_DVLD_DataAccessLayer
{
    public class clsApplicationsData
    {

        public static bool GetApplicationInfoByID(int ApplicationID,ref int ApplicationPersonID,ref DateTime ApplicationDate,
                        ref int ApplicationTypeID,ref int ApplicationStatus,ref DateTime LastStatusDate,
                        ref int PaidFees,ref int CreatedByUserID)
        {

            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Applications where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query,connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationPersonID =Convert.ToInt32(reader["ApplicantPersonID"]);
                    ApplicationDate = DateTime.Parse(reader["ApplicationDate"].ToString());
                    ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    ApplicationStatus = Convert.ToInt32(reader["ApplicationStatus"]);
                    LastStatusDate = DateTime.Parse(reader["LastStatusDate"].ToString());
                    PaidFees = Convert.ToInt32(reader["PaidFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                    Finded = true;
                }

                reader.Close();

            }
            catch(Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return Finded;
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            bool Exist = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select x=1 from Applications where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                Exist = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return Exist;
        }

        public static int GetActiveApplicationID(int PersonID,int ApplicationTypeID)
        {

            int ActiveAppID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select ActiveApplicationID = ApplicationID
								from 
								Applications
								where
                                ApplicantPersonID = @ApplicationPersonID
                                and
                                ApplicationTypeID = @ApplicationTypeID
                                and
                                ApplicationStatus = 1;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            
            try
            {
                connect.Open();

                object Result = command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(),out int wantedID))
                {
                    ActiveAppID = wantedID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return ActiveAppID;

        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID,int LicenseClassID)
        {

            int ActiveAppID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select ActiveApplicationID = Applications.ApplicationID
								from 
								Applications join LocalDrivingLicenseApplications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
								where 
                                ApplicantPersonID = @ApplicationPersonID
                                and
                                ApplicationTypeID = @ApplicationTypeID
                                and
                                LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                                and
                                (ApplicationStatus = 1 or ApplicationStatus = 3)";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connect.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int wantedID))
                {
                    ActiveAppID = wantedID;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return ActiveAppID;

        }

        public static int AddNewApplication(int ApplicationPersonID, DateTime ApplicationDate,
                        int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate,
                        int PaidFees, int CreatedByUserID)
        {

            int AddNew = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"insert into Applications (ApplicantPersonID,ApplicationDate,ApplicationTypeID,
                                ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
                                values(@ApplicantPersonID,@ApplicationDate,@ApplicationTypeID,
                                @ApplicationStatus,@LastStatusDate,@PaidFees,@CreatedByUserID)
                                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
            try
            {
                connect.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int InsertedID))
                {
                    if (InsertedID > 0)
                    {

                        AddNew = InsertedID;

                    }
                }
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return (AddNew);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            bool Deleted = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "Delete from Applications where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connect.Open();

                int AffectedRows = command.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    Deleted = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally { connect.Close(); }
            return Deleted;

        }

        public static bool UpdateApplication(int ApplicationID,int ApplicantPersonID,DateTime ApplicationDate,
                                            int ApplicationTypeID, int ApplicationStatus,DateTime LastStatusDate,
                                            int PaidFees,int @CreatedByUserID) 
        {

            bool Updated = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update  Applications
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus, 
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID=@CreatedByUserID
                            where ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool DoesPersonHasActiveApplication(int PersonID,int ApplicationTypeID)
        {
            return (GetActiveApplicationID(PersonID, ApplicationTypeID) > -1);
        }


        public static bool UpdateStatus(int ApplicationID,int ApplicationStatus)
        {

            bool Updated = false;
            DateTime LastStatusDate = DateTime.Now;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update  Applications
                            set ApplicationStatus = @ApplicationStatus,
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            
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

        public static DataTable GetAllApplications()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Applications;";

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

    }
}
