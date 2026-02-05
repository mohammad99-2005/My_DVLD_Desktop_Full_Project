using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_DVLD_BussinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace My_DVLD_Desktop
{
    public partial class PeopleManagment : Form
    {

        static DataTable _dtAllPeople = clsPeopleManagmentBusinuse.GetAllPeople();


        DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "FirstName",
                                                        "SecondName", "ThirdName", "LastName", "NationalNo",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

        public PeopleManagment()
        {
            InitializeComponent();
        }

        private void PeopleManagment_Load(object sender, EventArgs e)
        {

            dgvPeople.DataSource = _dtPeople;
            cbFilters.SelectedIndex = 0;
            lblCount.Text = dgvPeople.Rows.Count.ToString();

            if (dgvPeople.SelectedRows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "First Name";
                dgvPeople.Columns[1].Width = 120;

                dgvPeople.Columns[2].HeaderText = "Second Name";
                dgvPeople.Columns[2].Width = 140;

                dgvPeople.Columns[3].HeaderText = "Third Name";
                dgvPeople.Columns[3].Width = 120;

                dgvPeople.Columns[4].HeaderText = "Last Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "National No";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;

                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;

                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;

            }
        }

        void _RefreshPeopleDataTable()
        {
            DataTable dt = clsPeopleManagmentBusinuse.GetAllPeople();
            _dtPeople = dt.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");
            dgvPeople.DataSource = _dtPeople;
        }


        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvPeople.SelectedRows[0];
                int personID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                frmPersonDetails frmPersonDetail = new frmPersonDetails(personID);
                frmPersonDetail.Show();
                _RefreshPeopleDataTable();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvPeople.SelectedRows[0];
                int PersonID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                frmEditAddPersonDetails frm = new frmEditAddPersonDetails(PersonID);
                frm.ShowDialog();
                _RefreshPeopleDataTable();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow dataGridViewRow = dgvPeople.SelectedRows[0];
            int PersonID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);
            DialogResult Result = MessageBox.Show("Are You Sure to Delete Person With ID (" + PersonID.ToString() + ")","Delete Person",MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                if (clsPeopleManagmentBusinuse.IsPersonExist(PersonID))
                {
                    if (clsPeopleManagmentBusinuse.DeletPerson(PersonID))//you cant delete user that has applications or
                    {                                                   //information in license or anysomthing else.
                        MessageBox.Show("Deleted Successfuly.");
                        _RefreshPeopleDataTable();
                    }
                    else
                    {
                        MessageBox.Show("Error While Deleting the Person");
                    }
                }
                else
                {
                    MessageBox.Show("Person does not exist");
                }
            }
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAddPersonDetails AddPerson = new frmEditAddPersonDetails(-1);
            AddPerson.ShowDialog();
            _RefreshPeopleDataTable();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmEditAddPersonDetails AddPerson = new frmEditAddPersonDetails();
            AddPerson.ShowDialog();
            _RefreshPeopleDataTable();
        }


        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbFilter.Visible = (cbFilters.SelectedIndex != 0);

            if(cbFilters.SelectedIndex != 0)
            {
                txtbFilter.Text = "";
                txtbFilter.Focus();
            }
        }


        private void txtbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilters.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;
                case "FirstName":
                    FilterColumn = "FirstName";
                    break;
                case "SecondName":
                    FilterColumn = "SecondName";
                    break;
                case "ThirdName":
                    FilterColumn = "ThirdName";
                    break;
                case "LastName":
                    FilterColumn = "LastName";
                    break;
                case "GendorCaption":
                    FilterColumn = "GendorCaption";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                case "CountryName":
                    FilterColumn = "CountryName";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }

            if(FilterColumn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn,txtbFilter.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",FilterColumn,txtbFilter.Text.Trim());
            }

            lblCount.Text = dgvPeople.Rows.Count.ToString();
        }
        

        private void txtbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "PersonID")
            {
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            }
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvPeople_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dgvPeople.SelectedRows[0];
                int personID = Convert.ToInt32(dataGridViewRow.Cells[0].Value);

                frmPersonDetails frmPersonDetail = new frmPersonDetails(personID);
                frmPersonDetail.Show();
                _RefreshPeopleDataTable();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
