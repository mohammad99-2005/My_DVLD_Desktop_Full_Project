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
using My_DVLD_Desktop.Applications.Licenses;

namespace My_DVLD_Desktop.Drivers.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        int _DriverID = -1;
        DataTable _dtLocalDrivingLicenses;
        DataTable _dtInternationalLicenses;
        clsDriversBussiness _Driver;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        void LoadLocalHistoryLicense()
        {
             _dtLocalDrivingLicenses= clsLicensesBussinese.GetLicensesToDriver(_DriverID);

            dgvLocal.DataSource = _dtLocalDrivingLicenses;

            dgvLocal.Columns[0].HeaderText = "Lic.ID";
            dgvLocal.Columns[0].Width = 100;

            dgvLocal.Columns[1].HeaderText = "App.ID";
            dgvLocal.Columns[1].Width = 100;

            dgvLocal.Columns[2].HeaderText = "Class Name";
            dgvLocal.Columns[2].Width = 250;

            dgvLocal.Columns[3].Width = 130;
            dgvLocal.Columns[3].HeaderText = "Issue Date";

            dgvLocal.Columns[4].Width = 130;
            dgvLocal.Columns[4].HeaderText = "Expiration Date";

            dgvLocal.Columns[5].Width = 110;
            dgvLocal.Columns[5].HeaderText = "Is Active";

            lblCountLocal.Text = _dtLocalDrivingLicenses.Rows.Count.ToString();
        }

        void LoadInternationalHistoryLicense()
        {
            _dtInternationalLicenses = clsInternationalLicensesBussinuss.GetInternationalLicesesToDriver(_DriverID);

            dgvInternational.DataSource = _dtLocalDrivingLicenses;

            dgvInternational.Columns[0].HeaderText = "I.L.ID";
            dgvInternational.Columns[0].Width = 110;

            dgvInternational.Columns[1].HeaderText = "App.ID";
            dgvInternational.Columns[1].Width = 110;

            dgvInternational.Columns[2].HeaderText = "L.L.ID";
            dgvInternational.Columns[2].Width = 260;

            dgvInternational.Columns[3].Width = 155;
            dgvInternational.Columns[3].HeaderText = "Issue Date";

            dgvInternational.Columns[4].Width = 155;
            dgvInternational.Columns[4].HeaderText = "Expiration Date";

            dgvInternational.Columns[5].Width = 110;
            dgvInternational.Columns[5].HeaderText = "Is Active";

            dgvInternational.DataSource = _dtInternationalLicenses;
            lblCountInternational.Text = dgvInternational.Rows.Count.ToString();
        }

        public void LoadLicenses(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriversBussiness.FindDriver(DriverID);

            if (_Driver == null)
            {
                MessageBox.Show("There is no Driver with Driver ID:(" + DriverID + ")");
                return;
            }
            
            LoadLocalHistoryLicense();
            LoadInternationalHistoryLicense();
        }

        public void LoadLicensesByPersonID(int PersonID)
        {
            _Driver = clsDriversBussiness.FindDriverByPersonID(PersonID);
            _DriverID = _Driver.DriverID;

            if (_Driver == null )
            {
                MessageBox.Show("There is no Driver linked with Person ID:(" + PersonID + ")");
                return;
            }

            LoadLocalHistoryLicense();
            LoadInternationalHistoryLicense();

        }

        public void Clear()
        {
            _dtLocalDrivingLicenses.Clear();
        }


        private void driverLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvLocal.CurrentRow.Cells[0].Value);
            frmLicenseInformation license = new frmLicenseInformation(LicenseID);
            license.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvInternational.CurrentRow.Cells[2].Value);
            frmLicenseInformation license = new frmLicenseInformation(LicenseID);
            license.ShowDialog();
        }
    }
}
