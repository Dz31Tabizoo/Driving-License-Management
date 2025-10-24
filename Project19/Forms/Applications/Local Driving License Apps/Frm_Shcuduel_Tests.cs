using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BusinessLayer;

namespace Project19
{
    public partial class Frm_Shcuduel_Tests : KryptonForm
    {
        private clsLocalDrivingLicenseApplication _LDVLAPP = new clsLocalDrivingLicenseApplication();
        
        private clsApplications _app = new clsApplications();
        private int _testTypeID = -1;
        
        public Frm_Shcuduel_Tests(clsLocalDrivingLicenseApplication localApp ,int testPassed, clsApplications application,int TestType)
        {
            InitializeComponent();
            LoadFormTitleText(TestType);
            crtlLDVLappInfo1._LoadCrtlLocalAppInfo(localApp, testPassed);
            crtlApplicationInfo1.LoadApplicationInfo(application);
            LoadDataGridView(localApp.LocalDrivingLicenseApplicationID,TestType);
            _LDVLAPP = localApp;
            _app = application;
            _testTypeID = TestType;
        }

        
        private async void LoadDataGridView(int localDVL_ID,int testTypeid)
        {
            //to fix
            DataTable list = await clsTestAppointment.GetAllAppointments(localDVL_ID,testTypeid);
            dgvAppointments.AutoGenerateColumns = true;
            dgvAppointments.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddApointment_Click(object sender, EventArgs e)
        {

            if( await clsTestAppointment.CheckIfNoAppointmentisON(_LDVLAPP.LocalDrivingLicenseApplicationID))
            {
                MessageBox.Show("▬ The applicant has already an appointment ▬","Appointment Failed",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            var LicenseClass = await clsLicenseClasses.GetLicenseClassObjByIDAsync(_LDVLAPP.LicenseClassID);
            var LdvlApp = new clsLocalDrivingLicenseApplication(_LDVLAPP.LocalDrivingLicenseApplicationID,_app,LicenseClass);

            using (Form FRM = new Frm_Add_Retake_VisionTest(LdvlApp,_testTypeID))
            {
                FRM.ShowDialog();
            }
        }

        private void LoadFormTitleText(int TestType)
        {
            switch(TestType)
            {
                case 1:
                    lblFormTitle.Text = "Vision Test Appointments";
                    break;
                    case 2:
                    lblFormTitle.Text = "Written Test Appointments";
                    break;
                    case 3:
                    lblFormTitle.Text = "Practical Test Appointments";
                    break;
                default:
                    lblFormTitle.Text = "Test Appointments";
                    break;
            }
        }
    }
}
