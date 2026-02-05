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

namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    public partial class AddNewLocalDrivingLicenseApplication : Form
    {

        enum enMode { enUpdate = 0, enAddNew = 1 }
        enMode mode = enMode.enUpdate;

        private int _LDLAppID = -1;
        private int _SelectedPersonID = -1;

        clsLocalDrivingLicenseApplicationBusinuse LDLApp;

        public AddNewLocalDrivingLicenseApplication()
        {
            mode = enMode.enAddNew;
            InitializeComponent();
        }

        public AddNewLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            _LDLAppID = LocalDrivingLicenseApplicationID;
            mode = enMode.enUpdate;
            InitializeComponent();

        }

        void _LoadData()
        {
            ctrlPersonDetailsWithFilter1.Enabled = false;
            LDLApp = clsLocalDrivingLicenseApplicationBusinuse.FindByLocalDrivingLicenseApplicationID(_LDLAppID);

            if (LDLApp == null)
            {
                MessageBox.Show("There is no Local Driving License Application with ID :(" + _LDLAppID + ")", "Wronge Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonDetailsWithFilter1.PersonDetailsControl.LoadPersonInfo(LDLApp.Person.PersonID);
            lblDLAppID.Text = LDLApp.LDLAppID.ToString();
            lblAppDate.Text = LDLApp.ApplicationDate.ToString();//clsFormat......******??????
            cbLicenseClasses.SelectedIndex = cbLicenseClasses.FindString(clsLicenseClassesBussinuse.Find(LDLApp.LicenseCLassID).ClassName);
            lblAppFees.Text = LDLApp.PaidFees.ToString();
            lblCreatedBy.Text = LDLApp.CreatedByUserInfo.Username.ToString();

        }

        private void DataBackEvent(object sender, int PersonID)
        {
            //Handle the data received
            _SelectedPersonID = PersonID;
            ctrlPersonDetailsWithFilter1.LoadPersonInfo(PersonID);
        }


        private void _FillLicenseClassesInComboBox()
        {
            DataTable dt = clsLicenseClassesBussinuse.GetAllLicenseClasses();
            foreach (DataRow dr in dt.Rows)
            {
                cbLicenseClasses.Items.Add(dr["ClassName"]);
            }
        }

        private void _ResetDefaultValues()
        {
            

            if (mode == enMode.enAddNew)
            {
                tbLocalDriningLicense.Enabled = true;
                tpPersonInfo.Enabled= true;
                ctrlPersonDetailsWithFilter1.ShowAddPerson = true;
                ctrlPersonDetailsWithFilter1.ShowFilterBox = true;
                lblAddOrEdit.Text = "Add New Local Driving License Application";
                this.Text = "Add New Local Driving License Application";
                ctrlPersonDetailsWithFilter1.Focus();
                //tbLocalDriningLicense.Enabled = false;//check this

                cbLicenseClasses.SelectedIndex = 2;
                lblAppDate.Text = DateTime.Now.ToString();
                lblAppFees.Text = clsApplicationTypesBusinuse.Find(1).ApplicationTypeFees.ToString();
                lblCreatedBy.Text = clsGlobal.clsCurrUser.Username.ToString();
            }
            else
            {
                tpPersonInfo.Enabled = true;
                lblAddOrEdit.Text = "Edit Local Driving License Application";
                this.Text = "Edit Local Driving License Application";

                tbLocalDriningLicense.Enabled = true;//check this
                btnSave.Enabled = true;
            }
        }

        private void AddNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _FillLicenseClassesInComboBox();
            _ResetDefaultValues();

            if (mode == enMode.enUpdate)
            {
                _LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mode == enMode.enUpdate)
            {
                btnSave.Enabled = true;
                tbLocalDriningLicense.Enabled = true;
                tbLocalDriningLicense.SelectedTab = tbLocalDriningLicense.TabPages["tpNewLDLApp"];
            }
            else
            {
                if (ctrlPersonDetailsWithFilter1.SelectedPersonInfo != null)
                {
                    if ((DateTime.Now.Year - ctrlPersonDetailsWithFilter1.SelectedPersonInfo.DateOfBirth.Year) < 18)
                    {
                        MessageBox.Show("Your age should be more than or equal to 18[Y].");
                        return;
                    }

                    btnSave.Enabled = true;
                    tbLocalDriningLicense.Enabled = true;
                    tbLocalDriningLicense.SelectedTab = tbLocalDriningLicense.TabPages["tpNewLDLApp"];
                }
                else
                {
                    MessageBox.Show("You Should Chose Person");
                    ctrlPersonDetailsWithFilter1.Focus();
                    return;
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int PersonID = ctrlPersonDetailsWithFilter1.PersonID;

            int ActiveAppNum = clsLocalDrivingLicenseApplicationBusinuse.GetActiveApplicationIDForLicenseClass(PersonID, clsLocalDrivingLicenseApplicationBusinuse.enApplicationType.NewDrivingLicense, cbLicenseClasses.SelectedIndex + 1);
            if (ActiveAppNum != -1)
            {
                MessageBox.Show("This Person already has Application of local Driving license with-\nLicense Class " + cbLicenseClasses.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClasses.Focus();
                return;
            }

            //check if person has license from the same type

            if (clsLicensesBussinese.IsLicenseExistByPersonID(PersonID,clsLicenseClassesBussinuse.Find(cbLicenseClasses.Text).LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //from me to check if it enAddNew or enUpdate
            if (mode == enMode.enAddNew)
            {
                LDLApp = new clsLocalDrivingLicenseApplicationBusinuse();

                LDLApp.ApplicationPersonID = PersonID;
                LDLApp.ApplicationDate = DateTime.Now;
                LDLApp.ApplicationTypeID = 1;
                LDLApp.ApplicationStatus = clsLocalDrivingLicenseApplicationBusinuse.enApplicationStatus.New;
                LDLApp.LastStatusDate = DateTime.Now;
                LDLApp.PaidFees = clsApplicationTypesBusinuse.Find(cbLicenseClasses.SelectedIndex + 1).ApplicationTypeFees;
                LDLApp.CreatedByUserID = clsGlobal.clsCurrUser.UserID;
                LDLApp.LicenseCLassID = cbLicenseClasses.SelectedIndex + 1;

            }
            else
            {
                LDLApp.LicenseCLassID = cbLicenseClasses.SelectedIndex + 1;
            }

            if (LDLApp.Save())
            {
                lblDLAppID.Text = LDLApp.LDLAppID.ToString();
                mode = enMode.enUpdate;
                lblAddOrEdit.Text = "Update Local Driving License Application";
                MessageBox.Show("Local Driving License Application Saved Successfuly!!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Local Driving License Application Does Not Save Successfuly!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonDetailsWithFilter1.Focus();
        }

        private void ctrlPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }
    }
}
