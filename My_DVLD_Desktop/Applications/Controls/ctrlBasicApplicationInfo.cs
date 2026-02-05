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
using My_DVLD_Desktop.Applications.Local_Driving_License;

namespace My_DVLD_Desktop.Applications.Tests.Test_Types
{
    public partial class ctrlBasicApplicationInfo : UserControl
    {

        clsApplicationBussinuse App;
        int _ApplicationID = -1;

        public int ApplicationID
        {
            get { return _ApplicationID; }
        }

        public ctrlBasicApplicationInfo()
        {
            InitializeComponent();
        }

        private void llblPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personInfo = new frmPersonDetails(App.Person.PersonID);
            personInfo.ShowDialog();
        }

        public void LoadApplicationInfoByApplicationID(int ApplicationID)
        {
            App = clsApplicationBussinuse.FindBaseApplication(ApplicationID);
            _ApplicationID = ApplicationID;
            if(App == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + ApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FillApplicationInfo();
            }
        }


        private void FillApplicationInfo()
        {
            lblID.Text = App.ApplicationID.ToString();
            lblStatus.Text = App.ApplicationStatus.ToString();
            lblFees.Text = App.PaidFees.ToString();
            lblType.Text = App.ApplicationTypeInfo.ApplicationTypeTitle;
            lblApplicant.Text = App.Person.FullName;
            lblDate.Text = App.ApplicationDate.ToString();
            lblStatusDate.Text = App.LastStatusDate.ToString();
            lblCreatedBy.Text = App.CreatedByUserInfo.Username.ToString();
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            lblID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblType.Text = "[????]";
            lblFees.Text = "[????]";
            lblApplicant.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedBy.Text = "[????]";
        }

    }
}
