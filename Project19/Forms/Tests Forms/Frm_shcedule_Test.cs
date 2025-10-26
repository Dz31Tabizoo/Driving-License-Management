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
    public partial class Frm_shcedule_Test : KryptonForm
    {
        private int _TestTypeID = -1;

        private clsLocalDrivingLicenseApplication _LDVLAPP = null;

        private clsTestAppointment _NewTestApp = new clsTestAppointment();

        private bool _ToEdit = false;

        private int _TestAppID = -1;


        public Frm_shcedule_Test(clsLocalDrivingLicenseApplication ldvlApp,int testTypID,bool locked = false,bool Edit = false,int testAppID = -1)
        {
            InitializeComponent();
            LoadLabels(ldvlApp,testTypID,locked);
            _TestTypeID = testTypID;
            _LDVLAPP = ldvlApp;
            _ToEdit = Edit;
            _TestAppID = testAppID;
        }

        //Create OBject To Save
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

        //UI
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
            else if(_ToEdit)
            {
                btnSaveAppointmentDateTest.Text = "Edit";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //create Object To Edit
        private void CreateObjectToEdit()
        {
            Decimal paidFees = clsTestTypes.GetTestTypeByID(_TestTypeID).TestFee;
            
            clsTestAppointment testApp = new clsTestAppointment(_TestAppID, _TestTypeID, _LDVLAPP.LocalDrivingLicenseApplicationID, dtpAppointmentDateSelect.Value, paidFees, GlobalSetting.CurrentUser.UserID, false, null, null, null);
            _NewTestApp = testApp;
        }

        private async void btnSaveAppointmentDateTest_Click(object sender, EventArgs e)
        {
            if (!_ToEdit)
            {
                CreateNEwAppointment(_LDVLAPP);

                if (await _NewTestApp.Save())
                {
                    MessageBox.Show("Appointment scheduled successfully", "Succseed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to schedule the appointment", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                CreateObjectToEdit();
                if(await _NewTestApp.Save())
                {
                    MessageBox.Show("Appointment schedule edited successfully", "Edit Succseed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Edit the appointment schedule", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }


        }

        private void DisableLabelesIfTestAppointmentLocked()
        {
            dtpAppointmentDateSelect.Enabled = false;           
            btnSaveAppointmentDateTest.Enabled = false;
        }


    }
}
