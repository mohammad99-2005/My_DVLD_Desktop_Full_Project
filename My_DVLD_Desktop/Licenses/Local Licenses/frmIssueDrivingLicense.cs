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

namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    public partial class frmIssueDrivingLicense : Form
    {
        int _LDLAppID = -1;
        private clsLocalDrivingLicenseApplicationBusinuse _LDLApp;
        public frmIssueDrivingLicense(int LocalDrivingLicenseApplicationID)
        {
            _LDLAppID = LocalDrivingLicenseApplicationID;
            InitializeComponent();
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {

            txtbNotes.Focus();

            _LDLApp = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(_LDLAppID);

            if (_LDLApp == null)
            {
                MessageBox.Show("No Applicaiton with ID=" + _LDLAppID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (!_LDLApp.PassedAllTests())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = _LDLApp.GetActiveLicenseID();
            if(LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlLocalDrivingLicenseInfo1.LoadApplicationInfoByLocalDrivingAppID(_LDLAppID);
        }


        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = _LDLApp.IssueLicenseForTheFirstTime(txtbNotes.Text, clsGlobal.clsCurrUser.UserID);

            if(LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfuly with ID:"+LicenseID.ToString(), "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error with Local Driving License Application ID.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
