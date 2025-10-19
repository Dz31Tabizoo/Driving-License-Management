using BusinessLayer;
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
    public partial class crtlApplicationInfo : UserControl
    {
        public crtlApplicationInfo ()
        {
            InitializeComponent();
            
        }

       

        private void LoadApplicationInfo(clsApplications app)
        {
            lblApp_ID.Text = app.AppID.ToString();
            lblApp_Date.Text = app.AppDate.ToString("dd/MMM/yyyy");
            lblStatus_Date.Text = app.LastStatusDate.ToString("dd/MMM/yyyy");
            lbl_Fees.Text = app.PaidFees.ToString();
            lbl_Status.Text = app.ApplicationStatus.ToString();
            lbl_Type.Text = app.AppType.ApplicationTypeTitle;
            lbl_User.Text = app.CreatedByUser.UserName;
            lbl_Applicant.Text = $"{app.Applicant.FirstName} {app.Applicant.SecondName} {app.Applicant.LastName}".Trim();
        }
    }
}
