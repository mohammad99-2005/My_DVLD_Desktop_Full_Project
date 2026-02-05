using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace My_DVLD_Desktop.Users
{
    public partial class frmUsersManagement : Form
    {

        private static DataTable dtUsers;

        public frmUsersManagement()
        {
            InitializeComponent();
        }
        
        void _ResetUsersData()
        {
            dtUsers = clsUsersManagemetsBussiness.GetAllUsers();
            dgvUsers.DataSource = dtUsers;
            lblCount.Text = dgvUsers.Rows.Count.ToString();

            cbFilters.SelectedIndex = 0;
            cbIsActive.Visible = false;
            txtbFilterValue.Visible = false;
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {

            _ResetUsersData();

            dgvUsers.Columns[0].Width = 100;
            dgvUsers.Columns[1].Width = 100;
            dgvUsers.Columns[2].Width = 300;
            dgvUsers.Columns[3].Width = 200;
            dgvUsers.Columns[4].Width = 100;

            lblCount.Text = dtUsers.Rows.Count.ToString();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilters.Text == "IsActive")
            {
                txtbFilterValue.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
                txtbFilterValue.Focus();
                return;
            }
            else
            {
                txtbFilterValue.Visible = (cbFilters.Text != "None");
                cbIsActive.Visible = false;

                txtbFilterValue.Text = "";
                txtbFilterValue.Focus();
            }
        }

        private void txtbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterType = "";

            if (cbFilters.Text == "UserID")
                FilterType = "UserID";
            if (cbFilters.Text == "UserName")
                FilterType = "UserName";
            if (cbFilters.Text == "PersonID")
                FilterType = "PersonID";
            if (cbFilters.Text == "FullName")
                FilterType = "FullName";

            if(cbFilters.Text == "None" || txtbFilterValue.Text.Trim() == "")
            {
                dtUsers.DefaultView.RowFilter = "";
                lblCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterType == "UserID" || FilterType == "PersonID")
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterType, txtbFilterValue.Text.Trim());

            if (FilterType == "UserName" || FilterType == "FullName")
                dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterType, txtbFilterValue.Text.Trim());


            dgvUsers.DataSource = dtUsers;
            lblCount.Text = dgvUsers.Rows.Count.ToString();

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            if(FilterValue == "All")
            {
                dtUsers.DefaultView.RowFilter = "";
            }
            else
            {
                switch (FilterValue)
                {
                    case "Yes":
                        FilterValue = "1";
                        break;
                    case "No":
                        FilterValue = "0";
                        break;
                }

                dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn, FilterValue);

            }
            lblCount.Text = dgvUsers.Rows.Count.ToString();

            //if(cbIsActive.Text == "All")
            //{
            //    dgvUsers.DataSource = dtUsers;
            //    dtUsers.DefaultView.RowFilter = "";
            //    lblCount.Text = dgvUsers.Rows.Count.ToString();
            //    return;
            //}
            //DataRow[] ResultRows;

            //if (cbIsActive.Text == "Yes")
            //{

            //    ResultRows = dtUsers.Select("IsActive=1");
            //    dgvUsers.DataSource = ResultRows.CopyToDataTable();
            //}
            //{
            //else
            //    ResultRows = dtUsers.Select("IsActive=0");
            //    dgvUsers.DataSource = ResultRows.CopyToDataTable();
        }
        

            //}
            //lblCount.Text = dgvUsers.Rows.Count.ToString();
        private void txtbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "UserID" || cbFilters.Text == "PersonID")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditNewUser frm = new frmAddEditNewUser();
            frm.ShowDialog();
            _ResetUsersData();
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvUsers.SelectedRows.Count > 0)
            {
                frmAddEditNewUser frm = new frmAddEditNewUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value));
                frm.ShowDialog();
                _ResetUsersData();
            }
            
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails UserDetails = new frmUserDetails(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            UserDetails.ShowDialog();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditNewUser frm = new frmAddEditNewUser();
            frm.ShowDialog();
            _ResetUsersData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUsersManagemetsBussiness.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("User Deleted Succsfuly");
                _ResetUsersData();
            }
            else
            {
                MessageBox.Show("This User Cant be deleted");
            }
        }

        private void ChangePasswordStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword changePass = new frmChangeUserPassword(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            changePass.ShowDialog();
            _ResetUsersData();
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserDetails UserDetails = new frmUserDetails(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            UserDetails.ShowDialog();
        }
    }
}
