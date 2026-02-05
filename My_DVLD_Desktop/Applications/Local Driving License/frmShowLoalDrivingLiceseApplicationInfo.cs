using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    public partial class frmShowLoalDrivingLiceseApplicationInfo : Form
    {
        int _LocalDrivingLicenseApplicationID = -1;
        public frmShowLoalDrivingLiceseApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmShowLoalDrivingLiceseApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
