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
using My_DVLD_Desktop.Global;
using My_DVLD_Desktop.Properties;
using static My_DVLD_BussinessLayer.clsTestTypeBussinuse;

namespace My_DVLD_Desktop.Applications.Tests
{
    public partial class frmTestAppointments : Form
    {

        private int LDLAppID = -1;
        DataTable dtAppointments;
        clsTestTypeBussinuse.enTestType _TestType;
        public frmTestAppointments(int LocalDrivingLicenseApplicationID,clsTestTypeBussinuse.enTestType testType)
        {
            InitializeComponent();
            LDLAppID = LocalDrivingLicenseApplicationID;
            _TestType = testType;

            
        }

        private void _LoadTestTypeImageAndTitle()
        {
            if (_TestType == clsTestTypeBussinuse.enTestType.VisionTest)
            {
                pictureBox1.Image = Resources.Vision_512;
                this.Text = lblTitle.Text;
                lblTitle.Text = "Schedual Vision Test";
            }
            else if (_TestType == clsTestTypeBussinuse.enTestType.WrittenTest)
            {
                pictureBox1.Image = Resources.Written_Test_512;
                this.Text = lblTitle.Text;
                lblTitle.Text = "Schedual Writen Test";
            }
            else if (_TestType == clsTestTypeBussinuse.enTestType.StreetTest)
            {
                pictureBox1.Image = Resources.driving_test_512;
                this.Text = lblTitle.Text;
                lblTitle.Text = "Schedual Street Test";
            }
        }


        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();
            
            ctrlVisionTest1.LoadApplicationInfoByLocalDrivingAppID(LDLAppID);

            dtAppointments = clsAppointmentTestsBussiness.GetApplicationTestAppointmentsPerTestType(LDLAppID,Convert.ToByte(_TestType));
            DataTable dtAppointmentsTest = dtAppointments.DefaultView.ToTable(false, "TestAppointmentID", "AppointmentDate",
                                                                                    "PaidFees", "IsLocked");

            dgvAppointmentTests.DataSource = dtAppointmentsTest;

            dgvAppointmentTests.Columns[0].HeaderText = "Appointment ID";
            dgvAppointmentTests.Columns[0].Width = 180;

            dgvAppointmentTests.Columns[1].HeaderText = "Appointment Date";
            dgvAppointmentTests.Columns[1].Width = 200;

            dgvAppointmentTests.Columns[2].HeaderText = "Paid Fees";
            dgvAppointmentTests.Columns[2].Width = 190;

            dgvAppointmentTests.Columns[3].HeaderText = "Is Locked";
            dgvAppointmentTests.Columns[3].Width = 100;

            lblCount.Text = dgvAppointmentTests.Rows.Count.ToString();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

            clsLocalDrivingLicenseApplicationBusinuse localDrivingLicenseApplication = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LDLAppID);

            if(localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTestsBussiness LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_TestType);

            if(LastTest == null)
            {
                frmScheduleTest ScheduleTest = new frmScheduleTest(LDLAppID, _TestType);
                ScheduleTest.ShowDialog();
                frmTestAppointments_Load(null, null);
                return;
            }


            if (LastTest.TestResult==true)
            {
                MessageBox.Show("Already passed this test", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            frmScheduleTest ScheduleTest2 = new frmScheduleTest(LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _TestType);
            ScheduleTest2.ShowDialog();
            frmTestAppointments_Load(null, null);
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = Convert.ToInt32(dgvAppointmentTests.CurrentRow.Cells[0].Value);
            frmScheduleTest editVisionTest = new frmScheduleTest(LDLAppID,_TestType, AppointmentID);
            editVisionTest.ShowDialog();
            frmTestAppointments_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // continue from take test ........
            
            frmTakeTest takeVisionTest = new frmTakeTest(Convert.ToInt32(dgvAppointmentTests.CurrentRow.Cells[0].Value),_TestType);
            takeVisionTest.ShowDialog();
            frmTestAppointments_Load(null,null);
        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {
            bool IsLocked = Convert.ToBoolean(dgvAppointmentTests.CurrentRow.Cells[3].Value);
            if (IsLocked)
            {
                takeTestToolStripMenuItem.Enabled = false;
                return;
            }
            takeTestToolStripMenuItem.Enabled = true;
        }
    }
}
