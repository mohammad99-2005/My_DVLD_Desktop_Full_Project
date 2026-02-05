using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_BussinessLayer;

namespace My_DVLD_DataAccessLayer
{
    public class clsDetainLicensesBussinuse
    {
        enum enMode { enUpdate = 0, enAddNew = 1 }
        enMode mode = enMode.enAddNew;
        public int DetainID {  get; set; }
        public int LicenseID {  get; set; }
        public clsLicensesBussinese LicenseInfo { get; set; }
        public DateTime DetainDate { get; set; }
        public int FineFees { get; set; }
        public int CreatedByUserID {  get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleasedApplicationID { get; set; }
        public clsApplicationBussinuse ApplicationInfo { get; set; }
        

        
        public clsDetainLicensesBussinuse()
        {
            DetainID = -1;
            LicenseID = -1;
            DetainDate = DateTime.Now;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleasedDate = DateTime.Now;
            ReleasedByUserID = -1;
            ReleasedApplicationID = -1;

            mode = enMode.enAddNew;
        }

        private clsDetainLicensesBussinuse(int DetainID,int LicenseID,DateTime DetainDate,int FineFees,int CreatedByUserID,
                                   bool IsReleased,DateTime ReleasedDate,int ReleasedByUserID,int ReleasedApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            //this.LicenseInfo = clsLicensesBussinese.FindLicense(LicenseID);
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleasedDate = ReleasedDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleasedApplicationID = ReleasedApplicationID;
            this.ApplicationInfo = clsApplicationBussinuse.FindBaseApplication(ReleasedApplicationID);

            mode = enMode.enUpdate;
        }

        public static clsDetainLicensesBussinuse FindDetainedLicenseByDetainID(int DetainID)
        {
            int LicenseID = -1;     DateTime DetainDate = DateTime.Now;
            int FineFees = -1;      int CreatedByUserID = -1;       bool IsReleased = false;
            DateTime ReleasedDate = DateTime.Now;        int ReleasedByUserID = -1;      int ReleasedApplicationID = -1;

            bool Finded = clsDetainLicensesData.FindDetainedLicenseByDetainID(DetainID,ref LicenseID,ref DetainDate,ref FineFees,
                                ref CreatedByUserID,ref IsReleased,ref ReleasedDate,ref ReleasedByUserID,ref ReleasedApplicationID);

            if (Finded == true)
            {
                return new clsDetainLicensesBussinuse(DetainID,LicenseID, DetainDate,FineFees,CreatedByUserID,
                    IsReleased, ReleasedDate,ReleasedByUserID,ReleasedApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static clsDetainLicensesBussinuse FindDetainedLicenseByLicenseID(int LicenseID)
        {
            int DetainID = -1; DateTime DetainDate = DateTime.Now;
            int FineFees = -1; int CreatedByUserID = -1; bool IsReleased = false;
            DateTime ReleasedDate = DateTime.Now; int ReleasedByUserID = -1; int ReleasedApplicationID = -1;

            bool Finded = clsDetainLicensesData.GetDetainedLicenseByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees,
                                ref CreatedByUserID, ref IsReleased, ref ReleasedDate, ref ReleasedByUserID, ref ReleasedApplicationID);

            if (Finded == true)
            {
                return new clsDetainLicensesBussinuse(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID,
                    IsReleased, ReleasedDate, ReleasedByUserID, ReleasedApplicationID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewDetainLicense()
        {
            this.DetainID = clsDetainLicensesData.AddNewDetainLicense(this.LicenseID,this.DetainDate,this.FineFees,this.CreatedByUserID);
            
            if(this.DetainID == -1)
                return false;
            return true;
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainLicensesData.UpdateDetainedLicense(this.DetainID,
                this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
        }

        public bool ReleasLicense(int ReleasedByUserID,int ApplicationID)
        { 
            return clsDetainLicensesData.ReleaseLicense(this.DetainID, ReleasedByUserID, ApplicationID);
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainLicensesData.IsDetained(LicenseID);
        }

        public bool IsLicenseDetained()
        {
            return clsDetainLicensesData.IsDetained(this.LicenseID);
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainLicensesData.GetAllDetainedLicenses();
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.enAddNew:
                    if (_AddNewDetainLicense())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateDetainedLicense();
                default:
                    return false;
            }
        }

        

    }
}
