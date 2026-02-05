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
    public class clsLocalDrivingLicenseApplicationsData
    {

        public static bool GetLDLAppByID(int LDLAppID,ref int ApplicationID,ref int LicenseClassID)
        {
			bool finded =false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select 
							 ApplicationID,
							 LicenseClassID 
                             from LocalDrivingLicenseApplications
							 where LocalDrivingLicenseApplicationID = @LDLAppID";
			
			SqlCommand command = new SqlCommand(query, connect);

			command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            
			try
			{
				connect.Open();

				SqlDataReader reader = command.ExecuteReader();

				if(reader.Read())
				{
					ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
					LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);

					finded = true;
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
			return finded;
        }


		public static bool GetLDLAppByApplicationID(ref int LDLAppID, int ApplicationID, ref int LicenseClassID)
		{
			bool finded =false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select LocalDrivingLicenseApplicationID,
							 LicenseClassID from LocalDrivingLicenseApplications
							 where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LDLAppID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);

                    finded = true;
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
            return finded;
        }

		public static int AddNewLocalDrivingLicenseApplication(int ApplicationID,int LicenseClassID)
		{
			int Added = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

			string query = @"insert into LocalDrivingLicenseApplications(ApplicationID,LicenseClassID)
								values(@ApplicationID,@LicenseClassID)
								select SCOPE_IDENTITY();";
			
			SqlCommand command = new SqlCommand(query,connect);

			command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
			command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

			try
			{
				connect.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int LDLAppID))
				{
                    Added = LDLAppID;
                }
				 
			}
			catch (Exception ex)
			{

			}
			finally { connect.Close(); }

			return Added;
        }


        


        public static bool UpdateLocalDrivingLicenseApplication(int LDLAppID,int ApplicationID, int LicenseClassID)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update LocalDrivingLicenseApplications
							set	ApplicationID = @ApplicationID,
								LicenseClassID = @LicenseClassID
							where LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
			command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connect.Open();

                int AffectedRows = command.ExecuteNonQuery();

				if(AffectedRows > 0)
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



        public static DataTable GetAllLocalDrivingLicenseApplications()
        {

            DataTable dt = new DataTable();

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,LicenseClasses.ClassName,People.NationalNo,
									people.FirstName + ' ' +People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName as FullName,
									Applications.ApplicationDate,
										sum (case when Tests.TestResult = 1 then 1 else 0 End) as PassedTests,
											   case 
												when Applications.ApplicationStatus=1 then 'New'
												when Applications.ApplicationStatus=2 then 'Canceled'
												when Applications.ApplicationStatus=3 then 'Completed'
												End as ApplicationStatus
								from LocalDrivingLicenseApplications 
								left outer join Applications on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
								left outer join LicenseClasses on LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
								left outer join People on Applications.ApplicantPersonID = People.PersonID
								left outer join TestAppointments on TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
								left outer join Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
								group by
								LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
								LicenseClasses.ClassName,
								People.NationalNo,
								People.FirstName,People.SecondName,People.ThirdName,People.LastName,
								Applications.ApplicationDate,
								Applications.ApplicationStatus;";// Finally done .....


            //thout about it in this way.......^^^^^^
            //Local Driving License ApplicationID 
            //TestTypeID
            //Test AppointmentID
            //TestID
            //TestResult
            //ApplicationID
            // Count function in Database ### DONT FORGET !!


            SqlCommand command = new SqlCommand(query, connect);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally { connect.Close(); }
            return dt;
        }


        public static bool DeleteLDLApplication(int LDLAppID)
        {
            bool Deleted = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"delete from
                             LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LDLAppID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

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

        public static bool DoesPassTestType(int LocalDrivingLicenesApplicationID,int TestTypeID)
        {

            bool Passed = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select x=1 from  LocalDrivingLicenseApplications
                                join
                                TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                                join
                                Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID
                                and 
                                TestAppointments.TestTypeID = @TestTypeID
                                and
                                Tests.TestResult =1;";

            SqlCommand command = new SqlCommand(@query, connect);

            command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenesApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Passed = true;
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
            return Passed;


        }


        public static bool DoesAttedTestType(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            bool Attended = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            //INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID.
            //tryed without useing this line ^^^^ Important to check it
            string query = @"select x=1 from LocalDrivingLicenseApplications
                            join 
                            TestAppointments on TestAppointments.LocalDrivingLicenseApplicationID=LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                            JOIN
                            Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LDLAppID
                            and
                            TestAppointments.TestTypeID=@TestTypeID;";

            SqlCommand command = new SqlCommand(@query, connect);

            command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connect.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    Attended = true;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connect.Close();
            }

            return Attended;
        }


        public static int TotalTrialsPerTest(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            int NumOfTrials = 0;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select COUNT(Tests.TestID) as NumOfTrials
                            from LocalDrivingLicenseApplications
                            join
                            TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=TestAppointments.LocalDrivingLicenseApplicationID
                            join
                            Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                            and
                            TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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


        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            bool Finded = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select x=1 from LocalDrivingLicenseApplications
                            join
                            TestAppointments on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentID
                            join 
                            Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
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



















        //      public static bool IsExist(int AppPersonID,int ApplicationStatus,string ClassName)
        //{
        //          bool Exist = false;
        //          SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

        //	string query = @"select x=1 
        //						from 
        //						LocalDrivingLicenseApplications
        //						join Applications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
        //						join LicenseClasses on LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
        //						where
        //						Applications.ApplicantPersonID =  @ApplicationPersonID
        //						and 
        //						Applications.ApplicationStatus = @ApplicationStatus
        //						and 
        //						LicenseClasses.ClassName = @ClassName ;";


        //          SqlCommand command = new SqlCommand(query, connect);

        //	command.Parameters.AddWithValue("@ApplicationPersonID", AppPersonID);
        //          command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
        //          command.Parameters.AddWithValue("@ClassName", ClassName);

        //          try
        //          {
        //              connect.Open();

        //              SqlDataReader reader = command.ExecuteReader();

        //              if (reader.Read())
        //              {
        //                  Exist = true;
        //              }
        //              reader.Close();

        //          }
        //          catch (Exception ex)
        //          {

        //          }
        //          finally
        //          {
        //              connect.Close();
        //          }
        //          return Exist;
        //      }



        //     public static bool UpdateLocalDrivingLicenseApplication(int LDLAppID,int ApplicationID, int LicenseClassID)
        //     {
        //bool Updated = false;
        //         SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

        //         string query = @"Update LocalDrivingLicenseApplications
        //					set ApplicationID = @ApplicationID
        //						LicenseClassID = @LicenseClassID
        //						where LocalDrivingLicenseApplicationID = @LDLAppID;";

        //         SqlCommand command = new SqlCommand(query, connect);

        //command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
        //         command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        //         command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

        //         try
        //         {
        //             connect.Open();

        //	int AffectedRows = command.ExecuteNonQuery();

        //	Updated = AffectedRows > 0;

        //         }
        //         catch (Exception ex)
        //         {

        //         }
        //         finally { connect.Close(); }

        //         return Updated;
        //     }








    }
}
