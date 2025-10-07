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
    public partial class Frm_LocalLicendeDrivingManagement : KryptonForm
    {
        public Frm_LocalLicendeDrivingManagement()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private async void LoadDataGridView()
        {
            try
            {
                var appList = await clsLocalDrivingLicenseApplication.GetAllLocalDriveLicenseApps();
                this.Cursor = Cursors.WaitCursor;


                if (appList == null)
                {
                    MessageBox.Show("Load Applications Data Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvApplications.AutoGenerateColumns = true;
                dgvApplications.DataSource = appList.Select(app => new
                {
                    ID = app.LocalDrivingLicenseApplicationID,
                    ClassName = app.LicenseClass.ClassName,
                    NationalNumber = app.Application.Applicant.NationalNo,
                    FullName = app.Application.Applicant.FirstName + app.Application.Applicant.SecondName + app.Application.Applicant.ThirdName + app.Application.Applicant.LastName,
                    Status = app.Application.ApplicationStatus
                }).ToList();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Applications Data Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally { this.Cursor = Cursors.Default; }



        }


    }

}

