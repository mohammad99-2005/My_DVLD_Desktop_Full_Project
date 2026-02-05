using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using My_DVLD_DataAccessLayer;

namespace My_DVLD_Desktop.Applications.Licenses.DetainReleaseLicense
{
    public partial class frmManageDetainedLicenses : Form
    {
        DataTable _dtDetainedLicenses;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
            cbFilters.SelectedIndex = 0;
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtDetainedLicenses = clsDetainLicensesBussinuse.GetAllDetainedLicenses();

            dgvDetainedLicenses.DataSource = _dtDetainedLicenses;
            lblCount.Text = dgvDetainedLicenses.Rows.Count.ToString();

            if(dgvDetainedLicenses.Rows.Count > 0 )
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 40;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 40;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 130;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 100;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 145;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 130;

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No";
                dgvDetainedLicenses.Columns[6].Width = 90;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 195;

                dgvDetainedLicenses.Columns[8].HeaderText = "Release AppID";
                dgvDetainedLicenses.Columns[8].Width = 100;
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense detainLicense = new frmDetainLicense();
            detainLicense.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense releaseDetainedLicense = new frmReleaseDetainedLicense();
            releaseDetainedLicense.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense releaseDetainedLicense = new frmReleaseDetainedLicense(Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value));
            releaseDetainedLicense.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //int LicenseID = Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            //bool IsDetained = clsDetainLicensesBussinuse.IsLicenseDetained(LicenseID);
            //if (IsDetained)
            //{
            //    releaseLicenseToolStripMenuItem.Enabled = true;
            //}
            //else
            //{
            //    releaseLicenseToolStripMenuItem.Enabled = false;
            //}
            releaseLicenseToolStripMenuItem.Enabled = !(bool)(dgvDetainedLicenses.CurrentRow.Cells[3].Value);
        }

        private void txtbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilters.Text == "DetainID" || cbFilters.Text == "ReleaseApplicationID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilters.Text == "None")
            {
                txtbFilterValue.Visible = false;
                cbIsReleased.Visible = false;
            }
            else if(cbFilters.Text == "IsReleased")
            {
                txtbFilterValue.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.SelectedIndex = 0;
            }
            else
            {
                txtbFilterValue.Visible = true;
                cbIsReleased.Visible = false;
            }
            txtbFilterValue.Focus();
            _dtDetainedLicenses = clsDetainLicensesBussinuse.GetAllDetainedLicenses();
        }

        private void txtbFilterValue_TextChanged(object sender, EventArgs e)
        {
            
            if(txtbFilterValue.Text.Trim() == "")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                lblCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
                return;
            }
            
            if(cbFilters.Text == "DetainID" || cbFilters.Text == "ReleaseApplicationID")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}",cbFilters.Text,txtbFilterValue.Text.Trim());
            }
            else
            {
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",cbFilters.Text, txtbFilterValue.Text.Trim());
            }
            dgvDetainedLicenses.DataSource = _dtDetainedLicenses;
            lblCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = "0";
            if(cbIsReleased.Text == "Yes")
            {
                FilterValue = "1";
            }
            else if(cbIsReleased.Text == "No")
            {
                FilterValue = "0";
            }
            else
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                dgvDetainedLicenses.DataSource = _dtDetainedLicenses;
                lblCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
                return;
            }
            _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilters.Text, FilterValue);
            dgvDetainedLicenses.DataSource = _dtDetainedLicenses;
            lblCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvDetainedLicenses.CurrentRow.Cells[6].Value.ToString();
            frmPersonDetails Person = new frmPersonDetails(NationalNo);
            Person.ShowDialog();
        }

        private void licenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNo = dgvDetainedLicenses.CurrentRow.Cells[6].Value.ToString();
            int PersonID = clsPeopleManagmentBusinuse.Find(NationalNo).PersonID;
            frmPersonHistoryLicenses LicenseHistory = new frmPersonHistoryLicenses(PersonID);
            LicenseHistory.ShowDialog();
        }

        private void licenseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frmLicenseInformation License = new frmLicenseInformation(LicenseID);
            License.ShowDialog();
        }
    }
}
