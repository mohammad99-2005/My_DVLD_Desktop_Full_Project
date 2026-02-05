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
using My_DVLD_Desktop.Applications.Licenses;

namespace My_DVLD_Desktop.Applications.Tests.Test_Types
{
    public partial class ctrlLocalDrivingLicenseInfo : UserControl
    {

        clsLocalDrivingLicenseApplicationBusinuse LDLApp;
        int _LDLAppID = -1;

        int _LicenseID = -1;

        public int LocalDrivingLicenseApplicationID
        {
            get { return _LDLAppID; }
        }
        
        public ctrlLocalDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void llblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personInfo = new frmPersonDetails(LDLApp.Person.PersonID);
            personInfo.ShowDialog();
        }

        public bool LoadApplicationInfoByLocalDrivingAppID(int LDLAppID)
        {
            LDLApp = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LDLAppID);
            _LDLAppID = LDLAppID;
            if (LDLApp == null)
            {
                MessageBox.Show("There is no Local Driving License Application with ID (" + LDLAppID + ")");
                return false;
            }

            FillInformation();
            return true;
        }

        public bool LoadApplicationInfoByApplicationID(int ApplicationID)
        {
            LDLApp = clsLocalDrivingLicenseApplicationBusinuse.FindByApplicationID(ApplicationID);
            _LDLAppID = LDLApp.LDLAppID;

            if(LDLApp == null)
            {
                MessageBox.Show("There is no Local Driving License Application with Application ID (" + ApplicationID + ")");
                return false;
            }

            FillInformation();
            return true;
        }

        private void FillInformation()
        {
            _LicenseID = LDLApp.GetActiveLicenseID();

            lblLDLAppID.Text = _LDLAppID.ToString();
            lblAppliedLicense.Text = LDLApp.clsLicenseClass.ClassName.ToString();
            lblPassedTests.Text = clsTestsBussiness.GetNumOfPassedTests(_LDLAppID).ToString();

            ctrlBasicApplicationInfo1.LoadApplicationInfoByApplicationID(LDLApp.ApplicationID);
        }

        private void ctrlVisionTest_Load(object sender, EventArgs e)
        {
            
        }

        private void lblAppliedLicense_Click(object sender, EventArgs e)
        {

        }

        private void lblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInformation LicenseInfo = new frmLicenseInformation(LDLApp.GetActiveLicenseID());
            LicenseInfo.ShowDialog();
        }
    }
}
