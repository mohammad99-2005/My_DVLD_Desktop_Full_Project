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

namespace My_DVLD_Desktop.Applications.Test_Types
{
    public partial class EditTestTypes : Form
    {
        clsTestTypeBussinuse.enTestType _TestTypeID = clsTestTypeBussinuse.enTestType.VisionTest;
        clsTestTypeBussinuse clsTestType;
        public EditTestTypes(clsTestTypeBussinuse.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        void TestTypeTitle_Validate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbTestTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbTestTitle, "Should'nt  be Empty");
            }
            else
            {
                errorProvider1.SetError(txtbTestTitle, "");
            }
        }

        void TestTypeFees_Validate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbTestFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbTestFees, "Should not be Empty");
            }
            else
            {
                errorProvider1.SetError(txtbTestFees, "");
            }

            if (!clsValidation.IsNumber(txtbTestFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtbTestFees, "Should Write Number");
            }
            else
            {
                errorProvider1.SetError(txtbTestFees, "");
            }
        }


        private void EditTestTypes_Load(object sender, EventArgs e)
        {
            clsTestType = clsTestTypeBussinuse.Find(_TestTypeID);

            if (clsTestType != null)
            {
                lblTestID.Text = ((int)clsTestType.ID).ToString();
                txtbTestTitle.Text = clsTestType.TestTypeTitle;
                txtbTestDesc.Text = clsTestType.TestTypeDescription;
                txtbTestFees.Text = clsTestType.TestTypeFees.ToString();
            }
            else
            {
                MessageBox.Show("Error in Test Type");
                this.Close();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                MessageBox.Show("There is error in data you enterd");
                return;
            }

            clsTestType.TestTypeTitle = txtbTestTitle.Text;
            clsTestType.TestTypeDescription = txtbTestDesc.Text;
            clsTestType.TestTypeFees = Convert.ToInt32(txtbTestFees.Text);

            if (clsTestType.Save())
            {
                MessageBox.Show("Saved Succesfuly");
            }
            else
            {
                MessageBox.Show("Failed To Save");
            }
        }
    }
}
