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
    public partial class Frm_Add_Retake_VisionTest : KryptonForm
    {
        private int _TestTypeID = -1;

        private clsLocalDrivingLicenseApplication _LDVLAPP = null;

        private clsTestAppointment _NewTestApp = new clsTestAppointment();


        public Frm_Add_Retake_VisionTest(clsLocalDrivingLicenseApplication ldvlApp,int testTypID,bool locked = false)
        {
            InitializeComponent();
            LoadLabels(ldvlApp,testTypID,locked);
            _TestTypeID = testTypID;
            _LDVLAPP = ldvlApp;            
        }

        private void CreateNEwAppointment(clsLocalDrivingLicenseApplication ldvl)
        {
            clsTestAppointment Tapp = new clsTestAppointment();

            Tapp.TestAppointmentDate = dtpAppointmentDateSelect.Value.Date;
            Tapp.CreatedUSerID = GlobalSetting.CurrentUser.UserID;
            Tapp.TestTypeID = _TestTypeID;
            Tapp.LDLA_ID = ldvl.LocalDrivingLicenseApplicationID;
            Tapp.PaidFees = clsTestTypes.GetTestTypeByID(_TestTypeID).TestFee;
            _NewTestApp = Tapp;
        }

        private async void LoadLabels( clsLocalDrivingLicenseApplication app,int testTypeid,bool locked = false)
        {
            lbl_ApplicantOutput.Text =(app.Application.Applicant.FirstName + app.Application.Applicant.SecondName + app.Application.Applicant.LastName).Trim();
            lblClassesOutput.Text = app.LicenseClass.ClassName;
            lblLocalDVLAppIDOutput.Text = app.LocalDrivingLicenseApplicationID.ToString();
            int trails = await clsTestAppointment.CountTrails(app.LocalDrivingLicenseApplicationID, testTypeid);
            lblTrialOutput.Text = trails.ToString() + "/3";
            if (locked)
            {
                DisableLabelesIfTestAppointmentLocked();
                lblShowCantUpdate.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddApointment_Click(object sender, EventArgs e)
        {
            CreateNEwAppointment(_LDVLAPP);

            if (await _NewTestApp.Save())
            {
                MessageBox.Show("Appointment scheduled successfully", "Succseed", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to schedule the appointment", "Succseed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }


        }

        private void DisableLabelesIfTestAppointmentLocked()
        {
            dtpAppointmentDateSelect.Enabled = false;           
            btnAddApointment.Enabled = false;
        }


    }
}
