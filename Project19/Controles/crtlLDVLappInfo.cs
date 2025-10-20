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
    public partial class crtlLDVLappInfo : UserControl
    {

        public crtlLDVLappInfo()
        {
            InitializeComponent();
            

        }

        

        public async void _LoadCrtlLocalAppInfo(clsLocalDrivingLicenseApplication localApp,int TestPassed)
        {
            lblLocalDVLAppIDOutput.Text = localApp.LocalDrivingLicenseApplicationID.ToString();
            clsLicenseClasses licenceClass = await clsLicenseClasses.GetLicenseClassObjByIDAsync(localApp.LicenseClassID);

            lblClassesOutput.Text = licenceClass.ClassName;
            lblPassedTestCount.Text = TestPassed.ToString();    
        }






    }
}
