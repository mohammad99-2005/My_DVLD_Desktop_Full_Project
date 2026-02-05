using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using My_DVLD_Desktop.Properties;

namespace My_DVLD_Desktop
{
    public partial class ctrlPersonDetails : UserControl
    {
        private int _PersonID = -1;
        clsPeopleManagmentBusinuse clsPeople;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPeopleManagmentBusinuse SelectedPersonInfo
        {
            get { return  clsPeople; }
        }


        public ctrlPersonDetails()
        {
            InitializeComponent();
        }


        public void LoadPersonInfo(int PersonID)
        {
            clsPeople = clsPeopleManagmentBusinuse.Find(PersonID);

            if (clsPeople == null)
            {
                ResetPersonInfo();
                MessageBox.Show("There is no person with ID : (" + PersonID + ") .");
                return;
            }
            _FillPersonDetails(PersonID);
        }

        public void LoadPersonInfo(string NationalNo)
        {
            clsPeople = clsPeopleManagmentBusinuse.Find(NationalNo);

            if (clsPeople.PersonID == -1)
            {
                ResetPersonInfo();
                MessageBox.Show("There is no person with National No : (" + NationalNo + ") .");
                return;
            }
            _FillPersonDetails(clsPeople.PersonID);
        }

        private void _LoadPicture()
        {
            if (clsPeople.ImagePath != "")
            {
                picPersonImage.Load(clsPeople.ImagePath);
            }
            else
            {
                if (clsPeople.Gendor == false)
                {
                    picPersonImage.Image = Resources.Male_512;
                }
                else
                {
                    picPersonImage.Image = Resources.Female_512;
                }
            }
        }
        

        private void _FillPersonDetails(int PersonID)
        {
            clsPeopleManagmentBusinuse clsPeople = clsPeopleManagmentBusinuse.Find(PersonID);
            clsCountriesBusinuse clsCounties = clsCountriesBusinuse.FindCountryByID(clsPeople.NationalityCountryID);

            _PersonID = PersonID;
            lblPersonID.Text = PersonID.ToString();
            lblName.Text = clsPeople.FullName;
            lblNationalNo.Text = clsPeople.NationalNo.ToString();
            lblGendor.Text = ((clsPeople.Gendor == false) ? "Male" : "Female");
            lblDOB.Text = clsPeople.DateOfBirth.ToString();
            lblAddress.Text = clsPeople.Address.ToString();
            lblCountry.Text = clsCounties.CountryName;
            lblEmail.Text = clsPeople.Email.ToString();
            lblPhone.Text = clsPeople.Phone.ToString();
            _LoadPicture();
            
        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblName.Text = "[????]";
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDOB.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            picPersonImage.Image = Resources.Male_512;

        }

        void ReloadData(object sender , int PersonID)
        {
            _FillPersonDetails(PersonID);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEditAddPersonDetails frm = new frmEditAddPersonDetails(clsPeople.PersonID);
            frm.DataBack += ReloadData;
            frm.ShowDialog();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
