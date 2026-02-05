using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsLicenseClassesData
    {

        public static bool FindBy_LicenseClassID(int LicenseClassID, ref string ClassName, ref string ClassDescription,
                                                    ref int MinimumAllowedAge,ref int DefaultValidityLength,ref int ClassFees)
        {
            bool finded = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select 
							 ClassName,
							 ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees
                             from LicenseClasses
							 where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ClassName = (reader["ClassName"]).ToString();
                    ClassDescription = (reader["ClassDescription"]).ToString();
                    MinimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToInt32(reader["ClassFees"]);

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

        public static bool FindBy_ClassName(ref int LicenseClassID, string ClassName, ref string ClassDescription,
                                                    ref int MinimumAllowedAge, ref int DefaultValidityLength, ref int ClassFees)
        {
            bool finded = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select 
							 LicenseClassID,
							 ClassDescription,MinimumAllowedAge,DefaultValidityLength,ClassFees
                             from LicenseClasses
							 where ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LicenseClassID = Convert.ToInt32((reader["LicenseClassID"]).ToString());
                    ClassDescription = (reader["ClassDescription"]).ToString();
                    MinimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToInt32(reader["ClassFees"]);

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

        public static DataTable GetAllLicenseClasses()
        {

            DataTable datatable = new DataTable();
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from LicenseClasses;";

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


        public static bool UpdateLicenseClasses( int LicenseClassID, string ClassName, string ClassDescription,
                                                     int MinimumAllowedAge, int DefaultValidityLength, int ClassFees)
        {

            bool Updated = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update LicenseClasses
                            set ClassName = @ClassName
                                ClassDescription = @ClassDescription
                                MinimumAllowedAge = @MinimumAllowedAge
                                DefaultValidityLength = @DefaultValidityLength
                                ClassFees = @ClassFees
                            where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

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

        public static bool DeleteLicenseClass(int LicenseClassID)
        {
            bool Deleted = false;

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "Delete from LicenseClasses where LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

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

        public static int AddNewLicenseClass( string ClassName, string ClassDescription,
                                                     int MinimumAllowedAge, int DefaultValidityLength, int ClassFees)
        {

            int AddNew = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"insert into LicenseClasses (ClassName,ClassDescription,
                                MinimumAllowedAge,DefaultValidityLength,ClassFees)

                                values(@ClassName,@ClassDescription,@MinimumAllowedAge
                                @DefaultValidityLength,@ClassFees)
                                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);

            try
            {
                connect.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    AddNew = InsertedID;
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
    }
}
