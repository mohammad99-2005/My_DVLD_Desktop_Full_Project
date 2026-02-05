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

namespace My_DVLD_Desktop.Users
{
    public partial class frmAddEditNewUser : Form
    {
        enum enMode { enUpdate = 0, enAddNew = 1 }

        enMode mode = enMode.enUpdate;

        clsUsersManagemetsBussiness clsUser;

        int _PersonID = -1;

        public frmAddEditNewUser()
        {
            InitializeComponent();
            mode = enMode.enAddNew;
        }

        public frmAddEditNewUser(int PersonID)
        {
            InitializeComponent();
            mode = enMode.enUpdate;
            _PersonID = PersonID;
        }

        void _LoadUserData()
        {

            clsUser = clsUsersManagemetsBussiness.FindByPersonID(_PersonID);

            if (clsUser == null)
            {
                MessageBox.Show("There is no person with PersonID :(" + _PersonID + ")");
                this.Close();
                return;
            }
            else
            {
                ctrlPersonDetailsWithFilter1.PersonDetailsControl.LoadPersonInfo(_PersonID);
                lblUserID.Text = clsUser.UserID.ToString();
                txtbUsername.Text = clsUser.Username;
                txtbPassword.Text = clsUser.Password;
                txtbConfirmePassword.Text = clsUser.Password;
                cbIsActive.Checked = clsUser.IsActive;
            }
        }

        void _ResetDefaultData()
        {
            if(mode == enMode.enUpdate)
            {
                
                lblAddOrEdit.Text = "Edit User Info";
                ctrlPersonDetailsWithFilter1.ShowFilterBox = false;
                this.Text = lblAddOrEdit.Text;
                
            }
            else
            {
                clsUser = new clsUsersManagemetsBussiness();
                lblAddOrEdit.Text = "Add New User";
                this.Text = lblAddOrEdit.Text;
                ctrlPersonDetailsWithFilter1.ShowFilterBox = true;
                
            }

            txtbUsername.Text = "";
            txtbPassword.Text = "";
            txtbConfirmePassword.Text = "";
            cbIsActive.Checked = false;
        }

        private void frmAddEditNewUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultData();
            if(mode == enMode.enUpdate) 
            {
                _LoadUserData();
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            if (mode == enMode.enAddNew)
            {

                if (ctrlPersonDetailsWithFilter1.PersonID != -1)
                {
                    if ((clsUsersManagemetsBussiness.FindByPersonID(ctrlPersonDetailsWithFilter1.PersonID)) != null)
                    {
                        MessageBox.Show("This User allready exist");
                        return;
                    }
                    else
                    {
                        tpLoginInfo.Enabled = true;
                        btnSave.Enabled = true;
                        tpAddEditUsers.SelectedTab = tpAddEditUsers.TabPages["tpLoginInfo"];
                    }
                }
            }
            else
            {
                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
                tpAddEditUsers.SelectedTab = tpAddEditUsers.TabPages["tpLoginInfo"];
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Fieled is required");
            }
            else
            {
                errorProvider1.SetError(Temp, "");
            }

        }

        void ValidateUsername(object sender, CancelEventArgs e)
        {

            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Fieled is required");
            }
            else
            {
                errorProvider1.SetError(Temp, "");
            }

            if(mode == enMode.enAddNew)
            {
                if (clsUsersManagemetsBussiness.IsUserExist(Temp.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(Temp, "Username already used by another user.");
                }
                else
                {
                    errorProvider1.SetError(Temp, "");
                }
            }
            else
            {
                if(clsUser.Username != txtbUsername.Text)
                {
                    if (clsUsersManagemetsBussiness.IsUserExist(Temp.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(Temp, "Username already used by another user.");
                    }
                    else
                    {
                        errorProvider1.SetError(Temp, "");
                    }
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Fill All blank Text Box");
                return;
            }

            if (txtbPassword.Text.Trim() != txtbConfirmePassword.Text.Trim())
            {
                MessageBox.Show("Password Confirmation Does not match Password!");
                errorProvider1.SetError(txtbConfirmePassword, "Should be equal to Password fieled");
                return;
            }
            else
            {
                errorProvider1.SetError(txtbConfirmePassword, "");

                clsUser.PersonID = ctrlPersonDetailsWithFilter1.PersonID;
                clsUser.Username = txtbUsername.Text;
                clsUser.Password = txtbPassword.Text;
                clsUser.IsActive = cbIsActive.Checked;

                if (clsUser.Save())
                {
                    lblAddOrEdit.Text = "Edit User Info";
                    lblUserID.Text = clsUser.UserID.ToString();
                    mode = enMode.enUpdate;
                    this.Text = "Edit User Info";
                    MessageBox.Show("User Saved Succesfuly");

                }
                else
                {
                    MessageBox.Show("Failed to save data");
                }
            }
        }
    }
}
