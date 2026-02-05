using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DVLD_DataAccessLayer
{
    public class clsPeopleManagmentData
    {


        public static bool FindPersonByID(int PerID ,ref string NationNo , ref string FName, ref string SName, ref string ThName, ref string LName, ref DateTime DOB ,
        ref bool gendor , ref string Address , ref string Phone , ref string Email , ref int NCID , ref string Photo )
        {
            bool Finded = false;
            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from People where @PerID=PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PerID", PerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    NationNo = reader["NationalNo"].ToString();
                    FName = reader["FirstName"].ToString();
                    SName = reader["SecondName"].ToString();
                    ThName = reader["ThirdName"].ToString();
                    LName = reader["LastName"].ToString();
                    DOB = DateTime.Parse(reader["DateOfBirth"].ToString());
                    gendor = (reader["Gendor"].ToString() == "0" ? false : true);
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();

                    if (reader["Email"] != null)
                    {
                        Email = reader["Email"].ToString();
                    }
                    else
                    {
                        Email = "";
                    }

                    NCID = int.Parse(reader["NationalityCountryID"].ToString());

                    if (reader["ImagePath"]  != null)
                    {
                        Photo = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        Photo = "";
                    }
                    Finded = true;
                }
                
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }

            return Finded;
        }


        public static bool FindPersonByNationalNo(ref int PerID, string NationNo, ref string FName, ref string SName, ref string ThName, ref string LName, ref DateTime DOB,
        ref bool gendor, ref string Address, ref string Phone, ref string Email, ref int NCID, ref string Photo)
        {
            bool Finded = false;
            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select * from People where @NationNo=NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationNo", NationNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    PerID = Convert.ToInt32(reader["PersonID"].ToString());
                    FName = reader["FirstName"].ToString();
                    SName = reader["SecondName"].ToString();
                    ThName = reader["ThirdName"].ToString();
                    LName = reader["LastName"].ToString();
                    DOB = DateTime.Parse(reader["DateOfBirth"].ToString());
                    gendor = (reader["Gendor"].ToString() == "0" ? false : true);
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();

                    if (reader["Email"] != null)
                    {
                        Email = reader["Email"].ToString();
                    }
                    else
                    {
                        Email = "";
                    }

                    NCID = int.Parse(reader["NationalityCountryID"].ToString());

                    if (reader["ImagePath"] != null)
                    {
                        Photo = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        Photo = "";
                    }
                }
                Finded = true;
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }

            return Finded;
        }



        public static int AddNewPerson(string NationNo,  string FName,  string SName,  string ThName,  string LName,  DateTime DOB,
                     bool gendor,  string Address,  string Phone,  string Email,  int NCID,  string Photo)
        {
            int AddedPersonID = -1;

            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"insert into People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)
                                values (@NationNo,@FName,@SName,@ThName,@LName,@DOB,@gendor,@Address,@Phone,@Email,@NCID,@Photo);
                             select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationNo", NationNo);
            command.Parameters.AddWithValue("@FName", FName);
            command.Parameters.AddWithValue("@SName", SName);
            command.Parameters.AddWithValue("@ThName", ThName);
            command.Parameters.AddWithValue("@LName", LName);
            command.Parameters.AddWithValue("@DOB", DOB);
            command.Parameters.AddWithValue("@gendor", gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            command.Parameters.AddWithValue("@NCID", NCID);
            if (Photo != null)
            {
                command.Parameters.AddWithValue("@Photo", Photo);
            }
            else
            {
                command.Parameters.AddWithValue("@Photo", DBNull.Value);
            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID)) 
                {
                    AddedPersonID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return AddedPersonID;
        }


        public static bool UpdatePerson(int PerID, string NationNo, string FName, string SName, string ThName, string LName, DateTime DOB,
                     bool gendor, string Address, string Phone, string Email, int NCID, string Photo)
        {
            bool Updated = false;

            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            // DVLD.People.
            string query = @"UPDATE People
                         set NationalNo=@NationNo,
                             FirstName=@FName,
                             SecondName=@SName,
                             ThirdName=@ThName,
                             LastName=@LName,
                             DateOfBirth=@DOB,
                             Gendor=@gendor,
                             Address=@Address,
                             Phone=@Phone,
                             Email=@Email,
                             NationalityCountryID=@NCID,
                             ImagePath=@Photo
                             where @PerID=PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationNo", NationNo);
            command.Parameters.AddWithValue("@FName", FName);
            command.Parameters.AddWithValue("@PerID", PerID);
            command.Parameters.AddWithValue("@SName", SName);
            command.Parameters.AddWithValue("@ThName", ThName);
            command.Parameters.AddWithValue("@LName", LName);
            command.Parameters.AddWithValue("@DOB", DOB);
            command.Parameters.AddWithValue("@gendor", gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            if (Email != null)
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }

            command.Parameters.AddWithValue("@NCID", NCID);
            if (Photo != null)
            {
                command.Parameters.AddWithValue("@Photo", Photo);
            }
            else
            {
                command.Parameters.AddWithValue("@Photo", DBNull.Value);
            }

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Updated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return Updated;
        }


        public static bool IsPersonExistByID(int PerID)
        {

            bool IsExist = false;
            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from People where @PerID=PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PerID", PerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsExist;

        }


        public static bool IsPersonExistByNationalNo(string NationalNo)
        {

            bool IsExist = false;
            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = "select x=1 from People where @NationalNo=NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsExist;

        }


        public static bool DeletePerson(int PerID)
        {
            bool Deleted = false;

            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            // DVLD.People.
            string query = @"Delete from People where @PerID=PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PerID", PerID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Deleted = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return Deleted;
        }


        public static DataTable GetAllPeople()
        {
            
            SqlConnection connection = new SqlConnection(clsGetDataAccessFromDatabase.DbConnectionStringBuilder);

            string query = @"select People.PersonID,People.FirstName,People.SecondName,People.ThirdName,People.LastName,
                People.NationalNo,People.Gendor,
                CASE
                when People.Gendor = 0 then 'Male'
                else 'Female'
                end as GendorCaption ,
                People.DateOfBirth,
                People.Email,People.Phone,People.Address,People.NationalityCountryID,Countries.CountryName,People.ImagePath
                from People join Countries on People.NationalityCountryID = Countries.CountryID
                order by People.FirstName;";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable datatable = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    datatable.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }






    }
}
