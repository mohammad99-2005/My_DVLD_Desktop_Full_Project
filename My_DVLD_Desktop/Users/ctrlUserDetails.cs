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
    public partial class ctrlUserDetails : UserControl
    {
        public ctrlUserDetails()
        {
            InitializeComponent();
        }

        clsUsersManagemetsBussiness clsUser;
        int _UserID = -1;

        private void ctrlUserDetails_Load(object sender, EventArgs e)
        {

        }

        public void LoadUserData(int UserID)
        {
            clsUser = clsUsersManagemetsBussiness.Find(UserID);
            if (clsUser == null)
            {
                MessageBox.Show("There is no person with User ID (" + UserID + ")");
                return;
            }
            LoadData();

        }

        void LoadData()
        {
            _UserID = clsUser.UserID;

            ctrlPersonDetails1.LoadPersonInfo(clsUser.PersonID);
            lblUserID.Text = clsUser.UserID.ToString();
            lblUsername.Text = clsUser.Username;
            lblIsActive.Text = clsUser.IsActive ? "yes" : "No";
        }

        void _ResetDefaultData()
        {
            ctrlPersonDetails1.ResetPersonInfo();
            lblUserID.Text = "";
            lblUsername.Text = "";
            lblIsActive.Text = "";
        }
    }
}
