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

namespace My_DVLD_Desktop
{
    public partial class frmEditApplicationType : Form
    {
        int _ApplicationID = -1;

        clsApplicationTypesBusinuse clsApplication; 
        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            clsApplication = clsApplicationTypesBusinuse.Find(_ApplicationID);

            if(clsApplication != null)
            {
                lblAppID.Text = _ApplicationID.ToString();
                txtbAppTitle.Text = clsApplication.ApplicationTypeTitle;
                txtbAppFees.Text = clsApplication.ApplicationTypeFees.ToString();
                txtbAppTitle.Focus();
            }   
        }

        void ApplicationType_Validate(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtbAppTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbAppTitle, "Should'nt  be Empty");
            }
            else
            {
                errorProvider1.SetError(txtbAppTitle, "");
            }
        }

        void ApplicationTypeFees_Validate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbAppFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbAppFees, "Should not be Empty");
            }
            else
            {
                errorProvider1.SetError(txtbAppFees, "");
            }

            if (!clsValidation.IsNumber(txtbAppFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbAppFees, "Should Write Number");
            }
            else
            {
                errorProvider1.SetError(txtbAppFees, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                MessageBox.Show("There is error in data you enterd");
                return;
            }

            clsApplication.ApplicationTypeFees =Convert.ToInt32(txtbAppFees.Text.Trim());
            clsApplication.ApplicationTypeTitle = txtbAppTitle.Text;

            if (clsApplication.Save())
            {
                MessageBox.Show("Data Saved Succesfuly");

            }
            else
            {
                MessageBox.Show("Failed to save data");
            }
        }

    }
}
