using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace My_DVLD_DataAccessLayer
{
    public class clsLicensesData
    {

        public static bool FindByLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
                        ref DateTime IssueDate,ref DateTime ExpirationDate,ref string Notes,ref int PaidFees,ref bool IsActive,
                        ref byte IssueReason,ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Licenses where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = DateTime.Parse(reader["IssueDate"].ToString());
                    ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
                    Notes = reader["Notes"].ToString();
                    PaidFees =Convert.ToInt32(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReason = Convert.ToByte(reader["IssueReason"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

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


        // from me ?*?*?*?*?*?
        public static bool FindLicenseByApplicationIDandLicenseClass(ref int LicenseID, int ApplicationID, ref int DriverID, int LicenseClass,
                ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref int PaidFees, ref bool IsActive,
                ref byte IssueReason, ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Licenses where ApplicationID = @ApplicationID and LicenseClass = @LicenseClass;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = DateTime.Parse(reader["IssueDate"].ToString());
                    ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
                    Notes = reader["Notes"].ToString();
                    PaidFees = Convert.ToInt32(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReason = Convert.ToByte(reader["IssueReason"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

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



        public static int AddNewLicense( int ApplicationID,  int DriverID,  int LicenseClass,
                        DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, bool IsActive,
                        byte IssueReason, int CreatedByUserID)
        {
            int NewLicenseID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);
            string query = @"insert into Licenses (ApplicationID, DriverID,LicenseClass,IssueDate,ExpirationDate,
                             Notes,PaidFees,IsActive,IssueReason,CreatedByUserID)
                           values (@ApplicationID,@DriverID,@LicenseClass,@IssueDate,@ExpirationDate,
                             @Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connect.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int AddedLicenseID))
                {
                    NewLicenseID = AddedLicenseID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return NewLicenseID;
        }

        public static bool UpdateLicenseInfo(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
                        DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, bool IsActive,
                        byte IssueReason, int CreatedByUserID)
        {// of course we have to edit but later
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            // if it have to edit like to Update.
            string query = @"Update Licenses
                            set ApplicationID =@ApplicationID,
                            DriverID =@DriverID,
                            LicenseClass =@LicenseClass,
                            IssueDate =@IssueDate,
                            ExpirationDate =@ExpirationDate,
                            Notes =@Notes,
                            PaidFees =@PaidFees,
                            IsActive =@IsActive,
                            IssueReason =@IssueReason,
                            CreatedByUserID =@CreatedByUserID, 
                            where LicenseID = @LicenseID; ";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
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

        public static DataTable GetAllLicenses()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Licenses;";

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

        public static DataTable GetAllLicensesToDriver(int DriverID)
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select 
                            Licenses.LicenseID,
                            Licenses.ApplicationID,
                            LicenseClasses.ClassName,
                            Licenses.IssueDate,
                            Licenses.ExpirationDate,Licenses.IsActive 
                            from Licenses join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where DriverID = @DriverID order by IsActive Desc,ExpirationDate Desc";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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


        public static bool DoesHasThisLicense(int ApplicationID, int LicenseClass)
        {
            bool HasLicense = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from Licenses where ApplicationID = @ApplicationID and @LicenseClass = LicenseClass;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    HasLicense = true;
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
            return HasLicense;
        }


        public static bool IsExist(int LicenseID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from Licenses where LicenseID = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

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


        public static int GetActiveLicenseIDByPersonID(int PersonID,int LicenseClassID)
        {
            int LicenseID = -1;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select LicenseID from Licenses
                                join
                                Drivers on Licenses.DriverID=Drivers.DriverID
                                where Drivers.PersonID=@PersonID
                                and
                                Licenses.LicenseClass=@LicenseClassID
                                and
                                Licenses.IsActive=1;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connect.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int insertedID))
                {
                    LicenseID = insertedID;
                }
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return LicenseID;
        }


        public static bool DeactivateLicense(int LicenseID)
        {
            int AffectedRow = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update Licenses
                            set 
                            IsActive =0
                            where LicenseID = @LicenseID; ";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connect.Open();

                AffectedRow = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return (AffectedRow>0);
        }

    }
}
