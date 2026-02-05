using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsLocalDrivingLicenseApplicationBusinuse : clsApplicationBussinuse
    {
        enum enMode { enUpdate =0 , enAddNew =1}
        enMode mode = enMode.enUpdate;

        public int LDLAppID {  get; set; }
        public int LicenseCLassID { get; set; }

        public clsLicenseClassesBussinuse clsLicenseClass;

        public string PersonFUllName { 
            get
            {
                return clsPeopleManagmentBusinuse.Find(ApplicationPersonID).FullName;
            }
        }

        public clsLocalDrivingLicenseApplicationBusinuse()
        {
            LDLAppID = -1;
            LicenseCLassID = -1;

            mode = enMode.enAddNew;
        }

        private clsLocalDrivingLicenseApplicationBusinuse(int LDLAppID,int ApplicationID,int AppPersonID,
            int AppType,enApplicationStatus AppStatusID,DateTime AppDate,
            DateTime LastStatusDate,int PaidFees,int CreatedByUserID,int LiceseClassID)
        {
            this.LDLAppID = LDLAppID;
            this.ApplicationID = ApplicationID;
            ApplicationPersonID= AppPersonID;
            Person = clsPeopleManagmentBusinuse.Find(AppPersonID);
            ApplicationTypeID = AppType;
            ApplicationTypeInfo = clsApplicationTypesBusinuse.Find(ApplicationTypeID);
            ApplicationStatus= AppStatusID;
            ApplicationDate = AppDate;
            this.LastStatusDate = LastStatusDate;
            this.CreatedByUserID = CreatedByUserID;
            CreatedByUserInfo = clsUsersManagemetsBussiness.Find(CreatedByUserID);
            this.PaidFees = PaidFees;
            this.LicenseCLassID = LiceseClassID;
            this.clsLicenseClass = clsLicenseClassesBussinuse.Find(LiceseClassID);

            mode = enMode.enUpdate;
            
        }

        public static clsLocalDrivingLicenseApplicationBusinuse FindByLocalDrivingLicenseApplicationID(int  LDLAppID)
        {
            int ApplicationID = -1;
            int LiceseClassID = -1;

            if(clsLocalDrivingLicenseApplicationsData.GetLDLAppByID(LDLAppID,ref ApplicationID,ref LiceseClassID))
            {
                clsApplicationBussinuse Application = clsApplicationBussinuse.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplicationBusinuse(LDLAppID,ApplicationID,Application.ApplicationPersonID,
                    Application.ApplicationTypeID,Application.ApplicationStatus,
                    Application.ApplicationDate,Application.LastStatusDate,Application.PaidFees,
                    Application.CreatedByUserID,LiceseClassID);
            }
            else
            {
                return null;
            }
            
        }

        public static clsLocalDrivingLicenseApplicationBusinuse FindByApplicationID(int AppID)
        {
            int LDLAppID = -1;
            int LiceseClassID = -1;

            if (clsLocalDrivingLicenseApplicationsData.GetLDLAppByApplicationID(ref LDLAppID, AppID, ref LiceseClassID))
            {
                clsApplicationBussinuse Application = clsApplicationBussinuse.FindBaseApplication(AppID);

                return new clsLocalDrivingLicenseApplicationBusinuse(LDLAppID, AppID, Application.ApplicationPersonID,
                    Application.ApplicationTypeID, Application.ApplicationStatus,
                    Application.ApplicationDate, Application.LastStatusDate, Application.PaidFees,
                    Application.CreatedByUserID, LiceseClassID);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewLDLApp()
        {
            this.LDLAppID = clsLocalDrivingLicenseApplicationsData.AddNewLocalDrivingLicenseApplication(ApplicationID, LicenseCLassID);

            return this.LDLAppID != -1;
        }

        private bool _UpdateLDLApp()
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateLocalDrivingLicenseApplication(LDLAppID,ApplicationID,LicenseCLassID);
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsData.GetAllLocalDrivingLicenseApplications();
        }

        public bool DeleteLocalDrivingLicenseApplication()
        {
            bool DoesLDLAppDeleted = clsLocalDrivingLicenseApplicationsData.DeleteLDLApplication(this.LDLAppID);
            bool DoesBaseApplicationDeleted = false;

            if (!DoesLDLAppDeleted)
                return false;

            DoesBaseApplicationDeleted = base.DeleteApplication();
            return DoesBaseApplicationDeleted;
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID,clsTestTypeBussinuse.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationsData.DoesPassTestType(LocalDrivingLicenseApplicationID,(int)TestType);
        }

        public bool DoesPassTestType(clsTestTypeBussinuse.enTestType TestType)
        {
            return clsLocalDrivingLicenseApplicationsData.DoesPassTestType(this.LDLAppID, (int)TestType);
        }

        public bool DoesPassPreviousTest(clsTestTypeBussinuse.enTestType TestType)
        {
            switch (TestType)
            {
                case clsTestTypeBussinuse.enTestType.VisionTest:
                    return true;

                case clsTestTypeBussinuse.enTestType.WrittenTest:
                    return DoesPassTestType(this.LDLAppID, clsTestTypeBussinuse.enTestType.VisionTest);

                case clsTestTypeBussinuse.enTestType.StreetTest:
                    return DoesPassTestType(this.LDLAppID, clsTestTypeBussinuse.enTestType.WrittenTest);

                default:
                    return false;
            }
        }


        public bool DoesAttendTestType(clsTestTypeBussinuse.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.DoesAttedTestType(this.LDLAppID, (int)TestTypeID);
        }

        public static int TotalTrialsPerTest(int LocalDrivingLicenseApplicationID,clsTestTypeBussinuse.enTestType TestTypeID)//testAppointment
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public int TotalTrialsPerTest(clsTestTypeBussinuse.enTestType TestTypeID)//testAppointment
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(this.LDLAppID, (int)TestTypeID);
        }


        public  bool AttendedTest( clsTestTypeBussinuse.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(this.LDLAppID, (int)TestTypeID) > 0;
        }
        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, clsTestTypeBussinuse.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }
       
        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestTypeBussinuse.enTestType TestTypeID)// testAppointment
        {
            return clsLocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID,(int)TestTypeID);
        }

        public  bool IsThereAnActiveScheduledTest(clsTestTypeBussinuse.enTestType TestTypeID)// testAppointment
        {
            return clsLocalDrivingLicenseApplicationsData.IsThereAnActiveScheduledTest(this.LDLAppID, (int)TestTypeID);
        }

        public clsTestsBussiness GetLastTestPerTestType(clsTestTypeBussinuse.enTestType _TestType)
        {
            return clsTestsBussiness.FindLastTestByPersonAndTestTypeIDAndLicenseClassID(Person.PersonID, (int)_TestType, LicenseCLassID);
        }

        public static int GetPassedTestCount(int LocalDrivingLicenseApplicationID)//Tests // DONE
        {
            return clsTestsBussiness.GetNumOfPassedTests(LocalDrivingLicenseApplicationID);
        }

        public int GetPassedTestCount()//Tests // DONE
        {
            return clsTestsBussiness.GetNumOfPassedTests(this.LDLAppID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            return clsTestsBussiness.PassedAllTests(LocalDrivingLicenseApplicationID);
        }

        public bool PassedAllTests()
        {
            return clsTestsBussiness.PassedAllTests(this.LDLAppID);
        }

        public int IssueLicenseForTheFirstTime(string Notes, int CreatedByUserID)
        {
            clsDriversBussiness Driver = clsDriversBussiness.FindDriverByPersonID(this.Person.PersonID);
            int DriverID = -1;

            if (Driver == null)
            {
                Driver = new clsDriversBussiness();

                Driver.PersonID = this.Person.PersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;

                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = Driver.DriverID;
            }

            clsLicensesBussinese License = new clsLicensesBussinese();
            License.ApplicationID = this.ApplicationID;
            License.DriverID = DriverID;
            License.LicenseCLassID = this.LicenseCLassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears((int)clsLicenseClassesBussinuse.Find(this.LicenseCLassID).DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = this.clsLicenseClass.ClassFees;
            License.IsActive = true;
            License.IssueReason = clsLicensesBussinese.enIssueReason.FirstTime;
            License.CreatedByUserID = CreatedByUserID;

            if (License.Save())
            {
                this.SetComplete();
                return License.LicenseID;
            }
            else
            {
                return -1;
            }
        }

        public bool IsLicenseIssued()
        {
            return GetActiveLicenseID() != -1;
        }

        public int GetActiveLicenseID()
        {
            return clsLicensesBussinese.GetLicenseIDByPersonID(this.Person.PersonID, this.LicenseCLassID);
        }

        public bool Save()
        {
            // take care about this details
            base.mode = (clsApplicationBussinuse.enMode)this.mode;
            if (!SaveApplication())
            {
                return false;
            }

            switch (mode)
            {
                case enMode.enAddNew:
                    if (_AddNewLDLApp())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateLDLApp();

                default: return false;
            }

        }
    }
}
