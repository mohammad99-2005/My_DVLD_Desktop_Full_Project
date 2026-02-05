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
    public class clsApplicationBussinuse
    {

        public enum enMode { enUpdate = 0, enAddNew = 1 }
        public enMode mode = enMode.enUpdate;

        public enum enApplicationType {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }

        public int ApplicationID { get; set; }
        public int ApplicationPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationTypesBusinuse ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { get; set; }

        public string TextStatus
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }
        public DateTime LastStatusDate { get; set; }
        public int PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUsersManagemetsBussiness CreatedByUserInfo;

        public clsPeopleManagmentBusinuse Person;
        
        public clsApplicationBussinuse()
        {
            ApplicationID = -1;

            ApplicationPersonID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = -1;
            
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = -1;
            CreatedByUserID = -1;

            mode = enMode.enAddNew;
        }

        private clsApplicationBussinuse(int applicationID, int applicationPersonID,
                                        DateTime applicationDate,int applicationTypeID,
                                        enApplicationStatus applicationStatus,DateTime LastStatusDate,int PaidFees,int CreatedByUserID)
        {
            this.ApplicationID = applicationID;
            this.ApplicationPersonID = applicationPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeInfo = clsApplicationTypesBusinuse.Find(ApplicationTypeID);
            this.ApplicationStatus = (enApplicationStatus)applicationStatus;//here 
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUsersManagemetsBussiness.Find(CreatedByUserID);
            this.Person = clsPeopleManagmentBusinuse.Find(applicationPersonID);
            this.ApplicationTypeInfo = clsApplicationTypesBusinuse.Find(this.ApplicationTypeID);
        }

        public static clsApplicationBussinuse FindBaseApplication(int ApplicationID)
        {
            int applicationPersonID = -1 ; DateTime applicationDate = DateTime.Now; int applicationTypeID = -1;
            int applicationStatus = -1; DateTime LastStatusDate = DateTime.Now; int PaidFees = -1;
            int CreatedByUserID = -1;

            if(clsApplicationsData.GetApplicationInfoByID(ApplicationID,ref applicationPersonID, ref applicationDate,
               ref applicationTypeID, ref applicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplicationBussinuse(ApplicationID,applicationPersonID,applicationDate,applicationTypeID,
                    (enApplicationStatus)applicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool IsExixt(int ApplicationID,int ApplicationTypeID,int ApplicationStatus=1)
        {
            return clsApplicationsData.IsApplicationExist(ApplicationID);
        }

        public bool DeleteApplication()
        {
            return clsApplicationsData.DeleteApplication(this.ApplicationID);
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationsData.GetAllApplications();
        }

        private bool _AddNewApplication()
        {
            
            this.ApplicationID =  clsApplicationsData.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID,
                                    (int)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return ApplicationID > 0;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationsData.UpdateApplication(this.ApplicationID,this.ApplicationPersonID,
                                                   this.ApplicationDate,this.ApplicationTypeID,(int)this.ApplicationStatus,
                                                   this.LastStatusDate, this.PaidFees,this.CreatedByUserID);
        }

        public bool Cancel()
        {
            return clsApplicationsData.UpdateStatus(this.ApplicationID, 2);
        }

        public bool SetComplete()
        {
            return clsApplicationsData.UpdateStatus(this.ApplicationID, 3);
        }

        public static bool DoesPersonHasActiveApplication(int AppPersonID,int AppTypeID)
        {
            return clsApplicationsData.DoesPersonHasActiveApplication(AppPersonID, AppTypeID);
        }

        public bool DoesPersonHasActiveApplication(int AppTypeID)
        {
            return clsApplicationsData.DoesPersonHasActiveApplication(this.ApplicationPersonID, AppTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int AppPersonID,enApplicationType AppTypeID,int LicenseClassID)
        {
            return clsApplicationsData.GetActiveApplicationIDForLicenseClass(AppPersonID, (int)AppTypeID, LicenseClassID);
        }

        public static int GetActiveApplicationID(int PersonID,clsApplicationBussinuse.enApplicationType AppTypeID)
        {
            return clsApplicationsData.GetActiveApplicationID(PersonID,(int)AppTypeID);
        }

        public int GetActiveApplicationID(clsApplicationBussinuse.enApplicationType AppTypeID)
        {
            return clsApplicationsData.GetActiveApplicationID(this.ApplicationPersonID,(int) AppTypeID);
        }

        public bool SaveApplication()
        {
            switch (mode)
            {
                case enMode.enAddNew: 
                    if (_AddNewApplication())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate: 
                    if(_UpdateApplication())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default: return false;
            }
        }



    }
}
