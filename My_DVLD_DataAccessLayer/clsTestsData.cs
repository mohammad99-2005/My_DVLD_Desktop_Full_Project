using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsTestsData
    {

        public static bool FindByTestID(int TestID, ref int TestAppointmentID, ref bool TestResult,ref string Notes,
                                        ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Tests where TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                    {
                        Notes = "";
                    }
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


        public static bool FindLastTestByPersonAndTestTypeIDAndLicenseClassID(int PersonID,int TestTypeID,int LicenseClassID,ref int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes,
                                        ref int CreatedByUserID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select top 1 Tests.TestID,Tests.TestAppointmentID,Tests.TestResult,Tests.Notes,Tests.CreatedByUserID from 
                             Tests 
                             join TestAppointments on TestAppointments.TestAppointmentID=Tests.TestAppointmentID
                             join LocalDrivingLicenseApplications on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=TestAppointments.LocalDrivingLicenseApplicationID
                             join Applications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             where LocalDrivingLicenseApplications.LicenseClassID=@LicenseClassID and Applications.ApplicantPersonID =@PersonID and TestAppointments.TestTypeID=@TestTypeID
                             Order by Tests.TestID Desc;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TestID = (int)reader["TestID"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    if (reader["Notes"] != DBNull.Value)
                        Notes = (string)reader["Notes"];
                    else
                    {
                        Notes = "";
                    }
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


        public static int AddNewTest(int TestAppointmentID,bool TestResult,string Notes,int CreatedByUserID)
        {
            int NewTestID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);
            string query = @"insert into Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                           values (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)

                           Update TestAppointments
                           set IsLocked = 1 where TestAppointmentID = @TestAppointmentID;

                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes.Trim() == "")
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connect.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int AddedTestID))
                {
                    NewTestID = AddedTestID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return NewTestID;
        }

        public static bool UpdateTest(int TestID,int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            // if it have to edit like to Update just the AppointmentDate did it.
            string query = @"Update Tests
                            set TestAppointmentID = @TestAppointmentID,
                                TestResult =@TestResult,
                                Notes = @Notes,
                                CreatedByUserID = @CreatedByUserID,
                                where TestID = @TestID; ";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes.Trim() == "")
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else 
                command.Parameters.AddWithValue("@Notes", Notes);
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

        public static bool DeleteTest(int TestID)
        {
            bool Deleted = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Delete from Tests where TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connect);


            command.Parameters.AddWithValue("@TestID", TestID);

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


        public static bool DeleteByAppointmentID(int AppointmentID)
        {
            bool Deleted = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Delete from Tests where AppointmentID = @AppointmentID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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


        public static DataTable GetAllTests()
        {
            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Tests order by TestID;";

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

        public static bool IsExist(int TestID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from Tests where TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@TestID", TestID);

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


        public static int GetPassedTestCount(int LDLAppID)
        {
            int PassedTests = 0;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select PassedTestCount = count(TestTypeID)
		                     from Tests join
		                     TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
		                     where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestResult=1;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLAppID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PassedTests = Convert.ToInt32(reader["PassedTestCount"]);
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
            return PassedTests;

        }
    }
}
