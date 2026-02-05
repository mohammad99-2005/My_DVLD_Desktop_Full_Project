using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_DataAccessLayer;
using static System.Net.Mime.MediaTypeNames;
using static My_DVLD_BussinessLayer.clsLicensesBussinese;

namespace My_DVLD_BussinessLayer
{
    public class clsLicensesBussinese
    {

        public enum enIssueReason {FirstTime = 1,Renew = 2,ReplacementForDamaged = 3,ReplacementForLost = 4 }

        enum enMode { enUpdate = 0, enAddNew = 1, }
        enMode mode = enMode.enUpdate;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplicationBussinuse ApplicationInfo;
        public int DriverID { get; set; }
        public clsDriversBussiness DriverInfo;
        public int LicenseCLassID { get; set; }
        public clsLicenseClassesBussinuse LicenseCLassInfo;
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public int PaidFees { get; set; }
        public bool IsActive { get; set; }
        public clsDetainLicensesBussinuse DetainedLicense { get; set; }

        public string IssueReasonText
        {
            get { return GetIssueReasonText(IssueReason); }
        }

        public bool IsDetained
        {
            get { return clsDetainLicensesBussinuse.IsLicenseDetained(LicenseID); }
        }

        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUsersManagemetsBussiness CreatedByUser;


        public clsLicensesBussinese()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseCLassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = enIssueReason.FirstTime;
            this.CreatedByUserID = -1;

            mode = enMode.enAddNew;
        }

        private clsLicensesBussinese(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
                        DateTime IssueDate, DateTime ExpirationDate, string Notes, int PaidFees, bool IsActive,
                        enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplicationBussinuse.FindBaseApplication(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriversBussiness.FindDriver(DriverID);
            this.LicenseCLassID = LicenseClass;
            this.LicenseCLassInfo = clsLicenseClassesBussinuse.Find(LicenseClass);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUsersManagemetsBussiness.Find(CreatedByUserID);
            this.DetainedLicense = clsDetainLicensesBussinuse.FindDetainedLicenseByLicenseID(LicenseID);

            mode = enMode.enUpdate;
        }

        public static clsLicensesBussinese FindLicense(int LicenseID)
        {
            int ApplicationID = -1; int DriverID =-1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = ""; int PaidFees = -1; bool IsActive = false;
            byte IssueReason = 0; int CreatedByUserID = -1;

            if (clsLicensesData.FindByLicenseID(LicenseID,ref ApplicationID, ref DriverID, ref LicenseClass,
                                ref IssueDate, ref ExpirationDate,ref Notes,ref PaidFees,
                                ref IsActive,ref IssueReason,ref CreatedByUserID))
            {
                return new clsLicensesBussinese(LicenseID,ApplicationID,DriverID,LicenseClass,IssueDate,ExpirationDate,
                                Notes,PaidFees,IsActive,(enIssueReason)IssueReason,CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static clsLicensesBussinese FindLicenseByApplicationIDandLicenseClass(int ApplicationID,int LicenseClass)
        {
            int LicenseID = -1; int DriverID = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = ""; int PaidFees = -1; bool IsActive = false;
            byte IssueReason = 0; int CreatedByUserID = -1;

            if (clsLicensesData.FindLicenseByApplicationIDandLicenseClass(ref LicenseID,  ApplicationID, ref DriverID,  LicenseClass,
                                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees,
                                ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicensesBussinese(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,
                                Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool DoesHasThisLicense(int ApplicationID, int LicenseClass)
        {
            return clsLicensesData.DoesHasThisLicense(ApplicationID, LicenseClass);
        }

        public static DataTable GetAllLicenses()
        {
            return clsLicensesData.GetAllLicenses();
        }

        public static DataTable GetLicensesToDriver(int DriverID)
        {
            return clsLicensesData.GetAllLicensesToDriver(DriverID);
        }

        private bool _AddNewLicense()
        {
            this.LicenseID =  (clsLicensesData.AddNewLicense(ApplicationID,DriverID,LicenseCLassID,IssueDate,ExpirationDate,
                                Notes,PaidFees,IsActive,(byte)IssueReason,CreatedByUserID));

            return LicenseID != -1;
        }

        private bool _UpdateLicenseInfo()
        {
            return clsLicensesData.UpdateLicenseInfo(LicenseID, ApplicationID, DriverID, LicenseCLassID, IssueDate, ExpirationDate,
                                Notes, PaidFees, IsActive,(byte)IssueReason, CreatedByUserID);
        }

        public static bool IsLicenseExistByPersonID(int PersonID,int LicenseClassID)
        {
            return clsLicensesBussinese.GetLicenseIDByPersonID(PersonID, LicenseClassID) != -1;
        }

        public static int GetLicenseIDByPersonID(int PersonID,int LicenseClassID)
        {
            return clsLicensesData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }

        public static bool IsExist(int LicenseID)
        {
            return clsLicensesData.IsExist(LicenseID);
        }

        public bool IsLicenseExpired()
        {
            return (this.ExpirationDate < DateTime.Now);
        }

        public bool DeactivateCurrentLicense()
        {
            return clsLicensesData.DeactivateLicense(LicenseID);
        }

        public static string GetIssueReasonText(enIssueReason issueReason)
        {
            switch (issueReason)
            {
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.ReplacementForLost:
                    return "Replacement for Lost";
                case enIssueReason.ReplacementForDamaged:
                    return "Replacement for Damaged";
                case enIssueReason.FirstTime:
                    return "First Time";
                default:
                    return "First Time";
            }
        }


        public int Detain(int FineFees,int CreatedByUserID)
        {
            clsDetainLicensesBussinuse DetainLicense = new clsDetainLicensesBussinuse();

            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.CreatedByUserID = CreatedByUserID;
            DetainLicense.FineFees = FineFees;
            DetainLicense.LicenseID = this.LicenseID;

            if (!DetainLicense.Save())
            {
                return -1;
            }
            return DetainLicense.LicenseID;
        }


        public bool ReleaseDetainedLicense(int ReleasedByUserID, ref int ApplicationID)
        {

            clsApplicationBussinuse Application = new clsApplicationBussinuse();

            Application.ApplicationPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplicationBussinuse.enApplicationType.ReleaseDetainedDrivingLicsense;
            Application.ApplicationStatus = clsApplicationBussinuse.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationTypesBusinuse.Find((int)clsApplicationBussinuse.enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationTypeFees;
            Application.CreatedByUserID = ReleasedByUserID;

            if (!Application.SaveApplication())
            {
                ApplicationID = -1;
                return false;
            }

            ApplicationID = Application.ApplicationID;

            return this.DetainedLicense.ReleasLicense(ReleasedByUserID, ApplicationID);
        }


        public clsLicensesBussinese RenewLicense(int CreatedByUserID)
        {

            clsApplicationBussinuse application = new clsApplicationBussinuse();

            application.ApplicationPersonID = this.DriverInfo.PersonID;
            application.ApplicationStatus = clsApplicationBussinuse.enApplicationStatus.New;
            application.ApplicationDate = DateTime.Now;
            application.CreatedByUserID = CreatedByUserID;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationTypeID = (int)clsApplicationBussinuse.enApplicationType.RenewDrivingLicense;


            application.PaidFees = clsApplicationTypesBusinuse.Find(application.ApplicationTypeID).ApplicationTypeFees;


            if (!application.SaveApplication())
            {
                return null;
            }

            clsLicensesBussinese NewLicense = new clsLicensesBussinese();

            NewLicense.DriverID = this.DriverID;
            NewLicense.ApplicationID = application.ApplicationID;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.LicenseCLassID = this.LicenseCLassID;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClassesBussinuse.Find(this.LicenseCLassID).DefaultValidityLength);
            NewLicense.IsActive = true;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.IssueReason = clsLicensesBussinese.enIssueReason.Renew;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = this.LicenseCLassInfo.ClassFees;

            if (!NewLicense.Save())
            {
                return null;
            }

            this.DeactivateCurrentLicense();

            return NewLicense;
        }


        public clsLicensesBussinese ReplaceLicense(clsLicensesBussinese.enIssueReason issueReason,int CreatedByUserID)
        {
            clsApplicationBussinuse application = new clsApplicationBussinuse();

            application.ApplicationPersonID = this.DriverInfo.PersonID;
            application.ApplicationStatus = clsApplicationBussinuse.enApplicationStatus.New;
            application.ApplicationDate = DateTime.Now;
            application.CreatedByUserID = CreatedByUserID;
            application.LastStatusDate = DateTime.Now;

            if (issueReason == enIssueReason.ReplacementForLost)
            {
                application.ApplicationTypeID = ((int)clsApplicationBussinuse.enApplicationType.ReplaceLostDrivingLicense);
            }

            if(issueReason == enIssueReason.ReplacementForDamaged)
            {
                application.ApplicationTypeID = ((int)clsApplicationBussinuse.enApplicationType.ReplaceDamagedDrivingLicense);
            }
            
            application.PaidFees = clsApplicationTypesBusinuse.Find(
                (int)clsApplicationBussinuse.enApplicationType.ReplaceDamagedDrivingLicense).ApplicationTypeFees;

            if (!application.SaveApplication())
            {
                return null;
            }

            clsLicensesBussinese NewLicense = new clsLicensesBussinese();

            NewLicense.DriverID = this.DriverID;
            NewLicense.ApplicationID = application.ApplicationID;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.LicenseCLassID = this.LicenseCLassID;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClassesBussinuse.Find(this.LicenseCLassID).DefaultValidityLength);
            NewLicense.IsActive = true;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.IssueReason = issueReason;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = 0;

            if (!NewLicense.Save())
            {
                return null;
            }

            this.DeactivateCurrentLicense();

            return NewLicense;

        }








        public bool Save()
        {
            switch (mode)
            {
                case enMode.enAddNew:
                    if (_AddNewLicense())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateLicenseInfo();
                default: return false;
            }
        }
    }
}
