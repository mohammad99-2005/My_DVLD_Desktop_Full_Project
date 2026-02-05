using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using My_DVLD_BussinessLayer;
using My_DVLD_Desktop.Global;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace My_DVLD_Desktop
{
    public partial class frmLogin : Form
    {

        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsersManagemetsBussiness clsUser = clsUsersManagemetsBussiness.FindByUsernameAndPassword(txtUsername.Text, txtPassword.Text);

            if (clsUser != null)
            {



                if (cbRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUsername.Text, txtPassword.Text);
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!clsUser.IsActive)
                {
                    MessageBox.Show("Your account is not active ,Contact Admin.","In Active Account",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.clsCurrUser = clsUser;
                MainScreen mainScreen = new MainScreen(this);
                this.Hide();
                mainScreen.ShowDialog();

            }
            else
            {
                MessageBox.Show("Error Username/Password", "Error");
                return;
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "";
            string Password = "";
            if(clsGlobal.GetStoredCredential(ref Username,ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                cbRememberMe.Checked = true;
                
            }
            else
            {
                cbRememberMe.Checked=false;
            }
        }
    }
}
