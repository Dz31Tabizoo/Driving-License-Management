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
    public partial class Frm_Add_New_Local_DVL : KryptonForm
    {
        
        public Frm_Add_New_Local_DVL()
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
            if(crtlPersonCardWithFilter1.PersID > 0)
            {
                btnSaveApplication.Enabled = true;
                tabControl1.SelectedIndex = 1;
            }
            
        }

        private async void btnSaveEdit_Click(object sender, EventArgs e)
        {
            clsApplications application = new clsApplications();
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();

            
            application.Applicant = clsPeople.FindPersonByID(crtlPersonCardWithFilter1.PersID);
            application.AppType = clsApplicationTypes.FindAppTypeBtID(1); // 1 for LocalapplicationType
            application.CreatedByUser = GlobalSetting.CurrentUser;
            application.PaidFees = application.AppType.ApplicationFee;

            if (await application.Save())
            {
                localDrivingLicenseApplication.ApplicationID = application.AppID;
                localDrivingLicenseApplication.LicenseClassID = cbxLicenseClasses.SelectedIndex;

                if (await localDrivingLicenseApplication.Save())
                {
                    MessageBox.Show("New local driving license application created sucssesfuly","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Application created but local not", "Massive Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("failed to save Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }
    }
}
