using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using My_DVLD_Desktop.Properties;

namespace My_DVLD_Desktop.Applications.Licenses.Controls
{
    public partial class ctrlLicenseInfo : UserControl
    {

        int _LicenseID = -1;
        clsLicensesBussinese _License = null;
        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get { return _LicenseID; }
        }

        public clsLicensesBussinese SelectedLicenseInfo
        {
            get { return _License; }
        }

        private void LoadPersonPecture()
        {
            if (_License.DriverInfo.Person.Gendor == false)
                pbDriverPicture.Image = Resources.Male_512;
            else 
                pbDriverPicture.Image= Resources.Female_512;

            string ImagePath = _License.DriverInfo.Person.ImagePath;

            if(ImagePath != "")
            {
                if (File.Exists(ImagePath))
                {
                    pbDriverPicture.Load(ImagePath);
                }
                else
                {
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void LoadInfo(int LicenseID)
        {
             _LicenseID = LicenseID;
             _License = clsLicensesBussinese.FindLicense(LicenseID);


            if (_License != null)
            {
                lblClass.Text = _License.LicenseCLassInfo.ClassName.ToString();
                lblName.Text = _License.DriverInfo.Person.FullName.ToString();
                lblLicenseID.Text = _License.LicenseID.ToString();
                lblNationalNo.Text = _License.DriverInfo.Person.NationalNo.ToString();

                if (_License.DriverInfo.Person.Gendor == false)

                    lblGendor.Text = "Male";
                else
                    lblGendor.Text = "Female";

                lblIssueDate.Text = _License.IssueDate.ToString();
                lblIssueReason.Text = _License.IssueReasonText;
                lblExpirationDate.Text = _License.ExpirationDate.ToString();
                lblNote.Text = _License.Notes.ToString();

                if (_License.IsActive == true)
                    lblIsActive.Text = "Yes";
                else
                    lblIsActive.Text = "No";


                if(_License.IsDetained == true)
                {
                    lblIsDetained.Text = "Yes";
                }
                else
                {
                    lblIsDetained.Text = "No";
                }

                lblDateOfBirth.Text = _License.DriverInfo.Person.DateOfBirth.ToString();
                lblDriverID.Text = _License.DriverID.ToString();
                LoadPersonPecture();
            }
            else
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }
        }
    }
}
