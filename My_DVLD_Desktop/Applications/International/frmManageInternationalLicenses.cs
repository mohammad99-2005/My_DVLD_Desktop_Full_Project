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
using My_DVLD_Desktop.Applications.Licenses;

namespace My_DVLD_Desktop.Applications.International
{
    public partial class frmManageInternationalLicenses : Form
    {
        DataTable _dtInternationalLicenses;
        public frmManageInternationalLicenses()
        {
            InitializeComponent();
        }

        private void btnNewInternationalApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication newInternationalLicenseApplication = new frmNewInternationalLicenseApplication();
            newInternationalLicenseApplication.ShowDialog();
            frmManageInternationalLicenses_Load(null, null);
        }

        private void frmManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            _dtInternationalLicenses = clsInternationalLicensesBussinuss.GetAllInternationalLicenses();
            cbFilters.SelectedIndex = 0;
            dgvInternationalLicenses.DataSource = _dtInternationalLicenses;

            lblCount.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "I.L.ID";
                dgvInternationalLicenses.Columns[0].Width = 100;

                dgvInternationalLicenses.Columns[1].HeaderText = "A.ID";
                dgvInternationalLicenses.Columns[1].Width = 100;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 100;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.L.ID";
                dgvInternationalLicenses.Columns[3].Width = 100;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 160;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 160;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 100;
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsLicensesBussinese.FindLicense(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells[3].Value)).ApplicationInfo.Person.PersonID;
            frmPersonDetails Person = new frmPersonDetails(PersonID);
            Person.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenesInfo IntLicenseInfo = new frmInternationalLicenesInfo(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells[0].Value));
            IntLicenseInfo.ShowDialog();
        }

        private void personHistoryLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsLicensesBussinese.FindLicense(Convert.ToInt32(dgvInternationalLicenses.CurrentRow.Cells[3].Value)).ApplicationInfo.Person.PersonID;
            frmPersonHistoryLicenses personHistoryLicenses = new frmPersonHistoryLicenses(PersonID);
            personHistoryLicenses.ShowDialog();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilters.Text == "None")
            {
                txtbFilterValue.Visible = false;
                cbIsActive.Visible = false;
            }

            else if(cbFilters.Text == "Is Active")
            {
                txtbFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtbFilterValue.Visible = true;
                cbIsActive.Visible = false;
            }

            txtbFilterValue.Focus();
            _dtInternationalLicenses = clsInternationalLicensesBussinuss.GetAllInternationalLicenses();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterName = "IsActive";
            string FilterValue = "";

            if(cbIsActive.Text == "Yes")
            {
                FilterValue = "1";
            }
            else if(cbIsActive.Text == "No")
            {
                FilterValue = "0";
            }
            else
            {
                _dtInternationalLicenses.DefaultView.RowFilter = "";
                dgvInternationalLicenses.DataSource = _dtInternationalLicenses;
                lblCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
                return;
            }

            _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterName, FilterValue);
            dgvInternationalLicenses.DataSource = _dtInternationalLicenses;
            lblCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void txtbFilterValue_TextChanged(object sender, EventArgs e)
        {

            if (txtbFilterValue.Text.Trim() == "" || cbFilters.Text == "None")
            {
                _dtInternationalLicenses.DefaultView.RowFilter = "";
                dgvInternationalLicenses.DataSource = _dtInternationalLicenses;
                lblCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
                return;
            }


            string FilterValue = "";
            switch (cbFilters.Text)
            {
                case "International License ID":
                    FilterValue = "InternationalLicenseID";
                    break;
                case "Application ID":
                    FilterValue = "ApplicationID";
                    break;
                case "Driver ID":
                    FilterValue = "DriverID";
                    break;
                case "Local License ID":
                    FilterValue = "IssuedUsingLocalLicenseID";
                    break;
            }

            _dtInternationalLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterValue, txtbFilterValue.Text);

            dgvInternationalLicenses.DataSource = _dtInternationalLicenses;
            lblCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
