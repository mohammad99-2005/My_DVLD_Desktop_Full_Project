using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_Desktop.Applications.Application_Types;
using My_DVLD_Desktop.Applications.International;
using My_DVLD_Desktop.Applications.Licenses;
using My_DVLD_Desktop.Applications.Licenses.DetainReleaseLicense;
using My_DVLD_Desktop.Applications.Local_Driving_License;
using My_DVLD_Desktop.Drivers;
using My_DVLD_Desktop.Global;
using My_DVLD_Desktop.Users;

namespace My_DVLD_Desktop
{
    public partial class MainScreen : Form
    {
        frmLogin _frmLogin;
        public MainScreen(frmLogin frm)
        {
            InitializeComponent();
             _frmLogin = frm;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleManagment peopleManagment = new PeopleManagment();
            peopleManagment.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersManagement frmUsers = new frmUsersManagement();
            frmUsers.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.clsCurrUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(clsGlobal.clsCurrUser.UserID);
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(clsGlobal.clsCurrUser.UserID);
            frm.ShowDialog();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes frm = new ManageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypes frm = new ManageTestTypes();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplication frm = new frmListLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void localLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingLicenseApplication NewLDLApps = new AddNewLocalDrivingLicenseApplication();
            NewLDLApps.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriversList Drivers = new frmDriversList();
            Drivers.ShowDialog();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReNewLicense RenewLicense = new frmReNewLicense();
            RenewLicense.ShowDialog();

        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplication LDLApp_Form = new frmListLocalDrivingLicenseApplication();
            LDLApp_Form.ShowDialog();
        }

        private void replacementForDamagedOrLostLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLicenseForDamageOrLost ReplaceLicense = new frmReplaceLicenseForDamageOrLost();
            ReplaceLicense.ShowDialog();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseLicense = new frmReleaseDetainedLicense();
            ReleaseLicense.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseLicense = new frmReleaseDetainedLicense();
            ReleaseLicense.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses manageDetainedLicenses = new frmManageDetainedLicenses();
            manageDetainedLicenses.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication newInternationalLicenseApplication = new frmNewInternationalLicenseApplication();
            newInternationalLicenseApplication.ShowDialog();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenses ManageInternationalLicenses = new frmManageInternationalLicenses();
            ManageInternationalLicenses.ShowDialog();
        }
    }
}
