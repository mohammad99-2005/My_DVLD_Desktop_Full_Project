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

namespace My_DVLD_Desktop.Applications.Tests
{
    public partial class frmScheduleTest : Form
    {

        private int _LDLAppID = -1;
        private int _AppointmentTestID = -1;
        clsTestTypeBussinuse.enTestType _TestType;
        
        public frmScheduleTest(int LocalDrivingLicenseApplicationID, clsTestTypeBussinuse.enTestType testType, int AppointmentID = -1)
        {
            InitializeComponent();

            _LDLAppID = LocalDrivingLicenseApplicationID;
            _AppointmentTestID = AppointmentID;
            _TestType = testType;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSchedualAppoitnmentTest_Load(object sender, EventArgs e)
        {
            scheduleTests1.TestType = _TestType;
            scheduleTests1.LoadInfo(_LDLAppID, _AppointmentTestID);
        }

    }
}
