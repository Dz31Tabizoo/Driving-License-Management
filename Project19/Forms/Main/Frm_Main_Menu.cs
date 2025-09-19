using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;
using BusinessLayer;
using System.Security;

namespace Project19
{
    public partial class Frm_Main_Menu : KryptonForm
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        private bool sideBarreExpend = true;
        private bool AppsCollapsed = true;
        private bool AppsExpanded = true;

        // Clean up
     
        public Frm_Main_Menu()
        {
            InitializeComponent();
            
            
            DragHelper.MakeFormDraggable(this);
        }
        


        

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonPanel2.Visible == false)
            {
                kryptonPanel2.Visible= true;
                return;
            }
            else
            {
                kryptonPanel2.Visible = false;
            }

        }

        

        

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            if (kryptonPanel3.Visible == false)
            {
                kryptonPanel3.Visible = true;
                return;
            }
            else
            {
                kryptonPanel3.Visible = false;
            }
        }

      

        private void SideBarreTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarreExpend)
            {
                SideBarre.Width -= 10;
                if (SideBarre.Width == SideBarre.MinimumSize.Width)
                {
                    sideBarreExpend = false;
                    SideBarreTimer.Stop();
                }
            }
            else
            {
                SideBarre.Width += 10;
                if (SideBarre.Width == SideBarre.MaximumSize.Width)
                {
                    sideBarreExpend = true;
                    SideBarreTimer.Stop();
                }
            }


        }

       

        private void pbMainMenu_Click(object sender, EventArgs e)
        {
            SideBarreTimer.Start();
        }

       

        private void ApplicationTimer_Tick(object sender, EventArgs e)
        {
            if (AppsCollapsed)
            {
                pnlApplications.Height += 10;
                if (pnlApplications.Height == pnlApplications.MaximumSize.Height)
                {
                    AppsCollapsed = false;
                    ApplicationTimer.Stop();
                }
            }
            else
            {
                pnlApplications.Height -= 10;
                if (pnlApplications.Height == pnlApplications.MinimumSize.Height)
                {
                    AppsCollapsed = true;
                    ApplicationTimer.Stop();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationTimer.Start();

        }

        private void AccSetTimer_Tick(object sender, EventArgs e)
        {
            if (AppsExpanded)
            {
                pnlAccountSetting.Height += 10;
                if (pnlAccountSetting.Height == pnlAccountSetting.MaximumSize.Height)
                {
                    AppsExpanded = false;
                    AccSetTimer.Stop();
                }
            }
            else
            {
                pnlAccountSetting.Height -= 10;
                if (pnlAccountSetting.Height == pnlAccountSetting.MinimumSize.Height)
                {
                    AppsExpanded = true;
                    AccSetTimer.Stop();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccSetTimer.Start();
        }

        private void btnPeopleaMagement_Click(object sender, EventArgs e)
        {
            KryptonForm frm = new People_Managment();
            frm.Show();
        }

        private void btnUserM_Click(object sender, EventArgs e)
        {
            KryptonForm frm = new Frm_User_Managment();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clsUser User = GlobalSetting.CurrentUser;

            Frm_User_Info frm = new Frm_User_Info(User);
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clsUser User = GlobalSetting.CurrentUser;
            Form frm = new Frm_Edit_User_Info(User.UserID, 'P');
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GlobalSetting.CurrentUser = null;
            this.Close();
            Form frm = new Frm_Login();
            frm.ShowDialog();
        }
    }
}
