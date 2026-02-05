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
using My_DVLD_Desktop.Applications.Licenses;
using My_DVLD_Desktop.Applications.Tests;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static My_DVLD_BussinessLayer.clsApplicationBussinuse;

namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    public partial class frmListLocalDrivingLicenseApplication : Form
    {
        public frmListLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            cbFilters.SelectedIndex = 0;
        }

        DataTable dt = clsLocalDrivingLicenseApplicationBusinuse.GetAllLocalDrivingLicenseApplications();

        private void _ResetApplications()
        {
            dt = clsLocalDrivingLicenseApplicationBusinuse.GetAllLocalDrivingLicenseApplications();
            dgvLocalDriningLicenseApp.DataSource = dt;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingLicenseApplication AddLDLApp = new AddNewLocalDrivingLicenseApplication();
            AddLDLApp.ShowDialog();
            _ResetApplications();
        }

        private void frmListLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetApplications();
            lblCount.Text = dt.Rows.Count.ToString();

            if (dgvLocalDriningLicenseApp.SelectedRows.Count > 0)
            {
                dgvLocalDriningLicenseApp.Columns[0].HeaderText = "LDL App ID";
                dgvLocalDriningLicenseApp.Columns[0].Width = 110;

                dgvLocalDriningLicenseApp.Columns[1].HeaderText = "License Class";
                dgvLocalDriningLicenseApp.Columns[1].Width = 200;

                dgvLocalDriningLicenseApp.Columns[2].HeaderText = "National No";
                dgvLocalDriningLicenseApp.Columns[2].Width = 140;

                dgvLocalDriningLicenseApp.Columns[3].HeaderText = "Full Name";
                dgvLocalDriningLicenseApp.Columns[3].Width = 220;

                dgvLocalDriningLicenseApp.Columns[4].HeaderText = "Application Date";
                dgvLocalDriningLicenseApp.Columns[4].Width = 150;

                dgvLocalDriningLicenseApp.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDriningLicenseApp.Columns[5].Width = 100;

                dgvLocalDriningLicenseApp.Columns[6].HeaderText = "Application Status";
                dgvLocalDriningLicenseApp.Columns[6].Width = 140;
                
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtbFilterValue.Visible = (cbFilters.Text != "None");

            if (txtbFilterValue.Visible)
            {
                txtbFilterValue.Text = "";
                txtbFilterValue.Focus();
            }

            lblCount.Text = dgvLocalDriningLicenseApp.Rows.Count.ToString();
            dt.DefaultView.RowFilter = "";
        }

        private void txtbFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";  

            switch (cbFilters.Text)
            {
                case "L.D.L AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;
                case "FullName":
                    FilterColumn = "FullName";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtbFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                dt.DefaultView.RowFilter = "";
                lblCount.Text = dgvLocalDriningLicenseApp.RowCount.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtbFilterValue.Text.Trim());
            }
            else
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtbFilterValue.Text.Trim());
            }
            lblCount.Text = dgvLocalDriningLicenseApp.RowCount.ToString();
        }

        private void txtbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilters.Text == "L.D.L AppID")
            {
                e.Handled = char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ? false : true;
            }
            else
            {
                e.Handled = false;
            }
        }

        void GetAllowedTests()
        {
            //contextMenuStrip1.

        }
        private void txtbFilterValue_Validating(object sender, CancelEventArgs e)
        {

        }

        private void scheduleTestsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private void _SchedualTest(clsTestTypeBussinuse.enTestType TestType)
        {
            DataGridViewRow dataGridViewRow = dgvLocalDriningLicenseApp.SelectedRows[0];
            int LDLAppID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
            frmTestAppointments ScheduledTest = new frmTestAppointments(LDLAppID, TestType);
            ScheduledTest.ShowDialog();
            _ResetApplications();
        }

        private void visionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SchedualTest(clsTestTypeBussinuse.enTestType.VisionTest);
        }

        private void schedualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SchedualTest(clsTestTypeBussinuse.enTestType.WrittenTest);
        }

        private void streetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SchedualTest(clsTestTypeBussinuse.enTestType.StreetTest);
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value);
            AddNewLocalDrivingLicenseApplication LDLApp = new AddNewLocalDrivingLicenseApplication(LDLAppID);
            LDLApp.ShowDialog();
            _ResetApplications();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LDLAppID = Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value);

            clsLocalDrivingLicenseApplicationBusinuse LDLApp =clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LDLAppID);
            if(LDLApp != null)
            {
                if (LDLApp.Cancel())
                {
                    MessageBox.Show("Application Canceld.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ResetApplications();
                }
                else
                {
                    MessageBox.Show("Failed to delete the Application.", "Cancel failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLoalDrivingLiceseApplicationInfo showLDLAppInfo = new frmShowLoalDrivingLiceseApplicationInfo(Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value));
            showLDLAppInfo.ShowDialog();
            _ResetApplications();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {// start from here to get the appointment id to solve it
            //the solution is delete cascade ,i think that

            if (MessageBox.Show("Are You sure to delete this L.D.L.Application", "Delete Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int LDLAppID = Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value);
                clsLocalDrivingLicenseApplicationBusinuse LDLApp = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LDLAppID);

                if (LDLApp.ApplicationStatus == clsApplicationBussinuse.enApplicationStatus.Completed || LDLApp.ApplicationStatus == clsApplicationBussinuse.enApplicationStatus.Cancelled)
                {
                    MessageBox.Show("Cant delete this L.D.L.Application", "Wronge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (LDLApp.DeleteLocalDrivingLicenseApplication())
                {
                    MessageBox.Show("Deleted Successfuly.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _ResetApplications();
            }
            else
            {
                return;
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicense issueLicense = new frmIssueDrivingLicense(Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value));
            issueLicense.ShowDialog();
            _ResetApplications();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value);

            int LicenseID = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(
                LDLAppID).GetActiveLicenseID();

            if(LicenseID != -1)
            {
                frmLicenseInformation LicenseInfo = new frmLicenseInformation(LicenseID);// Dont Forget to change it to LicenseID not LDLAppID
                LicenseInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void showDrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value);
            clsLocalDrivingLicenseApplicationBusinuse LDLApp =clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LDLAppID);
            clsLicensesBussinese License =clsLicensesBussinese.FindLicenseByApplicationIDandLicenseClass(LDLApp.ApplicationID, LDLApp.LicenseCLassID);
            frmPersonHistoryLicenses HistoryLicense = new frmPersonHistoryLicenses(License.ApplicationInfo.Person.PersonID);
            HistoryLicense.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LDLAppID = Convert.ToInt32(dgvLocalDriningLicenseApp.CurrentRow.Cells[0].Value);
            clsLocalDrivingLicenseApplicationBusinuse LDLApp =
                clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(LDLAppID);


            int TotalPassedTests = (int)dgvLocalDriningLicenseApp.CurrentRow.Cells[5].Value;
            bool LicenseExist = LDLApp.IsLicenseIssued();

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = !LicenseExist && TotalPassedTests == 3;//check LicenseExist here

            editApplicationToolStripMenuItem.Enabled = (!LicenseExist && LDLApp.ApplicationStatus == clsLocalDrivingLicenseApplicationBusinuse.enApplicationStatus.New);

            deleteApplicationToolStripMenuItem.Enabled = LDLApp.ApplicationStatus == clsLocalDrivingLicenseApplicationBusinuse.enApplicationStatus.New;

            cancelApplicationToolStripMenuItem.Enabled = LDLApp.ApplicationStatus == clsLocalDrivingLicenseApplicationBusinuse.enApplicationStatus.New;

            showLicenseToolStripMenuItem.Enabled = LicenseExist;

            bool PassedVisionTest = LDLApp.DoesPassTestType(clsTestTypeBussinuse.enTestType.VisionTest);
            bool passedWritenTest = LDLApp.DoesPassTestType(clsTestTypeBussinuse.enTestType.WrittenTest);
            bool passedStreetTest = LDLApp.DoesPassTestType(clsTestTypeBussinuse.enTestType.StreetTest);

            scheduleTestsToolStripMenuItem.Enabled = (!PassedVisionTest || !passedWritenTest || !passedStreetTest) && (LDLApp.ApplicationStatus == clsApplicationBussinuse.enApplicationStatus.New);

            if (scheduleTestsToolStripMenuItem.Enabled)
            {
                visionToolStripMenuItem.Enabled = !PassedVisionTest;

                writenToolStripMenuItem.Enabled = !passedWritenTest && PassedVisionTest;

                streetToolStripMenuItem.Enabled = !passedStreetTest && passedWritenTest && PassedVisionTest;
            }
               //continue and delete the previose solution...
        }

    }
}
