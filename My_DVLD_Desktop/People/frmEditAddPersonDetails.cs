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

namespace My_DVLD_Desktop
{
    public partial class frmEditAddPersonDetails : Form
    {


        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;


        clsPeopleManagmentBusinuse clsPeople;
        
        int PerID = -1;
        enum enMode { enAdd = 0, enUpdate = 1 };
        enMode Mode = enMode.enUpdate;

        //create form and check if AddNew or Edit.
        public frmEditAddPersonDetails(int PersonID)
        {
            InitializeComponent();
            PerID = PersonID;
            Mode = enMode.enUpdate;
        }

        public frmEditAddPersonDetails()
        {
            InitializeComponent();
            Mode = enMode.enAdd;
        }

        void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountriesBusinuse.GetAllCountries();

            foreach(DataRow row in dt.Rows)
            {
                cmbCountry.Items.Add(row["CountryName"]);
            }
        }

        void _ResetDefualtValues()
        {
            _FillCountriesInComboBox();

            if(Mode == enMode.enAdd)
            {
                clsPeople = new clsPeopleManagmentBusinuse();
                lblAddOrEdit.Text = "Add Person";
            }
            else
            {
                lblAddOrEdit.Text = "Edit Person";
            }

            if(rbtnMale.Checked == true)
            {
                PersonPictur.Image = Resources.Male_512;
            }
            else
            {
                PersonPictur.Image = Resources.Female_512;
            }

            dtpDOB.Value = DateTime.Now.AddYears(-18);
            dtpDOB.MaxDate = dtpDOB.Value;
            dtpDOB.MinDate = DateTime.Now.AddYears(-100);

            txtFName.Text = "";
            txtSName.Text = "";
            txtThName.Text = "";
            txtLName.Text = "";
            txtNationalNo.Text = "";
            rbtnMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            llblRemoveImage.Visible = false;

        }


        void _LoadData()
        {

            if (PerID == -1)
            {
                MessageBox.Show(@"There is no Person with ID ({PersonID}).");
                this.Close();
                return;
            }

            clsPeople = clsPeopleManagmentBusinuse.Find(PerID);

            txtFName.Text = clsPeople.FirstName;
            txtSName.Text = clsPeople.SecondName;
            txtThName.Text = clsPeople.ThirdName;
            txtLName.Text = clsPeople.LastName;
            txtNationalNo.Text = clsPeople.NationalNo;

            if (clsPeople.Gendor == false)
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }

            txtAddress.Text = clsPeople.Address;
            dtpDOB.Text = clsPeople.DateOfBirth.ToString();
            txtEmail.Text = clsPeople.Email;
            txtPhone.Text = clsPeople.Phone;
            //cmbCountry.SelectedItem = cmbCountry.FindString(clsPeople.CountryInfo.CountryName);
            
            cmbCountry.SelectedIndex = cmbCountry.Items.IndexOf(clsPeople.CountryInfo.CountryName);


            if (clsPeople.ImagePath != "")
            {
                PersonPictur.ImageLocation = clsPeople.ImagePath;
                llblRemoveImage.Visible = true;
            }
        }

       
        private void frmEditAddPersonDetails_Load(object sender, EventArgs e)
        {

            _ResetDefualtValues();

            if(Mode == enMode.enUpdate)
            {
                _LoadData();
            }
            
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("There is error in some fieleds","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }//01112223330
            SavePersonData();
            _LoadData();
        }


        void SavePersonData()
        {
            if (!_HandlePersonImage())
                return;

            int NationalCountry = clsCountriesBusinuse.FindCountryByName(cmbCountry.Text).CountryID;
            clsPeople.FirstName = txtFName.Text;
            clsPeople.SecondName = txtSName.Text;
            clsPeople.ThirdName = txtThName.Text;
            clsPeople.LastName = txtLName.Text;
            clsPeople.NationalNo = txtNationalNo.Text;


            if (rbtnFemale.Checked == true)
            {
                clsPeople.Gendor = true;
            }
            else
            {
                clsPeople.Gendor = false;
            }


            clsPeople.Email = txtEmail.Text;
            clsPeople.Phone = txtPhone.Text;
            clsPeople.Address = txtAddress.Text;
            clsPeople.DateOfBirth = DateTime.Parse(dtpDOB.Text);
            clsPeople.NationalityCountryID = NationalCountry;

            if (clsPeople.Save())
            {
                Mode = enMode.enUpdate;
                lblAddOrEdit.Text = "Edit Person";
                lblPersonID.Text = clsPeople.PersonID.ToString();
                MessageBox.Show("Data saved Successfuly.");

                // deligate
                DataBack?.Invoke(this, clsPeople.PersonID);
            }
            else
            {
                MessageBox.Show("Problem while saveing data.");
            }
        }


        bool _HandlePersonImage()
        {

            if(PersonPictur.ImageLocation != clsPeople.ImagePath)
            {

                if(clsPeople.ImagePath != "")
                {
                    try
                    {   
                        File.Delete(clsPeople.ImagePath);
                        clsPeople.ImagePath = "";
                    }
                    catch(Exception ex)
                    {
                        
                    }

                }

                if(PersonPictur.ImageLocation != null)
                {
                    string SourceImageFile = PersonPictur.ImageLocation.ToString();

                    if(clsUtil.CopyImageToProjectImageFile(ref SourceImageFile))
                    {
                        clsPeople.ImagePath = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error copying Image file");
                        return false;
                    }
                    
                }
            }
            return true;
        }

        string ChosePicture()
        {
            string FileLocation;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileLocation = openFileDialog1.FileName;
            }
            else
            {
                FileLocation = "";
            }

            return FileLocation;
        }

        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ImagePath = ChosePicture();

            if(ImagePath != "")
            {
                PersonPictur.ImageLocation = ImagePath;
                llblRemoveImage.Visible = true;
            }
            else
            {
                return;
            }
        }


        private void llblRemoveImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonPictur.ImageLocation = null;

            if (rbtnFemale.Checked)
            {
                PersonPictur.Image = Resources.Female_512;
            }
            else
            {
                PersonPictur.Image = Resources.Male_512;
            }
            llblRemoveImage.Visible = false;
        }

        void ValidateEmptyTextBox(object sender , CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This fieled is required");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        void TextEmailValidating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
                return;

            if (!clsValidation.ValidateEmail(Temp.Text))
            {
                e.Cancel= true;
                errorProvider1.SetError(Temp, "Write valide email");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        void ValidateNationalNoText(object sender,CancelEventArgs e)
        {

            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Fieled is required");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }

            if(txtNationalNo.Text.Trim() != clsPeople.NationalNo && clsPeopleManagmentBusinuse.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "NationalNo is used from another user");
            }
            else
            {
                errorProvider1.SetError(Temp, "");
            }
        }

        private void rbtnMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (PersonPictur.ImageLocation == null)
            {
                PersonPictur.Image = Resources.Male_512;
            }
        }

        private void rbtnFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (PersonPictur.ImageLocation == null)
            {
                PersonPictur.Image = Resources.Female_512;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }


        //////////////////////////////////////////////////////////////////


    }
}
