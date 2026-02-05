using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsUsersManagemetsBussiness
    {

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveCaption {  get; set; }

        public clsPeopleManagmentBusinuse PersonInfo;

        enum enMode { enUpdate = 0, enAddNew = 1 }
        enMode mode = enMode.enUpdate;

        private clsUsersManagemetsBussiness(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.IsActiveCaption = IsActive ? "Yes" : "No";
            PersonInfo = clsPeopleManagmentBusinuse.Find(PersonID);
            mode = enMode.enUpdate;
        }

        public clsUsersManagemetsBussiness()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
            //this.IsActiveCaption = "";
            mode = enMode.enAddNew;
        }

        public static clsUsersManagemetsBussiness Find(int UserID)
        {

            int PersonID = -1; string Username = ""; string Password = ""; bool IsActive = false;

            if (clsUsersManagementData.FindByUserID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                return new clsUsersManagemetsBussiness(UserID, PersonID, Username, Password, IsActive);
            }
            return null;

        }


        public static clsUsersManagemetsBussiness FindByUsernameAndPassword(string Username,string Password)
        {

            int PersonID = -1; int UserID = -1; bool IsActive = false;

            if (clsUsersManagementData.FindByUsernameAndPassword(ref UserID, ref PersonID, Username, Password, ref IsActive))
            {
                return new clsUsersManagemetsBussiness(UserID, PersonID, Username, Password, IsActive);
            }
            return null;

        }


        public static clsUsersManagemetsBussiness FindByPersonID(int PersonID)
        {

            string Username = ""; int UserID = -1; string Password = ""; bool IsActive = false;

            if (clsUsersManagementData.FindByPersonID(ref UserID, PersonID,ref Username, ref Password, ref IsActive))
            {
                return new clsUsersManagemetsBussiness(UserID, PersonID, Username, Password, IsActive);
            }
            return null;

        }

        private bool _AddNewUser()
        {
            this.UserID = clsUsersManagementData.AddNewUser(PersonID, Username, Password, IsActive);

            if ( UserID!= -1)
            {
                return true;
            }
            return false;
        }


        private bool _UpdateUser()
        {
            if (clsUsersManagementData.UpdateUserInfo(UserID, Username, Password, IsActive))
            {
                return true;
            }
            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return (clsUsersManagementData.DeleteUser(UserID));
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersManagementData.GetAllUsers();
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.enAddNew:
                    if (_AddNewUser()) 
                    { 
                        mode = enMode.enUpdate;
                        return true;
                    }
                    return false;
                case enMode.enUpdate:
                    return _UpdateUser();
                default:
                    return false;
            }
        }


        public static bool IsUserExist(int UserID)
        {
            return clsUsersManagementData.IsUserExist(UserID);
        }

        public static bool IsUserExist(string Username)
        {
            return clsUsersManagementData.IsUserExist(Username);
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUsersManagementData.IsUserExist(PersonID);
        }










    }
}
