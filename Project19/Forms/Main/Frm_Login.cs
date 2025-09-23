using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace Project19
{
    public partial class Frm_Login : KryptonForm
    {
        public Frm_Login()
        {
            InitializeComponent();
            DragHelper.MakeFormDraggable(this);
        }

       







        private bool ManageLoging()
        {
            if (GlobalSetting.LoginAuthontification(txtUsername.Text,txtPassword.Text))
            {
                
                return true;

            }
            else
            {
                MessageBox.Show("Invalid credentials");
                return false;
            }



        }
        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(ManageLoging()) 
            {
                if (ChkbxRemaindMe.Checked)
                {
                    GlobalSetting.RememberUserNameAndPassWord(txtUsername.Text, txtPassword.Text);
                }
                else
                {
                    GlobalSetting.RememberUserNameAndPassWord("", "");
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void txtUsername_MouseClick(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Your User Name")
            {
                txtUsername.Text = string.Empty;
                txtUsername.Focus();
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";
            if (GlobalSetting.GetStoredCredential(ref Username,ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text= Password;
                ChkbxRemaindMe.Checked= true;
                btnLogin.Focus();
            }
            else
            {
                ChkbxRemaindMe.Checked = false;
            }
        }
    }
   
}
