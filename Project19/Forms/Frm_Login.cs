using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("User Name and PAssword are requiered", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
          clsUser CurrentUSer = clsUser.FindUserByUserName(txtUsername.Text);

            if (CurrentUSer == null)
            {
                MessageBox.Show("Wrong UserName Try Again", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            else
            {
                if (CurrentUSer.Password != txtPassword.Text)
                {
                    MessageBox.Show("Wrong PassWord Try Again", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    if (CurrentUSer.IsActive == true)
                    {
                        Form FRM = new Frm_Main_Menu();
                        FRM.Show();
                    }
                    else 
                    {
                        MessageBox.Show("This User is Not Active, Please Contact Your Admin", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Clear();
                        txtUsername.Focus();

                        return;
                    }
                }
            }
               
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
