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
using My_DVLD_Desktop.Global;
using My_DVLD_Desktop.Properties;

namespace My_DVLD_Desktop.Applications.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _AppointmentID;
        clsTestTypeBussinuse.enTestType _TestType;
        clsTestsBussiness _Test;
        int _TestID = -1;

        public frmTakeTest(int AppointmentID, clsTestTypeBussinuse.enTestType testType)
        {
            InitializeComponent();
            rbtnFail.Checked = true;
            this._AppointmentID = AppointmentID;
            _TestType = testType;

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            scheduledTest1.TestType = _TestType;
            scheduledTest1.LoadInfo(_AppointmentID);

            if (scheduledTest1.AppointmentTestID == -1)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled =true;
            }

            _TestID = scheduledTest1.TestID;
            

            if (_TestID != -1)
            {
                _Test = clsTestsBussiness.FindTestByTestID(_TestID);

                if (_Test.TestResult == true)
                {
                    rbtnPass.Checked = true;
                }
                else
                {
                    rbtnFail.Checked = true;
                }
                txtbNotes.Text = _Test.Notes;

                lblUserMessage.Visible = true;
                rbtnFail.Enabled = false;
                rbtnPass.Enabled = false;
            }
            else
            {
                _Test = new clsTestsBussiness();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.",
                      "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No
             )
            {
                return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbtnFail.Checked ? false : true;
            _Test.Notes = txtbNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.clsCurrUser.UserID;

            //_Appointment.IsLocked = true;
            //_Appointment.Save();//      Handled in _Test.Save(); in database by query.


            if (_Test.Save())
            {
                MessageBox.Show("Result Saved Successfuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
