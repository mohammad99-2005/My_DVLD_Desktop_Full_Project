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
    public partial class ctrlPersonDetailsWithFilter : UserControl
    {
        //Make event like KeyPress event or any another event.
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if(handler != null)
            {
                handler(PersonID);
            }
        }

        public ctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private bool _ShowAddPersonButton;
        
        public bool ShowAddPerson
        {
            get { return _ShowAddPersonButton; }
            set
            {
                _ShowAddPersonButton = value;
                btnAddPerson.Visible = _ShowAddPersonButton;
            }
        }

        private bool _ShowFilterBox;

        public bool ShowFilterBox
        {
            get { return _ShowFilterBox; }
            set 
            { 
                _ShowFilterBox = value; 
                gbFilters.Enabled = _ShowFilterBox;
            }
        }

        
        private int _PersonID;

        public int PersonID
        {
            get { return ctrlPersonDetails1.PersonID; }
        }

        public clsPeopleManagmentBusinuse SelectedPersonInfo
        {
            get { return ctrlPersonDetails1.SelectedPersonInfo; }
        }

        public ctrlPersonDetails PersonDetailsControl
        {
            get { return ctrlPersonDetails1; }
        }


        private void ctrlPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            //gbFilters.Enabled = true;
            btnAddPerson.Visible = true;
            cbFilters.SelectedIndex = 1;
            txtSearch.Focus();
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilters.SelectedIndex = 1;
            txtSearch.Text = PersonID.ToString();
            FindPerson();
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {

            if(txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid PersonID or NationalNo.");
                return;
            }

            FindPerson();
        }


        void FindPerson()
        {

            

            switch (cbFilters.SelectedItem.ToString())
            {
                case "National No":

                    ctrlPersonDetails1.LoadPersonInfo(txtSearch.Text);
                    break;

                case "Person ID":

                    ctrlPersonDetails1.LoadPersonInfo(int.Parse(txtSearch.Text));
                    break;

                default:
                    return;
            }

            //if fire event send the data "PersonID".
            if(OnPersonSelected != null)
            {
                OnPersonSelected(ctrlPersonDetails1.PersonID);
            }

        }

        void LoadData(object sender,int PersonID)
        {
            cbFilters.SelectedIndex = 1;
            txtSearch.Text = PersonID.ToString();
            FindPerson();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmEditAddPersonDetails frmAddPerson = new frmEditAddPersonDetails();
            frmAddPerson.DataBack += LoadData;
            frmAddPerson.ShowDialog();
        }

        void TextFilter_ValidateErrors(object sender, EventArgs e)
        {

            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == 13)
            {
                btnFindPerson.PerformClick();
            }

            if (cbFilters.SelectedIndex == 1)
            {
                if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true ;
                }
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void cbFilters_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtSearch, "Enter Valid PersonID or NationalNo.");
            }
            else
            {
                errorProvider1.SetError(txtSearch, null);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrlPersonDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
