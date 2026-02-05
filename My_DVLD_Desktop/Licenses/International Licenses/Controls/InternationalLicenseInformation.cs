using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using My_DVLD_Desktop.Properties;

namespace My_DVLD_Desktop.Applications.International.Controls
{
    public partial class InternationalLicenseInformation : UserControl
    {
        int _InternationalLicenseID = -1;
        clsInternationalLicensesBussinuss _InternationalLicenses;
        public InternationalLicenseInformation()
        {
            InitializeComponent();
        }

        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }

        public clsInternationalLicensesBussinuss InternationalLicense
        {
            get { return _InternationalLicenses; }
        }

        private void LoadPicture()
        {
            if (_InternationalLicenses.DriverInfo.Person.Gendor == true)
            {
                pbPersonImage.Image = Resources.Female_512;
            }
            else
            {
                pbPersonImage.Image = Resources.Male_512;
            }

            string ImagePath = _InternationalLicenses.DriverInfo.Person.ImagePath;

            if(ImagePath != "")
            {
                if(File.Exists(ImagePath))
                {
                    pbPersonImage.ImageLocation = ImagePath;
                }
            }
        }

        public void LoadIntrenationalLicense(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicenses = clsInternationalLicensesBussinuss.FindInternationalLicenseByID(_InternationalLicenseID);

            if( _InternationalLicenses == null )
            {
                MessageBox.Show("Could not find International License ID = " + _InternationalLicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            
            lblInternationalLicenseID.Text = _InternationalLicenses.InternationalLicenseID.ToString();
            lblFullName.Text = _InternationalLicenses.DriverInfo.Person.FullName.ToString();
            lblLocalLicenseID.Text = _InternationalLicenses.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _InternationalLicenses.DriverInfo.Person.NationalNo.ToString();
            if( _InternationalLicenses.DriverInfo.Person.Gendor == true)
            {
                lblGendor.Text = "Female";
                pbGendor.Image = Resources.Woman_32;
            }
            else
            {
                lblGendor.Text = "Male";
                pbGendor.Image= Resources.Man_32;
            }
            lblIssueDate.Text = _InternationalLicenses.IssueDate.ToString();
            lblApplicationID.Text = _InternationalLicenses.ApplicationID.ToString();
            if (_InternationalLicenses.IsActive == true)
            {
                lblIsActive.Text = "Yes";
            }
            else
            {
                lblIsActive.Text = "No";
            }
            lblDateOfBirth.Text = _InternationalLicenses.DriverInfo.Person.DateOfBirth.ToString();
            lblDriverID.Text = _InternationalLicenses.DriverID.ToString();
            lblExpirationDate.Text = _InternationalLicenses.ExpirationDate.ToString();
            LoadPicture();
        }
    }
}
