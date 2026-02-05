using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_DVLD_Desktop
{
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(string NationalNo)
        {
            
            InitializeComponent();
            ctrlPersonDetails1.LoadPersonInfo(NationalNo);
            
        }

        public frmPersonDetails(int PersonID)
        {

            InitializeComponent();
            ctrlPersonDetails1.LoadPersonInfo(PersonID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
