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
    public partial class frmDetainLicense : Form
    {
        
        int _LicenseID = -1;
        clsLicensesBussinese DetainLicense;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private bool CheckLicense()
        {
            if(clsDetainLicensesBussinuse.IsLicenseDetained(_LicenseID))
            {
                
                return false;
            }
            return true;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = DateTime.Now.ToString();
            lblCreatedByUser.Text = clsGlobal.clsCurrUser.Username;
            ctrlLicenseInfoWithFilter1.txtLicenseIDFocus();

        }

        private void ctrlLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;
            if (_LicenseID == -1)
            {
                btnDetain.Enabled = false;
                return;
            }

            DetainLicense = clsLicensesBussinese.FindLicense(_LicenseID);
            if (DetainLicense.IsDetained)
            {
                MessageBox.Show("This License already Detained", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
                txtbFees.Enabled = false;
                return;
            }

            lblLicenseID.Text = _LicenseID.ToString();
            lbllShowHistory.Enabled = true;
            lbllShowLicenseInfo.Enabled = true;
            btnDetain.Enabled = true;

            ctrlLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        
        private void btnDetain_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                txtbFees.Focus();
                return;
            }

            if (MessageBox.Show("Are you sure you want to Detain the license with ID:"+_LicenseID.ToString(),"Make sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            
            int DetainID = DetainLicense.Detain(Convert.ToInt32(txtbFees.Text), clsGlobal.clsCurrUser.UserID);
            if (DetainID== -1)
            {
                MessageBox.Show("Failed to Detain License", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License Detained Successfully", "Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDetain.Enabled = false;
            ctrlLicenseInfoWithFilter1.FilterEnabled = false;
            txtbFees.Enabled = false;
            lblDetainID.Text = DetainID.ToString();
        }


        private void lbllShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseInformation License = new frmLicenseInformation(_LicenseID);
            License.Show();
        }

        private void lbllShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicensesBussinese.FindLicense(_LicenseID).ApplicationInfo.Person.PersonID;
            frmPersonHistoryLicenses LicenseHistory = new frmPersonHistoryLicenses(PersonID);
            LicenseHistory.Show();
        }

        private void txtbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbFees, "This Fieled Required");
            }
            else
            {
                errorProvider1.SetError(txtbFees, null);
            }
        }

        private void txtbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
