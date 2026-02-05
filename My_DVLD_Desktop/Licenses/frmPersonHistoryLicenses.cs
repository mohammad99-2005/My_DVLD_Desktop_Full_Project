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

namespace My_DVLD_Desktop.Applications.Licenses
{
    public partial class frmPersonHistoryLicenses : Form
    {
        int _DriverID = -1;
        int _PersonID = -1;
        clsDriversBussiness Driver;
        public frmPersonHistoryLicenses(int PersonID)
        {
            _PersonID = PersonID;
            InitializeComponent();
        }

        public frmPersonHistoryLicenses()
        {
            _PersonID = -1;
        }


        private void frmPersonHistoryLicenses_Load(object sender, EventArgs e)
        {
            
            if(_PersonID != -1)
            {
                ctrlPersonDetailsWithFilter1.LoadPersonInfo(_PersonID);
                ctrlPersonDetailsWithFilter1.ShowFilterBox = false;
                ctrlDriverLicenses1.LoadLicensesByPersonID(_PersonID);
            }
            else
            {
                ctrlPersonDetailsWithFilter1.ShowFilterBox = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonDetailsWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;

            if (_PersonID != -1)
            {
                ctrlDriverLicenses1.LoadLicensesByPersonID(_PersonID);
            }
            else
            {
                ctrlDriverLicenses1.Clear();
            }
        }
    }
}
