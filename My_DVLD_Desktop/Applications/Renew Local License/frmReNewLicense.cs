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
    public partial class frmReNewLicense : Form
    {
        int _LicenseID = -1;

        clsLicensesBussinese _OldLicense;
        int _NewLicenseID = -1;

        public frmReNewLicense()
        {
            InitializeComponent();
            lbllShowLicenseInfo.Enabled = false;
            lbllShowHistory.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadRenewApplicationInfos()
        {
            //fill labels with data.
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblOldLicenseID.Text = _OldLicense.LicenseID.ToString();
            lblIssueDate.Text = DateTime.Now.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(clsLicenseClassesBussinuse.Find(_OldLicense.LicenseCLassID).DefaultValidityLength).ToString();
            lblApplicationFees.Text = clsApplicationTypesBusinuse.Find((int)clsApplicationBussinuse.enApplicationType.RenewDrivingLicense).ApplicationTypeFees.ToString();
            lblCreatedByUser.Text = clsGlobal.clsCurrUser.Username;
            lblLicenseFees.Text = _OldLicense.PaidFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblLicenseFees.Text) + Convert.ToSingle(lblApplicationFees.Text)).ToString();
            txtNotes.Text = _OldLicense.Notes.ToString();
        }

        private void _CheckLicenseExpiration()
        {
            _OldLicense = clsLicensesBussinese.FindLicense(_LicenseID);

            if(_OldLicense == null)
            {
                MessageBox.Show("There is no License with ID " + _LicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                lbllShowLicenseInfo.Enabled = false;
                lbllShowHistory.Enabled = false;
                return;
            }

            _LoadRenewApplicationInfos();

            if (!_OldLicense.IsLicenseExpired())
            {
                MessageBox.Show("The License with ID:"+_LicenseID+" has not expired","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnRenew.Enabled = false;
                lbllShowLicenseInfo.Enabled=false;
                return;
            }

            if (!_OldLicense.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                lbllShowLicenseInfo.Enabled = false;
                return;
            }

            lbllShowHistory.Enabled = true;
            btnRenew.Enabled = true;
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            _CheckLicenseExpiration();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsLicensesBussinese NewLicense = ctrlLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(clsGlobal.clsCurrUser.UserID);
            
           
            if (NewLicense != null)
            {
                lblRenewedLicenseID.Text = NewLicense.LicenseID.ToString();
                lblApplicationID.Text = NewLicense.ApplicationID.ToString();

                MessageBox.Show("License Renewed Successfully","Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _NewLicenseID = NewLicense.LicenseID;
                btnRenew.Enabled = false;
                lbllShowLicenseInfo.Enabled = true;
                lbllShowHistory.Enabled = true;
                ctrlLicenseInfoWithFilter1.Enabled = false;

            }
            else
            {
                MessageBox.Show("Error while save the New License information", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
        }

        private void ctrlLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void lbllShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInformation NewLicense = new frmLicenseInformation(_NewLicenseID);
            NewLicense.Show();
        }

        private void lbllShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonHistoryLicenses LicensePersonHistory = new frmPersonHistoryLicenses(this._OldLicense.ApplicationInfo.Person.PersonID);
            LicensePersonHistory.Show();
        }
    }
}
