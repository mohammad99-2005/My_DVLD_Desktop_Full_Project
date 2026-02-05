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
using My_DVLD_Desktop.Applications.Test_Types;

namespace My_DVLD_Desktop.Applications.Application_Types
{
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            DataTable dt = clsTestTypeBussinuse.GetAllTestTypes();
            dgvTestTypes.DataSource = dt;

            dgvTestTypes.Columns[0].Name = "ID";
            dgvTestTypes.Columns[0].Width = 100;

            dgvTestTypes.Columns[1].Name = "Title";
            dgvTestTypes.Columns[1].Width = 130;

            dgvTestTypes.Columns[2].Name = "Description";
            dgvTestTypes.Columns[2].Width = 300;

            dgvTestTypes.Columns[3].Name = "Fees";
            dgvTestTypes.Columns[3].Width = 100;

            lblCount.Text =  dgvTestTypes.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypes frm = new EditTestTypes((clsTestTypeBussinuse.enTestType)Convert.ToInt32(dgvTestTypes.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            ManageTestTypes_Load(null, null);
        }
    }
}
