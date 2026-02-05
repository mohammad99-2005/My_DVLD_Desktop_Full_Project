using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsInternationalLicensesBussinuss : clsApplicationBussinuse
    {
        enum enMode { enUpdate = 0, enAddnew = 1 }
        enMode mode = enMode.enUpdate;

        public int InternationalLicenseID {  get; set; }
        public int DriverID { get; set; }
        public clsDriversBussiness DriverInfo { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }



        public clsInternationalLicensesBussinuss()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;

            mode = enMode.enAddnew;
        }

        public clsInternationalLicensesBussinuss(int ApplicationID,int applicationPersonID,DateTime ApplicationDate,
            enApplicationStatus applicationStatus,DateTime LastStatusDate,int paidFees,
            int InternationalLicenseID,int DriverID,
            int IssuedUsingLocalLicenseID,DateTime IssueDate,DateTime ExpirationDate,
            bool IsActive,int CreatedByUserID)
        {
            
            base.ApplicationID = ApplicationID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationStatus = applicationStatus;
            base.LastStatusDate = LastStatusDate;
            base.ApplicationPersonID = applicationPersonID;
            base.ApplicationTypeID = (int)clsApplicationBussinuse.enApplicationType.NewInternationalLicense;
            base.CreatedByUserID = CreatedByUserID;

            this.InternationalLicenseID = InternationalLicenseID;
            this.DriverID = DriverID;
            this.DriverInfo = clsDriversBussiness.FindDriver(DriverID);
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            mode = enMode.enUpdate;
        }

        public static clsInternationalLicensesBussinuss FindInternationalLicenseByID(int InternationalLicenseID)
        {
            int ApplicationID = -1;int DriverID = -1;int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false; int CreatedByUserID = -1;

            bool Finded = clsInternationalLicensesData.FindIntLicenseByIntLicenseID(InternationalLicenseID,ref ApplicationID,
                ref DriverID,ref IssuedUsingLocalLicenseID,ref IssueDate,ref ExpirationDate,ref IsActive,ref CreatedByUserID);

            

            if (Finded)
            {
                clsApplicationBussinuse Application = clsApplicationBussinuse.FindBaseApplication(ApplicationID);

                return new clsInternationalLicensesBussinuss(Application.ApplicationID,Application.ApplicationPersonID,
                    Application.ApplicationDate,Application.ApplicationStatus,Application.LastStatusDate,
                    Application.PaidFees,InternationalLicenseID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static clsInternationalLicensesBussinuss FindInternationalLicenseByLocalLicenseID(int IssuedUsingLocalLicenseID)
        {
            int ApplicationID = -1; int DriverID = -1; int InternationalLicenseID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            bool IsActive = false; int CreatedByUserID = -1;

            bool Finded = clsInternationalLicensesData.FindIntLicenseByLocalLicenseID(IssuedUsingLocalLicenseID,ref InternationalLicenseID, ref ApplicationID,
                ref DriverID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);
            clsApplicationBussinuse Application = clsApplicationBussinuse.FindBaseApplication(ApplicationID);

            if (Finded)
            {
                return new clsInternationalLicensesBussinuss(Application.ApplicationID, Application.ApplicationPersonID,
                    Application.ApplicationDate, Application.ApplicationStatus, Application.LastStatusDate,
                    Application.PaidFees, InternationalLicenseID, DriverID,
                    IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewInternatinalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicensesData.AddNewInternationalLicense(InternationalLicenseID,
                ApplicationID, DriverID,IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive, CreatedByUserID);

            return this.InternationalLicenseID != -1;
        }

        private bool _UpdateInternatinalLicense()
        {
            return clsInternationalLicensesData.UpdateInternationalLicenseInfo(InternationalLicenseID,ApplicationID,DriverID,
                IssuedUsingLocalLicenseID,IssueDate,ExpirationDate,IsActive,CreatedByUserID);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesData.GetAllInternationalLicenses();
        }

        public bool Save()
        {
            base.mode = (clsApplicationBussinuse.enMode)this.mode;
            if (!base.SaveApplication())
            {
                return false;
            }

            switch (mode)
            {
                case enMode.enAddnew:
                    if (_AddNewInternatinalLicense())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else {  return false; }
                case enMode.enUpdate:
                    return _UpdateInternatinalLicense();
                default:
                    return false;
            }
        }

        public static DataTable GetInternationalLicesesToDriver(int DriverID)
        {
            return clsInternationalLicensesData.GetAllInternationalLicensesToDriver(DriverID);
        }

        public static int GetTheActiveInternationalLicenseToDriverID(int DriverID)
        {
            return clsInternationalLicensesData.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }
    }
}
