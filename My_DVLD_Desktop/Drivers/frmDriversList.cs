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

namespace My_DVLD_Desktop.Drivers
{
    public partial class frmDriversList : Form
    {
        DataTable dt;
        public frmDriversList()
        {
            InitializeComponent();
            cbDriversFilter.SelectedIndex = 0;
        }

        private void cbDriversFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDriversFilter.SelectedIndex == 0)
            {
                txtbDriverFilterValue.Visible = false;
            }
            else
            {
                txtbDriverFilterValue.Visible = true;
                txtbDriverFilterValue.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            return;
        }

        void _ResetDriversList()
        {
            dt = clsDriversBussiness.GetAllDriversWithPersonalInfo();
            dgvDrivers.DataSource = dt;

            dgvDrivers.Columns[0].HeaderText = "Driver ID";
            dgvDrivers.Columns[0].Width = 120;

            dgvDrivers.Columns[1].HeaderText = "Person ID";
            dgvDrivers.Columns[1].Width = 120;

            dgvDrivers.Columns[2].HeaderText = "National No";
            dgvDrivers.Columns[2].Width = 120;

            dgvDrivers.Columns[3].HeaderText = "Full Name";
            dgvDrivers.Columns[3].Width = 265;

            dgvDrivers.Columns[4].HeaderText = "Created Date";
            dgvDrivers.Columns[4].Width = 170;

            dgvDrivers.Columns[5].HeaderText = "Active Licenses";
            dgvDrivers.Columns[5].Width = 120;
            
            lblCount.Text = dgvDrivers.Rows.Count.ToString();
        }

        private void frmDriversList_Load(object sender, EventArgs e)
        {
            _ResetDriversList();
        }

        private void txtbDriverFilterValue_TextChanged(object sender, EventArgs e)
        {
            dt = clsDriversBussiness.GetAllDriversWithPersonalInfo();
            
            if(txtbDriverFilterValue.Text.Trim() == "")
            {
                dt.DefaultView.RowFilter = "";
                dgvDrivers.DataSource =  dt;
                lblCount.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }

            if(cbDriversFilter.Text == "None")
            {
                dt.DefaultView.RowFilter = "";
            }

            if(cbDriversFilter.Text == "DriverID")
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", "DriverID", txtbDriverFilterValue.Text.Trim());
            }

            if(cbDriversFilter.Text == "PersonID")
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", "PersonID", txtbDriverFilterValue.Text.Trim());
            }
            
            if(cbDriversFilter.Text == "NationalNo")
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "NationalNo", txtbDriverFilterValue.Text.Trim());
            }

            if(cbDriversFilter.Text == "FullName")
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "FullName", txtbDriverFilterValue.Text.Trim());
            }

            dgvDrivers.DataSource = dt;
            lblCount.Text = dgvDrivers.Rows.Count.ToString();

        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails Person = new frmPersonDetails(Convert.ToInt32(dgvDrivers.CurrentRow.Cells[1].Value));
            Person.ShowDialog();
        }

        private void showDrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // here History of driver Licenses problem.
            frmPersonHistoryLicenses PersonLicenseHistory = new frmPersonHistoryLicenses(Convert.ToInt32(dgvDrivers.CurrentRow.Cells[1].Value));
            PersonLicenseHistory.ShowDialog();
        }

        //still the International License.

    }
}
