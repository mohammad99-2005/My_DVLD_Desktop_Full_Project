using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsAppointmentTestsData
    {

        public static bool FindAppointmentTestByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID,
                                                    ref DateTime AppointmentDate, ref int PaidFees, ref int CreatedByUserID,
                                                    ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from TestAppointments where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString());
                    PaidFees = Convert.ToInt32(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                        RetakeTestApplicationID = Convert.ToInt32(reader["RetakeTestApplicationID"]);

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

        public static bool FindLastAppointmentTestByID(int LDLAppID,int TestTypeID,ref int TestAppointmentID,
                                                    ref DateTime AppointmentDate, ref int PaidFees, ref int CreatedByUserID,
                                                    ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"
                            select top 1 * from TestAppointments
                            where LocalDrivingLicenseApplicationID=2 and TestTypeID = 2
                            order by TestAppointmentID desc;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]);
                    AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString());
                    PaidFees = Convert.ToInt32(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                        RetakeTestApplicationID = Convert.ToInt32(reader["RetakeTestApplicationID"]);

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

        public static int AddNewAppointmentTest(int TestTypeID, int LocalDrivingLicenseApplicationID,
                                                    DateTime AppointmentDate, int PaidFees, int CreatedByUserID,
                                                    bool IsLocked, int RetakeTestApplicationID)
        {
            int NewAppointmentTestID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);
            string query = "insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID) " +
                           "values (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID); " +
                           "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == -1)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            try
                {
                    connect.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int AddAppointmentID))
                    {
                        NewAppointmentTestID = AddAppointmentID;
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connect.Close();
                }
            return NewAppointmentTestID;
        }

        public static bool UpdateAppointment(int TestAppointmentID, DateTime AppointmentDate,int TestTypeID,
            int LocalDrivingLicenseApplicationID, int PaidFees, int CreatedByUserID, int RetakeTestApplicationID,
            bool IsLocked = false)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            // if it have to edit like to Update just the AppointmentDate did it.
            string query = @"Update  TestAppointments  
                            set TestTypeID = @TestTypeID,
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                AppointmentDate = @AppointmentDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsLocked=@IsLocked,
                                RetakeTestApplicationID=@RetakeTestApplicationID
                                where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID == -1)

                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);


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


        

        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select Tests.TestID from Tests where TestAppointmentID=@TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestID = Convert.ToInt32(reader["TestID"]);
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
            return TestID;

        }


        public static bool IsLocked(int TestAppointmentID)//check
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from TestAppointments where TestAppointmentID = @TestAppointmentID and IsLocked = 1;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
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

        

        
        public static DataTable GetApplicationTestAppointmentsPerTestType(int LDLAppID,byte TestType)
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select TestAppointmentID, AppointmentDate,PaidFees, IsLocked
                             from TestAppointments
                             where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             and
                             TestTypeID=@TestTypeID
                             order by TestAppointmentID desc;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestType);
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

        public static DataTable GetAllTestAppointments()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from TestAppointments_View order by AppointmentDate Desc;";

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




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






        public static int GetNumOfTrials(int LDLAppID, byte TestTypeID)//LDLApp
        {
            int NumOfTrials = 0;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select COUNT(TestAppointmentID) as NumOfTrials from TestAppointments where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    NumOfTrials = Convert.ToInt32(reader["NumOfTrials"]);
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
            return NumOfTrials;

        }






        public static bool IsThereActiveAppointmentForThisApplication(int LocalDrivingLicenseApplicationID, byte TestTypeID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select x=1 from TestAppointments where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID
                                and IsLocked = 0 and TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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


        public static bool DeleteAppointment(int TestAppointmentID)
        {

            bool Deleted = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Delete from TestAppointments where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connect);


            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connect.Open();

                int AffectedRow = command.ExecuteNonQuery();
                Deleted = AffectedRow > 0;

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return Deleted;
        }


        public static bool DeleteAppointmentsByLocalDrivingLicenseID(int LDLAppID)
        {
            bool Deleted = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Delete from TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);

            try
            {
                connect.Open();

                int AffectedRow = command.ExecuteNonQuery();
                Deleted = AffectedRow > 0;

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return Deleted;
        }


        public static bool IsExist(int TestAppointmentID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from TestAppointments where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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
