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

namespace Project19
{
    public partial class Frm_Add_User : KryptonForm
    {
        public Frm_Add_User()
        {
            InitializeComponent();
        }

        public DataRow PersonFoundinfo {  get; set; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           btnClear.PerformClick();
        }

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            Frm_Find_Person frm = new Frm_Find_Person();
            frm.EvGetPerson += GetPerson;
            frm.ShowDialog();
        }
        
        
        private void GetPerson(object sender,int PersID)
        {
            usCrtlPersonCard1.LoadLabels(PersID);
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (SaveUserInfo())
            {
                DialogResult Result = MessageBox.Show("User info Saved Successfuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    this.Close();
                    // refresh User Managment Screen
                }

            }
            else
            {
                MessageBox.Show("User info Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool SaveUserInfo()
        {

            clsUser NewUser = new clsUser();
            NewUser.UserName = txtUserName.Text;
            NewUser.Password = txtPassWord.Text;
            NewUser.IsActive = chkActive.Checked;

            clsPeople ThePerson = clsPeople.FindPersonByID(usCrtlPersonCard1.PERSONID);
            NewUser.Person = ThePerson;
           

            return NewUser.Save();

        }

        private void picPassWrd_MouseDown(object sender, MouseEventArgs e)
        {
         txtPassWord.PasswordChar = '\0';
        }

        private void picPassWrd_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassWord.PasswordChar = '▬';
        }

        private void picPassWrd_MouseLeave(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = '▬';
        }

        private void picEyePassWrdConfirm_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassWordConfirm.PasswordChar = '\0';
        }

        private void picEyePassWrdConfirm_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassWordConfirm.PasswordChar = '▬';
        }

        private void picEyePassWrdConfirm_MouseLeave(object sender, EventArgs e)
        {
            txtPassWordConfirm.PasswordChar = '▬';
        }
    }
}
