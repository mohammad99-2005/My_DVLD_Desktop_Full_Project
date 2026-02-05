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

namespace My_DVLD_Desktop.Users
{
    public partial class frmUserDetails : Form
    {

        int _UserID = -1;
        public frmUserDetails(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlUserDetails1.LoadUserData(_UserID);
        }
    }
}
