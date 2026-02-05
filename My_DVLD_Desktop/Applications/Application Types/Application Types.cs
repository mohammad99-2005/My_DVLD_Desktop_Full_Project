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
    public partial class ManageApplicationTypes : Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            DataTable dt = clsApplicationTypesBusinuse.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = dt;

            dgvApplicationTypes.Columns[0].Name = "ID";
            dgvApplicationTypes.Columns[0].Width = 130;

            dgvApplicationTypes.Columns[1].Name = "Title";
            dgvApplicationTypes.Columns[1].Width = 340;

            dgvApplicationTypes.Columns[2].Name = "Fees";
            dgvApplicationTypes.Columns[2].Width = 150;

            lblCount.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType ApplicationType = new frmEditApplicationType(Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value));
            ApplicationType.ShowDialog();
            ManageApplicationTypes_Load(null, null);

        }
    }
}
