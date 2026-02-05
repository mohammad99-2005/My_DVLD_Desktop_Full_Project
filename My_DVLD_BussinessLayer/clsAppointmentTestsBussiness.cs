using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsAppointmentTestsBussiness
    {


        enum enMode { enUpdate =0 , enAddNew = 1,}
        enMode mode = enMode.enUpdate;

        public int TestAppointmentID {  get; set; }
        public int TestTypeID { get; set; }
        public clsTestTypeBussinuse TestTypeInfo;
        public int LocalDrivingLicenseApplicationID { get; set; }
        public clsLocalDrivingLicenseApplicationBusinuse LDLAppInfo;
        public DateTime AppointmentDate { get; set; }
        public int PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUsersManagemetsBussiness CurrentUser;
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set;}
        public clsApplicationBussinuse RetakeTestApplicationInfo { get; set; }
        
        public int TestID
        {
            get { return _GetTestID(); }
        }
        public clsAppointmentTestsBussiness()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            mode = enMode.enAddNew;
        }

        private clsAppointmentTestsBussiness(int TestAppointmentID,int TestTypeID, int LocalDrivingLicenseApplicationID,
                                                    DateTime AppointmentDate, int PaidFees, int CreatedByUserID,
                                                    bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.TestTypeInfo = clsTestTypeBussinuse.Find((clsTestTypeBussinuse.enTestType)TestTypeID);
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LDLAppInfo = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CurrentUser = clsUsersManagemetsBussiness.Find(CreatedByUserID);
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            RetakeTestApplicationInfo = clsApplicationBussinuse.FindBaseApplication(RetakeTestApplicationID);
            mode = enMode.enUpdate;
        }

        public static clsAppointmentTestsBussiness FindAppointment(int AppointmentTestID)
        {

            int TestTypeID=-1; int LocalDrivingLicenseApplicationID=-1;
            DateTime AppointmentDate=DateTime.Now; int PaidFees=0; int CreatedByUserID=-1;
            bool IsLocked=false; int RetakeTestApplicationID=-1;

            if (clsAppointmentTestsData.FindAppointmentTestByID(AppointmentTestID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
                            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsAppointmentTestsBussiness(AppointmentTestID,TestTypeID, LocalDrivingLicenseApplicationID,
                                        AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static clsAppointmentTestsBussiness GetLastTestAppointment(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {

            int AppointmentTestID = -1;
            DateTime AppointmentDate = DateTime.Now; int PaidFees = 0; int CreatedByUserID = -1;
            bool IsLocked = false; int RetakeTestApplicationID = -1;

            if (clsAppointmentTestsData.FindLastAppointmentTestByID(LocalDrivingLicenseApplicationID,TestTypeID, ref AppointmentTestID,
                            ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsAppointmentTestsBussiness(AppointmentTestID, TestTypeID, LocalDrivingLicenseApplicationID,
                                        AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
            {
                return null;
            }
        }


        public int GetTestID(int AppointmentTestID)
        {
            return clsAppointmentTestsData.GetTestID(AppointmentTestID);
        }

        private int _GetTestID()
        {
            return clsAppointmentTestsData.GetTestID(this.TestAppointmentID);
        }

        public static DataTable GetAllAppointmentTests()
        {
            return clsAppointmentTestsData.GetAllTestAppointments();
        }

        

        private bool _AddNewAppointment()
        {

            TestAppointmentID = clsAppointmentTestsData.AddNewAppointmentTest(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate,
                                    PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID);

            return this.TestAppointmentID != -1;
        }

        private bool _UpdateAppointment()
        {
            return clsAppointmentTestsData.UpdateAppointment(TestAppointmentID, AppointmentDate,TestTypeID,
                LocalDrivingLicenseApplicationID,PaidFees,CreatedByUserID,RetakeTestApplicationID,IsLocked);
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LDLAppID,byte TestTypeID)
        {
            return clsAppointmentTestsData.GetApplicationTestAppointmentsPerTestType(LDLAppID,TestTypeID);
        }
        
        public static bool IsThereActiveAppointmentForThisApplication(int LDLAppID,byte TestTypeID)
        {
            return clsAppointmentTestsData.IsThereActiveAppointmentForThisApplication(LDLAppID,TestTypeID);
        }

        public static int NumOfTrials(int LDLAppID,byte TestTypeID)//LDLApp
        {
            return clsAppointmentTestsData.GetNumOfTrials(LDLAppID,TestTypeID);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.enAddNew:
                    if (_AddNewAppointment())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateAppointment();
                default: return false;
            }
        }
    }
}
