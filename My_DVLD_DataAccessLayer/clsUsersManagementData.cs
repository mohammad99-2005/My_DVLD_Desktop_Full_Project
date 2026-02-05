using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsUsersManagementData
    {

        public static bool FindByUserID(int UserID,ref int PersonID,ref string Username,ref string Password,ref bool IsActive)
        {
            bool Exist = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand (query,connect);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = int.Parse(reader["PersonID"].ToString());
                    Username = reader["Username"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                    Exist = true;
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
            return Exist;
        }

        public static bool FindByPersonID(ref int UserID, int PersonID, ref string Username, ref string Password, ref bool IsActive)
        {
            bool Exist = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Users where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    UserID = int.Parse(reader["UserID"].ToString());
                    Username = reader["Username"].ToString();
                    Password = reader["Password"].ToString();
                    IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                    Exist = true;
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
            return Exist;
        }

        public static bool FindByUsernameAndPassword(ref int UserID, ref int PersonID, string Username, string Password, ref bool IsActive)
        {
            bool Exist = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from Users where UserName = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@UserName", Username);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = int.Parse(reader["PersonID"].ToString());
                    UserID = int.Parse(reader["UserID"].ToString());
                    IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                    Exist = true;
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
            return Exist;
        }


        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive)
        {
            int AddedUserID = -1;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Insert into Users (PersonID,UserName,Password,IsActive)
                            values(@PersonID,@Username,@Password,@IsActive);
                            select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query,connect);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connect.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int InsertedID))
                {
                    AddedUserID = InsertedID;
                }


            }
            catch (Exception ex)
            {

            }
            finally 
            { 
                connect.Close(); 
            }
            return AddedUserID;
        }


        public static bool UpdateUserInfo(int UserID, string Username, string Password, bool IsActive)
        {
            bool Updated = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"Update Users
                                set UserName = @Username,
                                    Password = @Password,
                                    IsActive = @IsActive
                                    where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connect.Open();
                int rowAffected = command.ExecuteNonQuery();

                if(rowAffected > 0)
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

        public static bool DeleteUser(int UserID)
        {

            bool Deleted = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "Delete from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connect.Open();
                int rowAffected = command.ExecuteNonQuery();
                if(rowAffected > 0)
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

        public static bool IsUserExist(int UserID)
        {

            bool Exist = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from Users where @UserID = UserID";

            SqlCommand command = new SqlCommand(query,connect);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Exist = true;
                }

            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }

            return Exist;

        }

        public static bool IsUserExistForPersonID(int PersonID)
        {

            bool Exist = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from Users where @PersonID = PersonID";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Exist = true;
                }

            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }

            return Exist;

        }


        public static bool IsUserExist(string Username)
        {

            bool Exist = false;
            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from Users where @Username = Username";

            SqlCommand command = new SqlCommand(query, connect);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Exist = true;
                }

            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }

            return Exist;

        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connect = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select UserID,People.PersonID,
		                     (FirstName +' '+ SecondName +' '+ ThirdName +' '+ LastName) as FullName,
		                     UserName,IsActive
		                     from Users join People on Users.PersonID = People.PersonID;";

            SqlCommand command = new SqlCommand(query,connect);

            try
            {
                connect.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally { connect.Close(); }

            return dt;
        }


    }
}
