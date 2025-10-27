using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;

namespace Project19
{
    public partial class Frm_Take_Tests : KryptonForm
    {
        private int _TestAppointmentId = -1;
        public Frm_Take_Tests(clsLocalDrivingLicenseApplication LdvlApp,DateTime AppointmentDate,int TestTypeId,int testAppID)
        {
            InitializeComponent();
            LoadLabels(LdvlApp, AppointmentDate, TestTypeId);
            _TestAppointmentId = testAppID;
        }


        private async void LoadLabels(clsLocalDrivingLicenseApplication ldvrApp,DateTime appointmentDate,int testTypeid)
        {
            lblLocalDVLAppIDOutput.Text = ldvrApp.LocalDrivingLicenseApplicationID.ToString();
            var LicenceClass = await clsLicenseClasses.GetLicenseClassObjByIDAsync(ldvrApp.LicenseClassID);
            lblClassesOutput.Text = LicenceClass.ClassName;

            lbl_Applicant.Text = $"{ldvrApp.Application.Applicant.FirstName} {ldvrApp.Application.Applicant.SecondName} {ldvrApp.Application.Applicant.LastName}".Trim();
            var test = clsTestTypes.GetTestTypeByID(testTypeid);
            lbl_FeesOutput.Text = test.TestFee.ToString();
            lblApp_Date.Text = appointmentDate.ToString("dd/MMM/yyyy");

            int Trails = await clsTestAppointment.CountTrails(ldvrApp.LocalDrivingLicenseApplicationID, testTypeid);
            lbl_trailsOutput.Text = Trails.ToString();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFail.Checked)
            {
                checkBoxPass.Checked = false;
            }
            else
            {
                checkBoxPass.Checked = true;
            }

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                checkBoxFail.Checked = false;
            }
            else
            {
                checkBoxFail.Checked = true;
            }
        }

        private async void btnSaveAppointmentDateTest_Click(object sender, EventArgs e)
        {
            var newTest = new clsTests();

            newTest.TestAppointmentID = _TestAppointmentId;

            if (checkBoxFail.Checked)
            {
                newTest.TestResult = false;
            }
            else
            {
                newTest.TestResult = true;
            }

            if (string.IsNullOrEmpty(txtBoxNotes.Text) || string.IsNullOrWhiteSpace(txtBoxNotes.Text))
            {
                newTest.Notes = null;
            }
            else
            {
                newTest.Notes = txtBoxNotes.Text;
            }

            newTest.UserID = GlobalSetting.CurrentUser.UserID;

            int NewTestID = await newTest.SaveNewTest();

            if ( NewTestID != -1)
            {
                MessageBox.Show("Test Result Saved successfully", "Succseed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblApp_ID.Text = NewTestID.ToString();
                btnSaveAppointmentDateTest.Enabled = false;

                //lock the appointment
            }
            else
            {
                MessageBox.Show("Saving Test Result Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}
