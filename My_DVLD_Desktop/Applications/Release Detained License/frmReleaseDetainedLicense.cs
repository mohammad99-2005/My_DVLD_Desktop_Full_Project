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
using My_DVLD_DataAccessLayer;
using My_DVLD_Desktop.Global;

namespace My_DVLD_Desktop.Applications.Licenses.DetainReleaseLicense
{
    public partial class frmReleaseDetainedLicense : Form
    {
        int _LicenseID = -1;
        clsLicensesBussinese _DetainedLicense;
        public frmReleaseDetainedLicense(int LicenseID)
        {
            _LicenseID = LicenseID;
            InitializeComponent();
        }

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        private void CheckLicense()
        {
            if (ctrlLicenseInfoWithFilter1.SelectedLicenseInfo == null)
            {
                btnRelease.Enabled = false;
                return ;
            }

            lbllShowHistory.Enabled = true;
            lbllShowLicenseInfo.Enabled = true;

            if (!_DetainedLicense.IsDetained)
            {
                MessageBox.Show("This License already Released", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return ;
            }

            //here we can use the License object thats in the control (Composition) :-)
            lblDetainID.Text = _DetainedLicense.DetainedLicense.DetainID.ToString();
            lblLicenseID.Text = _LicenseID.ToString();
            lblDetainDate.Text = _DetainedLicense.DetainedLicense.DetainDate.ToString();
            lblFineFees.Text = _DetainedLicense.DetainedLicense.FineFees.ToString();
            lblApplicationFees.Text = clsApplicationTypesBusinuse.Find((int)clsApplicationBussinuse.enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationTypeFees.ToString();
            lblCreatedByUser.Text = _DetainedLicense.DetainedLicense.CreatedByUserID.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblFineFees.Text) + Convert.ToSingle(lblApplicationFees.Text)).ToString();
            
            btnRelease.Enabled = true ;
            return ;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if(_LicenseID != -1)
            {
                _DetainedLicense = clsLicensesBussinese.FindLicense(_LicenseID);
                ctrlLicenseInfoWithFilter1.LoadInfo(_LicenseID);
                ctrlLicenseInfoWithFilter1.FilterEnabled = false;
                CheckLicense();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            int ApplicationID = -1;
            bool Released = _DetainedLicense.ReleaseDetainedLicense(clsGlobal.clsCurrUser.UserID,ref ApplicationID);
            
            if (!Released)
            {
                MessageBox.Show("Failed To Release the License","Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("License Released Successfully", "Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblRApplicationID.Text = ApplicationID.ToString();
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            btnRelease.Enabled = false;
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _DetainedLicense = clsLicensesBussinese.FindLicense(_LicenseID);
            CheckLicense();
        }

        private void lbllShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInformation License = new frmLicenseInformation(_LicenseID);
            License.Show();
        }

        private void lbllShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonHistoryLicenses historyLicenses = new frmPersonHistoryLicenses(_DetainedLicense.ApplicationInfo.Person.PersonID);
            historyLicenses.Show();
        }
    }
}
