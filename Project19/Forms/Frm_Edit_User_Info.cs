using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project19
{
    public partial class Frm_Edit_User_Info : KryptonForm
    {
        
        public Frm_Edit_User_Info(int UserID ,char P)
        {
            InitializeComponent();
            LoadUserDataToEdit(UserID);
            Loader();
            DragHelper.MakeFormDraggable(this);
            LoadsectionPasswordEdit(P);
        }

        private void LoadsectionPasswordEdit(char p)
        {
            if (p != 'U')
            {
                gbUserStatus.Enabled = false;
            }
            else
            {
                gbUserStatus.Enabled = true;
            }

        }
        private void Loader()
        {
            picPass3.Tag = txtConfirmNewpass;
            picPass2.Tag = txtNewPassword;
            picPass1.Tag = txtPriviousPassword;

            picPass1.MouseDown += ShowText;
            picPass1.MouseUp += HideText;
            picPass1.MouseLeave += HideText;

            picPass2.MouseDown += ShowText;
            picPass2.MouseUp += HideText;
            picPass2.MouseLeave += HideText;

            picPass3.MouseDown += ShowText;
            picPass3.MouseUp += HideText;
            picPass3.MouseLeave += HideText;

            picPass1.Enabled = true;
            picPass2.Enabled = true;
            picPass3.Enabled = true;
        }

        private void LoadUserDataToEdit(int UserId)
        {
            clsUser Usr = clsUser.FindUserByID(UserId);
            lblUserIDOutput.Text = Usr.UserID.ToString();
            txtUserName.Text = Usr.UserName;
            chkActive.Checked = Usr.IsActive;
            if (!Usr.IsActive)
            {
                chkActive.Text = "Non Active User";
            }
            else
            {
                chkActive.Text = "Active User";
            }
            txtPriviousPassword.Tag = Usr.Password.ToString();
        }
               
        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked is false)
            {
                chkActive.Text = "Non Active User";
            }
            else
            {
                chkActive.Text = "Active User";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPriviousPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPriviousPassword.Text != txtPriviousPassword.Tag.ToString())
            {
                errorProvider.SetError(txtPriviousPassword,"Wrong Password,Try A nother One");
            }
            else
            {
                errorProvider.SetError(txtPriviousPassword, "");
            }
        }

        private void txtConfirmNewpass_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmNewpass.Text != txtNewPassword.Text)
            {
                errorProvider.SetError(txtConfirmNewpass, "Wrong Confirmation,Tape The Same New password");
            }
            else
            {
                errorProvider.SetError(txtConfirmNewpass, "");
            }

        }


        private void HideText(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pic && pic.Tag is KryptonTextBox tbox)
            {
                tbox.PasswordChar = '●';
            }
        }
        private void ShowText(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pic && pic.Tag is KryptonTextBox tbox)
            {
                tbox.PasswordChar = '\0';
            }
        }
        private void HideText(object sender, EventArgs e)
        {
            if (sender is PictureBox pic && pic.Tag is KryptonTextBox tbox)
            {
                tbox.PasswordChar = '●';
            }
        }



    }
}
