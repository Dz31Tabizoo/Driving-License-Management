using BusinessLayer;
using Project19.Properties;
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
    public partial class UsrCrtlLogingInfo : UserControl
    {
        public UsrCrtlLogingInfo()
        {
            InitializeComponent();
        }


        public void LoadUserInfo(clsUser User)
        {
            lblUserNameOut.Text = User.UserName;
            lblUSerIDOut.Text = User.UserID.ToString();
            if (!User.IsActive)
            {
                PicActive.Image = Resources.security;
                lblActiveStatus.Text = "Non Active";
            }
        }
    }
}
