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
    public partial class frmChangeUserPassword : Form
    {
        int _UserID = -1;
        clsUsersManagemetsBussiness clsUser;
        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            this._UserID = UserID;
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            clsUser = clsUsersManagemetsBussiness.Find(_UserID);

            _ResetDefaoltData();
            if (clsUser == null)
            {
                MessageBox.Show("Could Not find user with UserID (" + _UserID + ")", "Error");
                this.Close();
                return;
            }

            ctrlUserDetails1.LoadUserData(this._UserID);

        }

        void _ResetDefaoltData()
        {
            txtbCurrentPass.Text = string.Empty;
            txtbNewPassword.Text = string.Empty;
            txtbConfirmePassword.Text = string.Empty;
            txtbCurrentPass.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox TB = (TextBox)sender;

            if(TB.Text.Trim()=="" )
            {
                e.Cancel = true;
                errorProvider1.SetError(TB, "This fieled is required");
            }
            else
            {
                errorProvider1.SetError(TB, "");
            }
        }

        void ValidateCurrentPassword(object sender, CancelEventArgs e)
        {
            clsUsersManagemetsBussiness clsUsers = clsUsersManagemetsBussiness.Find(_UserID);

            if (txtbCurrentPass.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbCurrentPass, "This fieled is required");
            }
            else
            {
                errorProvider1.SetError(txtbCurrentPass, "");
            }

            if (clsUsers.Password != txtbCurrentPass.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbCurrentPass, "Wrong Password");
            }
            else
            {
                errorProvider1.SetError(txtbCurrentPass, "");
            }
        }

        void ValidateConfirmPassword(object sender , CancelEventArgs e)
        {
            if(txtbConfirmePassword.Text != txtbNewPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbConfirmePassword, "It must be match with New Password field");
            }
            else
            {
                errorProvider1.SetError(txtbConfirmePassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                MessageBox.Show("There is errors in some fields","Error");
                return;
            }
            
            clsUser.Password = txtbNewPassword.Text;

            if (clsUser.Save())
            {
                MessageBox.Show("Saved Succesfuly");
                _ResetDefaoltData();
            }
            else
            {
                MessageBox.Show("Problem while saveing the user data");
            }
        }
    }
}
