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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Rememberlog.txt"))
                {
                    string content = File.ReadAllText("Rememberlog.txt");
                    string[] parts = content.Split('#');
                    if (parts.Length >= 2)
                    {
                        txtUsername.Text = parts[0];
                        txtPassword.Text = parts[1];
                    }
                    else
                    {
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading saved login: {ex.Message}");
                
                File.Delete("RememberLog.txt");
            }
            
            
        }

        private bool ManageLoging()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("User Name and PAssword are requiered", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return false;
            }
            clsUser CurrentUSer = clsUser.FindUserByUserName(txtUsername.Text);

            if (CurrentUSer == null)
            {
                MessageBox.Show("Wrong UserName Try Again", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else
            {
                if (CurrentUSer.Password != txtPassword.Text)
                {
                    MessageBox.Show("Wrong PassWord Try Again", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    return false;
                }
                else
                {
                    if (CurrentUSer.IsActive == true)
                    {
                                              
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("This User is Not Active, Please Contact Your Admin", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Clear();
                        txtUsername.Focus();

                        return false;
                    }
                    
                }
            }
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(ManageLoging()) 
            {
                if (ChkbxRemaindMe.Checked)
                {
                    try
                    {
                        string Content = txtUsername.Text + '#' + txtPassword.Text;

                        File.WriteAllText("RememberLog.txt", Content); // ie should encrypt this data later


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Saving Login into File : {ex.Message}");
                        return;
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Your User Name")
            {
                txtUsername.Text = string.Empty;
                txtUsername.Focus();
            }
        }

    }
   
}
