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
    public partial class Frm_Edit_User_Info : KryptonForm
    {
        public Frm_Edit_User_Info(int UserID)
        {
            InitializeComponent();
            LoadUserDataToEdit(UserID);
        }

        private void LoadUserDataToEdit(int UserId)
        {
            clsUser Usr = clsUser.FindUserByID(UserId);



        }
        
    }
}
