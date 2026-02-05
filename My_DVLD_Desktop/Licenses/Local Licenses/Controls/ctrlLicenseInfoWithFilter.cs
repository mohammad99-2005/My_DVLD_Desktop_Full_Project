using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;

namespace My_DVLD_Desktop.Applications.Licenses.Controls
{
    public partial class ctrlLicenseInfoWithFilter : UserControl
    {

        int _LicenseID = -1;

        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if(handler != null)
            {
                handler(LicenseID);
            }


        }// this function to prevent the Race Condition.
         //instade of this function we can use """OnLicenseSelected?.Invoke(LicenseID);"""-> we can use it instade of call the function.


        public ctrlLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled = value;
                gbFilterbox.Enabled = value;
            }
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicensesBussinese SelectedLicenseInfo
        {
            get { return ctrlLicenseInfo2.SelectedLicenseInfo; }
        }

        public void LoadInfo(int LicenseID)
        {

            txtbLicenseID.Text = LicenseID.ToString();
            ctrlLicenseInfo2.LoadInfo(LicenseID);
            _LicenseID = ctrlLicenseInfo2.LicenseID;
            if(OnLicenseSelected != null && FilterEnabled)
            {
                OnLicenseSelected(LicenseID);
                // we can use this--->>> {{ OnLicenseSelected?.Invoke(LicenseID); }} to prevent the Race Condition.
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbLicenseID.Focus();
                return;
            }

            _LicenseID = int.Parse(txtbLicenseID.Text);
            LoadInfo(LicenseID);

        }

        public void txtLicenseIDFocus()
        {
            txtbLicenseID.Focus();
        }

        private void txtbLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtbLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbLicenseID, "This field required");
            }
            else
            {
                errorProvider1.SetError(txtbLicenseID, null);
            }
        }

        private void txtbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if(e.KeyChar == (char)13)
            {
                button1.PerformClick();
            }
        }
    }
}
