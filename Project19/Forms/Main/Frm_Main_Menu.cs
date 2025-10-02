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
using Project19.Forms.Applications.Test_Types;

namespace Project19
{
    public partial class Frm_Main_Menu : KryptonForm
    {

        private KryptonForm currentFrm = null;
        private bool sideBarreExpend = true;
        private bool AppsCollapsed = true;
        private bool AppsExpanded = true;

        // Clean up
     
        public Frm_Main_Menu()
        {
            InitializeComponent();                    
            DragHelper.MakeFormDraggable(this);
        }

        public void loadForm(object Form)
        {
            if (this.pnlMainPanel.Controls.Count > 0)
            {
                this.pnlMainPanel.Controls.RemoveAt(0);
            }

            KryptonForm f = Form as KryptonForm;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            currentFrm = f;
            this.pnlMainPanel.Controls.Add(f);
            this.pnlMainPanel.Tag = f;
            f.Size = this.pnlMainPanel.ClientSize;
            f.Location = new Point(0, 0);

            f.FormClosed += OnFormClosed;
            if (currentFrm != null && SideBarre.Width > SideBarre.MinimumSize.Width)
            {
                sideBarreExpend = true;
                SideBarreTimer.Start();
            }
            f.Show();
            pnlMainPanel.Refresh();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            currentFrm = null;

            if (SideBarre.Width< SideBarre.MaximumSize.Width)
            {
                sideBarreExpend = false;
                SideBarreTimer.Start();
            }
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
            loadForm(new People_Management());
        }

        private void btnUserM_Click(object sender, EventArgs e)
        {
            loadForm(new Frm_User_Managment());

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

        private void Frm_Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAppTypes_Click(object sender, EventArgs e)
        {
            loadForm(new Frm_Application_Types());
            
        }

        private void btnMngTestTypes_Click(object sender, EventArgs e)
        {
            loadForm(new Frm_Test_Types());
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
