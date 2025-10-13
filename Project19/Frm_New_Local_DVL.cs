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
    public partial class Frm_New_Local_DVL : KryptonForm
    {
        
        public Frm_New_Local_DVL()
        {
            InitializeComponent();
            LoadForm();
        }

        private async void LoadForm()
        {
            lblApplicationDateOutput.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblUserCreatedByOutput.Text = GlobalSetting.CurrentUser.UserName;
            lblUserCreatedByOutput.Tag = GlobalSetting.CurrentUser.UserID;



            
            var licenseClasses = new List<clsLicenseClasses>();

            var listdata = await clsLicenseClasses.GetAllLicensesClasses();


       
            licenseClasses.Add(new clsLicenseClasses { LicenseClassID = -1, ClassName = "Select a class..." });
            licenseClasses.AddRange(listdata);

            cbxLicenseClasses.DisplayMember = "ClassName";
            cbxLicenseClasses.ValueMember = "LicenseClassID";
            cbxLicenseClasses.DataSource = licenseClasses;
            cbxLicenseClasses.SelectedIndex = 0;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }











    }
}
