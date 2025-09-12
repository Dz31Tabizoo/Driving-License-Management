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
    public partial class Frm_User_Info : KryptonForm
    {
        public Frm_User_Info(clsUser User)
        {
            InitializeComponent();
            usrCrtlLogingInfo1.LoadUserInfo(User);
            usCrtlPersonCard1.LoadLabels(User.Person.PersonID);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
