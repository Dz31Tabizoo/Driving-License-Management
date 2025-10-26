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
    public partial class Frm_View_Shcudueled_Tests : KryptonForm
    {
        private clsLocalDrivingLicenseApplication _LDVLAPP = new clsLocalDrivingLicenseApplication();
        
        private clsApplications _app = new clsApplications();
        private int _testTypeID = -1;
        
        public Frm_View_Shcudueled_Tests(clsLocalDrivingLicenseApplication localApp ,int testPassed, clsApplications application,int TestType)
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

        
        private async void LoadDataGridView(int localDVL_ID,int testTydeid)
        {
            //to fix
            DataTable list = await clsTestAppointment.GetAllAppointments(localDVL_ID,testTydeid);
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

            using (Form FRM = new Frm_shcedule_Test(LdvlApp,_testTypeID))
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

        private void EditAppointmentTSM_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAppointments.SelectedRows[0];
            bool isLocked = (bool)row.Cells["IsLocked"].Value;
            int testAppointmentID = (int)row.Cells["TestAppointmentID"].Value;

            using (Form FRM = new Frm_shcedule_Test(_LDVLAPP, _testTypeID,isLocked,true,testAppointmentID))
            {
                FRM.ShowDialog();

            }
            LoadDataGridView(_LDVLAPP.LocalDrivingLicenseApplicationID, _testTypeID);

        }
    }
}
