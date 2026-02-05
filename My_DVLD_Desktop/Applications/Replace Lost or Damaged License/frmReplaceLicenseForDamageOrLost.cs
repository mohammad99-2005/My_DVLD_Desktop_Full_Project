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

namespace My_DVLD_Desktop.Applications.Licenses
{
    public partial class frmReplaceLicenseForDamageOrLost : Form
    {

        int _OldLicenseID = -1;
        clsLicensesBussinese _OldLicense;
        int _NewLicenseID = -1;
        public frmReplaceLicenseForDamageOrLost()
        {
            InitializeComponent();
        }

        private void frmReplaceLicenseForDamageOrLost_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.txtLicenseIDFocus();
            rbDamage.Checked = true;
            lbllShowHistory.Enabled = false;
            lbllShowLicenseInfo.Enabled = false;

            lblApplicationDate.Text = DateTime.Now.ToString();
            lblApplicationFees.Text = clsApplicationTypesBusinuse.Find(
                (int)clsApplicationBussinuse.enApplicationType.ReplaceDamagedDrivingLicense).ApplicationTypeFees.ToString();
            lblCreatedByUser.Text = clsGlobal.clsCurrUser.Username.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbDamage_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Damage";
            lblApplicationFees.Text = clsApplicationTypesBusinuse.Find(
                (int)clsApplicationBussinuse.enApplicationType.ReplaceDamagedDrivingLicense).ApplicationTypeFees.ToString();
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Lost";
            lblApplicationFees.Text = clsApplicationTypesBusinuse.Find(
                (int)clsApplicationBussinuse.enApplicationType.ReplaceLostDrivingLicense).ApplicationTypeFees.ToString();
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _OldLicenseID = obj;
            _OldLicense = clsLicensesBussinese.FindLicense(_OldLicenseID);

            if (_OldLicenseID == -1)
            {
                MessageBox.Show("Write the correct License ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (!_OldLicense.IsActive)
            {
                MessageBox.Show("Your License is not active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReplacement.Enabled = false;
                return;
            }

            btnReplacement.Enabled = true;
            lbllShowHistory.Enabled = true;
            lblOldLicenseID.Text = _OldLicenseID.ToString();

        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are You sure, you want to replace the license","Insure Replacement",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            clsLicensesBussinese NewLicense;

            if (rbDamage.Checked)
            {
                NewLicense = _OldLicense.ReplaceLicense(
                    clsLicensesBussinese.enIssueReason.ReplacementForDamaged, clsGlobal.clsCurrUser.UserID);
            }
            else
            {
                NewLicense = _OldLicense.ReplaceLicense(
                    clsLicensesBussinese.enIssueReason.ReplacementForLost, clsGlobal.clsCurrUser.UserID);
            }

            if(NewLicense == null)
            {
                MessageBox.Show("Failed to replace the license with ID:(" + _OldLicenseID + ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReplacement.Enabled = false;
                return;
            }

            _NewLicenseID = NewLicense.LicenseID;


            lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();
            lblApplicationID.Text = NewLicense.ApplicationID.ToString();
            lbllShowLicenseInfo.Enabled = true;
            btnReplacement.Enabled = false;
            gbReplacementFilter.Enabled = false;
            ctrlLicenseInfoWithFilter1.Enabled = false;
            MessageBox.Show("License Replaced Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void lbllShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonHistoryLicenses LicenseHistory = new frmPersonHistoryLicenses(_OldLicense.ApplicationInfo.Person.PersonID);
            LicenseHistory.ShowDialog();
        }

        private void lbllShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInformation LicenseInformation = new frmLicenseInformation(_NewLicenseID);
            LicenseInformation.ShowDialog();
        }
    }
}
