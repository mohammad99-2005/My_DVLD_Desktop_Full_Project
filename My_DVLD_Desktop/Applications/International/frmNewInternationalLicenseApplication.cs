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
using My_DVLD_Desktop.Global;

namespace My_DVLD_Desktop.Applications.International
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        int _LocalLicenseID = -1;
        clsLicensesBussinese _LocalLicenseInfo = null;
        int _InternationalLicenseID = -1;
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LocalLicenseID = obj;

            _LocalLicenseInfo = clsLicensesBussinese.FindLicense(_LocalLicenseID);
            if (_LocalLicenseInfo == null)
            {
                btnIssue.Enabled = false;
                return;
            }

            lbllShowHistory.Enabled = true;
            lblLocalLicenseID.Text = _LocalLicenseID.ToString();

            int OrdinaryDrivingLicense = 3;
            if (_LocalLicenseInfo.LicenseCLassID != 3)
            {
                MessageBox.Show("License should be of type '"+clsLicenseClassesBussinuse.Find(3).ClassName+"'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }
            ///////////
            int ActiveInternationalLicenseID = clsInternationalLicensesBussinuss.GetTheActiveInternationalLicenseToDriverID(_LocalLicenseInfo.DriverID);
            if(ActiveInternationalLicenseID != -1)
            {
                MessageBox.Show("Person already has Active international Licenes with ID"+ActiveInternationalLicenseID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                _InternationalLicenseID = ActiveInternationalLicenseID;
                return;
            }

            lblFees.Text = clsApplicationTypesBusinuse.Find((int)clsApplicationBussinuse.enApplicationType.NewInternationalLicense).ApplicationTypeFees.ToString();
            int DefaultValedityLength = clsLicenseClassesBussinuse.Find(clsLicensesBussinese.FindLicense(_LocalLicenseID).LicenseCLassID).DefaultValidityLength;
            lblExpirationDate.Text = DateTime.Now.AddYears(DefaultValedityLength).ToString();
            btnIssue.Enabled = true;
            //ctrlLicenseInfoWithFilter1.FilterEnabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblIssueDate.Text = DateTime.Now.ToString();
            lblCreatedBy.Text = clsGlobal.clsCurrUser.Username;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure ,you want to issue International Licesne","Check",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicensesBussinuss InternationalLicense = new clsInternationalLicensesBussinuss();

            InternationalLicense.ApplicationStatus = clsApplicationBussinuse.enApplicationStatus.New;
            InternationalLicense.ApplicationPersonID = _LocalLicenseInfo.ApplicationInfo.Person.PersonID;
            InternationalLicense.ApplicationTypeID = (int)clsApplicationBussinuse.enApplicationType.NewInternationalLicense;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationTypesBusinuse.Find((int)clsApplicationBussinuse.enApplicationType.NewInternationalLicense).ApplicationTypeFees;

            InternationalLicense.DriverID = _LocalLicenseInfo.DriverID;
            InternationalLicense.CreatedByUserID = clsGlobal.clsCurrUser.UserID;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClassesBussinuse.Find(clsLicensesBussinese.FindLicense(_LocalLicenseID).LicenseCLassID).DefaultValidityLength);
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.IsActive = true;
            InternationalLicense.IssuedUsingLocalLicenseID = _LocalLicenseID;

            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Failed to issue new International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }

            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            MessageBox.Show("International License issued successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblLApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            lblILicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            btnIssue.Enabled = false;
            lbllShowLicenseInfo.Enabled = true;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void lbllShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenesInfo InternationalLicenseInfo = new frmInternationalLicenesInfo(_InternationalLicenseID);
            InternationalLicenseInfo.ShowDialog();
        }

        private void lbllShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonHistoryLicenses History = new frmPersonHistoryLicenses(_LocalLicenseInfo.ApplicationInfo.Person.PersonID);
            History.ShowDialog();
        }

        private void frmNewInternationalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
