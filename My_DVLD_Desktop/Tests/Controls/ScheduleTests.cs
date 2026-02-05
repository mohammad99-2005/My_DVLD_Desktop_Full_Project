using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using My_DVLD_Desktop.Global;
using My_DVLD_Desktop.Properties;

namespace My_DVLD_Desktop.Applications.LocalDrivingLicenseApplications.SchedualTest.Controls
{
    public partial class ScheduleTests : UserControl
    {

        enum enMode { enUpdate = 0, enAddNew = 1 };
        enMode mode = enMode.enAddNew;

        enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 };
        enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private clsTestTypeBussinuse.enTestType _TestTypeID = clsTestTypeBussinuse.enTestType.VisionTest;

        private clsLocalDrivingLicenseApplicationBusinuse _LDLApp;
        int _LDLAppID = -1;
        private clsAppointmentTestsBussiness _AppointmentTest;
        int _AppointmentTestID = -1;

        public clsTestTypeBussinuse.enTestType TestType
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {
                    case clsTestTypeBussinuse.enTestType.VisionTest:
                        pictureBox1.Image = Resources.Vision_512;
                        lblTitle.Text = "Vision Test";
                        break;
                    case clsTestTypeBussinuse.enTestType.WrittenTest:
                        pictureBox1.Image = Resources.Written_Test_512;
                        lblTitle.Text = "Written Test";
                        break;
                    case clsTestTypeBussinuse.enTestType.StreetTest:
                        pictureBox1.Image = Resources.Street_Test_32;
                        lblTitle.Text = "Street Test";
                        break;
                }
            }
        }

        public void LoadInfo(int LocalDrivingLicenseApplicationID,int AppointmentID=-1)
        {

            if (AppointmentID == -1)
            {
                mode = enMode.enAddNew;
            }
            else
            {
                mode = enMode.enUpdate;
            }

            _LDLApp = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            _LDLAppID = LocalDrivingLicenseApplicationID;
            _AppointmentTestID = AppointmentID;

            if(_LDLApp == null)
            {
                MessageBox.Show("There is no Local Driving License Application with [ID] ("+
                    LocalDrivingLicenseApplicationID+")","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                return;
            }

            if (_LDLApp.DoesAttendTestType(_TestTypeID))
            {
                _CreationMode = enCreationMode.RetakeTestSchedule;
            }
            else
            {
                _CreationMode = enCreationMode.FirstTimeSchedule;
            }


            if(_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                gbRetakeTestInfo.Enabled = true;
                lblRTestFees.Text = clsApplicationTypesBusinuse.Find((int)clsApplicationBussinuse.enApplicationType.RetakeTest).ApplicationTypeFees.ToString();
                lblTitle.Text = "Schedule Retake Test";
                lblRTestAppID.Text = "N/A";
            }
            else
            {
                gbRetakeTestInfo.Enabled = false;
                lblRTestAppID.Text = "N/A";
                lblTitle.Text = "Schedule Test";
                lblRTestFees.Text = "0";
            }

            lblLDLAppID.Text = _LDLAppID.ToString();
            lblD_Class.Text = _LDLApp.clsLicenseClass.ClassName.ToString();
            lblName.Text = _LDLApp.PersonFUllName.ToString();
            lblTrial.Text = _LDLApp.TotalTrialsPerTest(_TestTypeID).ToString();
            lblFees.Text = clsTestTypeBussinuse.Find(_TestTypeID).TestTypeFees.ToString();

            if (mode == enMode.enAddNew)
            {
                
                dtpAppointmentDate.MinDate = DateTime.Now;
                lblRTestAppID.Text = "N/A";//written it up

                _AppointmentTest = new clsAppointmentTestsBussiness();
            }
            else
            {
                if (!_LoadRetakeTestAppointmentData())
                    return;
            }

            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRTestFees.Text)).ToString();

            if (!_HandleActiveTestAppointmentConstraint()) return;

            if(!_HandleAppointmentLockedConstraint()) return;

            if(!_HandlePreviousTestConstraint()) return;

        }

        bool _LoadRetakeTestAppointmentData()
        {
            _AppointmentTest = clsAppointmentTestsBussiness.FindAppointment(_AppointmentTestID);

            if (_AppointmentTest == null)
            {
                MessageBox.Show("Error in Appointment ID = (" +
                    _AppointmentTestID + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            if (DateTime.Compare(DateTime.Now, _AppointmentTest.AppointmentDate) < 0)
            {
                dtpAppointmentDate.MinDate = DateTime.Now;
            }
            else
            {
                dtpAppointmentDate.MinDate = _AppointmentTest.AppointmentDate;
            }

            if (_AppointmentTest.RetakeTestApplicationID == -1)
            {
                lblRTestAppID.Text = "N/A";
                lblRTestFees.Text = "0";
            }
            else
            {
                gbRetakeTestInfo.Enabled = true;
                lblRTestAppID.Text = _AppointmentTest.RetakeTestApplicationID.ToString();
                lblRTestFees.Text = _AppointmentTest.RetakeTestApplicationInfo.PaidFees.ToString();
                lblTitle.Text = "Scheduled Retake Test";
            }
            return true;
        }


        private bool _HandleActiveTestAppointmentConstraint()
        {
            if(mode == enMode.enAddNew && clsAppointmentTestsBussiness.IsThereActiveAppointmentForThisApplication(_LDLAppID, (byte)_TestTypeID))
            {
                lblWarning.Visible = true;
                lblWarning.Text = "Person Already has Active Appointment for this Test";
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                return false;
            }
            else
                lblWarning.Visible = false;

            return true;
        }

        private bool _HandleAppointmentLockedConstraint()
        {
            if (_AppointmentTest.IsLocked == true)
            {
                lblWarning.Visible = true;
                lblWarning.Text = "Person already sat for the test, appointment loacked.";
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                return false;
            }
            else
                lblWarning.Visible = false;

            return true;
        }

        private bool _HandlePreviousTestConstraint()
        {

            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (_TestTypeID)
            {
                case clsTestTypeBussinuse.enTestType.VisionTest:
                    lblWarning.Visible = false;
                    return true;

                case clsTestTypeBussinuse.enTestType.WrittenTest:

                    if (!clsLocalDrivingLicenseApplicationBusinuse.DoesPassTestType(_LDLAppID, clsTestTypeBussinuse.enTestType.VisionTest))
                    {
                        lblWarning.Visible = true;
                        lblWarning.Text = "Cannot Sechule, Vision Test should be passed first";
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblWarning.Visible = false;
                        btnSave.Enabled = true;
                        dtpAppointmentDate.Enabled = true;
                        return true;
                    }
                        
                case clsTestTypeBussinuse.enTestType.StreetTest:

                    if (!clsLocalDrivingLicenseApplicationBusinuse.DoesPassTestType(_LDLAppID, clsTestTypeBussinuse.enTestType.WrittenTest))
                    {

                        lblWarning.Visible = true;
                        lblWarning.Text = "Cannot Sechule, Written Test should be passed first";
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblWarning.Visible = false;
                        btnSave.Enabled = true;
                        dtpAppointmentDate.Enabled = true;
                        return true;
                    }
            }   
            return true;
        }


        private bool _HandleRetakeApplication()
        {
            if(mode == enMode.enAddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                clsApplicationBussinuse RetakeTestApplication = new clsApplicationBussinuse();

                RetakeTestApplication.ApplicationStatus = clsApplicationBussinuse.enApplicationStatus.New;
                RetakeTestApplication.ApplicationPersonID = _LDLApp.Person.PersonID;
                RetakeTestApplication.ApplicationDate = DateTime.Now;
                RetakeTestApplication.CreatedByUserID = clsGlobal.clsCurrUser.UserID;
                RetakeTestApplication.LastStatusDate = DateTime.Now;
                RetakeTestApplication.ApplicationTypeID = (int)clsApplicationBussinuse.enApplicationType.RetakeTest;
                RetakeTestApplication.PaidFees = clsApplicationTypesBusinuse.Find((int)clsApplicationBussinuse.enApplicationType.RetakeTest).ApplicationTypeFees;

                if (!RetakeTestApplication.SaveApplication())
                {
                    _AppointmentTest.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public ScheduleTests()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
            {
                return;
            }

            _AppointmentTest.LocalDrivingLicenseApplicationID = _LDLAppID;
            _AppointmentTest.AppointmentDate = DateTime.Parse(dtpAppointmentDate.Text);
            _AppointmentTest.CreatedByUserID = clsGlobal.clsCurrUser.UserID;
            _AppointmentTest.PaidFees = Convert.ToInt32(lblFees.Text);
            _AppointmentTest.TestTypeID = (int)_TestTypeID;

            if (_AppointmentTest.Save())
            {
                mode = enMode.enUpdate;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
