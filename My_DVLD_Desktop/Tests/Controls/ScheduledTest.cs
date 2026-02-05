using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using My_DVLD_Desktop.Properties;

namespace My_DVLD_Desktop.Applications.LocalDrivingLicenseApplications.ScheduleTests.Controls
{
    public partial class ScheduledTest : UserControl
    {
        int _AppointmentTestID = -1;
        clsAppointmentTestsBussiness _AppointmentTest;
        int _LDLAppID = -1;
        clsTestTypeBussinuse.enTestType _TestTypeID = clsTestTypeBussinuse.enTestType.VisionTest;
        int _TestID = -1;


        public clsTestTypeBussinuse.enTestType TestType
        {
            get { return _TestTypeID; }

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
                        lblTitle.Text = "Writen Test";
                        break;

                    case clsTestTypeBussinuse.enTestType.StreetTest:

                        pictureBox1.Image = Resources.driving_test_512;
                        lblTitle.Text = "Street Test";
                        break;
                }
            }
        }

        public int TestID
        {
            get { return _TestID; }
        }

        public int AppointmentTestID
        {
            get { return _AppointmentTestID; }
        }


        public void LoadInfo(int AppointmentTestID)
        {

            _AppointmentTest = clsAppointmentTestsBussiness.FindAppointment(AppointmentTestID);


            if(_AppointmentTest == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _AppointmentTestID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _AppointmentTestID = -1;
                return;
            }

            _TestID = _AppointmentTest.TestID;
            _AppointmentTestID = _AppointmentTest.TestAppointmentID;

            _LDLAppID = _AppointmentTest.LocalDrivingLicenseApplicationID;
            clsLocalDrivingLicenseApplicationBusinuse LDLApp = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(_LDLAppID);

            if(LDLApp == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LDLAppID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLDLAppID.Text = _LDLAppID.ToString();
            lblD_Class.Text = LDLApp.clsLicenseClass.ClassName.ToString();
            lblName.Text = LDLApp.PersonFUllName;
            lblTrial.Text = LDLApp.TotalTrialsPerTest(_TestTypeID).ToString();
            lblDate.Text = _AppointmentTest.AppointmentDate.ToString();
            lblFees.Text = _AppointmentTest.PaidFees.ToString();
            lblTestID.Text = _AppointmentTest.TestID.ToString();
            return;

        }

        public ScheduledTest()
        {
            InitializeComponent();
        }

    }
}
