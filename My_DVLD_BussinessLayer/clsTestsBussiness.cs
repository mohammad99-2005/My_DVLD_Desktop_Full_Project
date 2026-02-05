using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_BussinessLayer
{
    public class clsTestsBussiness
    {
        enum enMode { enUpdate = 0, enAddNew = 1, }
        enMode mode = enMode.enUpdate;

        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public clsAppointmentTestsBussiness TestAppointmentInfo;
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUsersManagemetsBussiness CreatedByUser;

        public clsTestsBussiness()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;

            mode = enMode.enAddNew;
        }

        private clsTestsBussiness(int TestID,int TestAppointmentID,bool TestResult,string Notes,int CreatedByUserID)
        {
            this.TestID=TestID;
            this.TestAppointmentID=TestAppointmentID;
            this.TestAppointmentInfo = clsAppointmentTestsBussiness.FindAppointment(TestAppointmentID);
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUsersManagemetsBussiness.Find(CreatedByUserID);

            mode = enMode.enUpdate;
        }

        public static clsTestsBussiness FindTestByTestID(int TestID)
        {
            int TestAppointmentID = -1;    bool TestResult = false;    
            int CreatedByUserID = -1;      string Notes = "";

            if (clsTestsData.FindByTestID(TestID,ref TestAppointmentID,ref TestResult,ref Notes,ref CreatedByUserID))
            {
                return new clsTestsBussiness(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }
        
        public static clsTestsBussiness FindLastTestByPersonAndTestTypeIDAndLicenseClassID(int PersonID, int TestTypeID, int LicenseClassID)
        {
            int TestID = -1;
            int TestAppointmentID = -1; bool TestResult = false;
            int CreatedByUserID = -1; string Notes = "";

            if (clsTestsData.FindLastTestByPersonAndTestTypeIDAndLicenseClassID(PersonID,TestTypeID,LicenseClassID,ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTestsBussiness(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllTests()
        {
            return clsTestsData.GetAllTests();
        }
        
        private bool _AddNewTest()
        {
            return (clsTestsData.AddNewTest(TestAppointmentID,TestResult,Notes,CreatedByUserID)>-1);
        }

        private bool _UpdateTest()
        {
            return clsTestsData.UpdateTest(TestID,TestAppointmentID,TestResult,Notes,CreatedByUserID);
        }

        public static int GetNumOfPassedTests(int LDLAppID)
        {
            return clsTestsData.GetPassedTestCount(LDLAppID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            return (GetNumOfPassedTests(LocalDrivingLicenseApplicationID) == 3);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.enAddNew:
                    if (_AddNewTest())
                    {
                        mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateTest();
                    break;
                default : return false;
            }   
        }
    }
}
