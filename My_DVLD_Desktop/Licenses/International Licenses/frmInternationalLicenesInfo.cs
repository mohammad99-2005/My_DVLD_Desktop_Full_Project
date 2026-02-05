using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_DVLD_Desktop.Applications.International
{
    public partial class frmInternationalLicenesInfo : Form
    {

        int _InternationalLicense = -1;
        public frmInternationalLicenesInfo(int InternationalLicense)
        {
            _InternationalLicense = InternationalLicense;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenesInfo_Load(object sender, EventArgs e)
        {
            internationalLicenseInformation1.LoadIntrenationalLicense(_InternationalLicense);
        }
    }
}
