using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsDriversBussiness
    {
        enum enMode { enUpdate = 0, enAddNew = 1, }
        enMode mode = enMode.enUpdate;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPeopleManagmentBusinuse Person;
        public int CreatedByUserID { get; set; }
        public clsUsersManagemetsBussiness CreatedByUser;
        public DateTime CreatedDate { get; set; }

        public clsDriversBussiness()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;

            mode = enMode.enAddNew;
        }

        private clsDriversBussiness(int DriverID, int PersonID, DateTime CreatedDate, int CreatedByUserID)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.Person = clsPeopleManagmentBusinuse.Find(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUsersManagemetsBussiness.Find(CreatedByUserID);
            this.CreatedDate = CreatedDate;

            mode = enMode.enUpdate;
        }

        public static clsDriversBussiness FindDriver(int DriverID)
        {
            int PersonID = -1; DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1;

            if (clsDriversData.FindByDriverID(DriverID, ref PersonID, ref CreatedDate, ref CreatedByUserID))
            {
                return new clsDriversBussiness(DriverID, PersonID, CreatedDate, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static clsDriversBussiness FindDriverByPersonID(int PersonID)
        {

            int DriverID = -1; DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1;

            if (clsDriversData.FindByPersonID(ref DriverID, PersonID, ref CreatedDate, ref CreatedByUserID))
            {
                return new clsDriversBussiness(DriverID, PersonID, CreatedDate, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }

        public static DataTable GetAllDrivers()
        {
            return clsDriversData.GetAllDrivers();
        }

        public static DataTable GetAllDriversWithPersonalInfo()
        {
            return clsDriversData.GetAllDriversWithPersonalInfo();
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDriversData.AddNewDriver(PersonID, CreatedDate, CreatedByUserID);
            return (this.DriverID > -1);
        }

        private bool _UpdateDriverInfo()
        {
            return clsDriversData.UpdateDriverInfo(DriverID,PersonID,CreatedByUserID);
        }

        public static bool IsExist(int DriverID)
        {
            return clsDriversData.IsExist(DriverID);
        }

        // tow functions should be here  // 2-)GetInternationalLicenses
        //Here....


        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicensesBussinese.GetLicensesToDriver(DriverID);
        }


        public bool Save()
        {
            switch (mode)
            {
                case enMode.enAddNew:
                    if (_AddNewDriver())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateDriverInfo();
                default: return false;
            }
        }
    }
}
