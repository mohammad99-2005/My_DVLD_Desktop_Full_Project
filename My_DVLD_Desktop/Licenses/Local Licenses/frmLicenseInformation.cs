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

namespace My_DVLD_Desktop.Applications.Licenses
{
    public partial class frmLicenseInformation : Form
    {
        private int _LicenseID = -1;
        public frmLicenseInformation(int LicenseID)
        {
            _LicenseID = LicenseID;
            InitializeComponent();
        }

        private void frmLicenseInformation_Load(object sender, EventArgs e)
        {
            ctrlLicenseInfo2.LoadInfo(_LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
