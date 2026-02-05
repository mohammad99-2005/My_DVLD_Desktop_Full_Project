using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsInternationalLicensesData
    {
        public static bool FindIntLicenseByIntLicenseID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
                       ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive,
                       ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    ApplicationID = (int)reader["ApplicationID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = DateTime.Parse(reader["IssueDate"].ToString());
                    ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
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


        public static bool FindIntLicenseByLocalLicenseID(int IssuedUsingLocalLicenseID,ref int InternationalLicenseID, ref int ApplicationID, ref int DriverID, 
                       ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive,
                       ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from InternationalLicenses where IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    ApplicationID = (int)reader["ApplicationID"];
                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    DriverID = (int)reader["DriverID"];
                    IssueDate = DateTime.Parse(reader["IssueDate"].ToString());
                    ExpirationDate = DateTime.Parse(reader["ExpirationDate"].ToString());
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
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

        public static int AddNewInternationalLicense(int InternationalLicenseID,int ApplicationID,int DriverID,int IssuedUsingLocalLicenseID,
                        DateTime IssueDate,  DateTime ExpirationDate,  bool IsActive,
                        int CreatedByUserID)
        {
            int NewLicenseID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);
            string query = @"
                            update InternationalLicenses
                            set IsActive = 0
                            where InternationalLicenses.DriverID = @DriverID;

                            insert into InternationalLicenses (ApplicationID,DriverID,IssuedUsingLocalLicenseID,
                            IssueDate,ExpirationDate,IsActive,CreatedByUserID)
                            values (@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,
                            @ExpirationDate,@IsActive,@CreatedByUserID)
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID",IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static bool UpdateInternationalLicenseInfo( int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
                        DateTime IssueDate, DateTime ExpirationDate, bool IsActive,
                        int CreatedByUserID)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update InternationalLicenses
                            set
                            ApplicationID = @ApplicationID,
                            DriverID = @DriverID,
                            IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                            IssueDate = @IssueDate,
                            ExpirationDate = @ExpirationDate,
                            IsActive = @IsActive,
                            CreatedByUserID = @CreatedByUserID
                            where InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select InternationalLicenseID,ApplicationID,DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive
                            from InternationalLicenses;";

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

        public static DataTable GetAllInternationalLicensesToDriver(int DriverID)
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select InternationalLicenseID,ApplicationID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive
                             from InternationalLicenses where DriverID = @DriverID
                             order by IsActive Desc,ExpirationDate Desc;";

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

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select Top 1 InternaionalLicenseID
                             from InternationalLicenses 
                             where DriverID = @DriverID and GetDate() between IssueDate and ExpirationDate
                             order by ExpirationDate desc";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connect.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedData))
                {
                    InternationalLicenseID = InsertedData;
                }
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connect.Close();
            }
            return InternationalLicenseID;
        }

    }
}
