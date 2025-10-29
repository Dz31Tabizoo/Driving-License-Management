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
                DataTable dt = await clsLocalDrivingLicenseApplication.GetAllLocalDriveLicenseApps();
                this.Cursor = Cursors.WaitCursor;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Load Applications Data Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvApplications.AutoGenerateColumns = true;
                dgvApplications.DataSource = dt;

                dgvApplications.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "Local DVL Applic Id";

                lblTotalUserNum.Text = dgvApplications.RowCount.ToString();

                LoadComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load Applications Data Failed \n |{ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally { this.Cursor = Cursors.Default; }



        }

        private void LoadComboBox()
        {
            cmbSearchCriteria.Items.Clear();

            cmbSearchCriteria.Items.Add("Select Filter..");

            foreach (DataGridViewColumn Col  in dgvApplications.Columns)
            {
                cmbSearchCriteria.Items.Add(Col.HeaderText);
            }
            cmbSearchCriteria.SelectedIndex = 0;
        }       

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAddPerson_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAddPerson_Click(object sender, EventArgs e)
        {
            OpenAddNewLocalDVLApplication();
        }

        private void AddNewtoolstrip_Click(object sender, EventArgs e)
        {
            OpenAddNewLocalDVLApplication();
        }

        private void OpenAddNewLocalDVLApplication()
        {


            using (var form = new Frm_Add_New_Local_DVL())
            {
                form.ShowDialog();
            }

            LoadDataGridView();
        }       

        private async void visionTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an application first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow Row = dgvApplications.SelectedRows[0];

            int TestPassed = (int)Row.Cells["PassedTestCount"].Value;
            int ldvlAppID = (int)Row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication LDVlapp = await clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);
            clsApplications app = await clsApplications.FindApplicationByID(LDVlapp.ApplicationID);


            using (var frm = new Frm_View_Shcudueled_Tests(LDVlapp, TestPassed, app,1))
            {
                // (1) is TestTypeID of vision test
                frm.ShowDialog();
            }
            //REFRESH
            LoadDataGridView();
        }

        private async void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            ResetTestMenuItems();

            DataGridViewRow row = dgvApplications.SelectedRows[0];
            int ldvlAppID = (int)row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication ldvlApp = await clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);

            if (ldvlApp.Application.ApplicationStatus == clsApplications.enAppStatus.Completed || ldvlApp.Application.ApplicationStatus == clsApplications.enAppStatus.Cancelled)
            {
                // enable or disable context menu strip items 
            }

            if (!await clsTestAppointment.IsApplicantHasPassedTypeOfTest(ldvlAppID,1))
            {
                visionTestToolStripMenuItem1.Enabled = true;
            }
            else if (!await clsTestAppointment.IsApplicantHasPassedTypeOfTest(ldvlAppID,2))
            {
                writtenTestToolStripMenuItem1.Enabled = true;
                                
            }
            else if (!await clsTestAppointment.IsApplicantHasPassedTypeOfTest(ldvlAppID,3))
            {
                practicalToolStripMenuItem1.Enabled = true;
            }
            



        }

        private void ResetTestMenuItems()
        {
            visionTestToolStripMenuItem1.Enabled = false;
            writtenTestToolStripMenuItem1.Enabled = false;
            practicalToolStripMenuItem1.Enabled = false;
        }

        private async void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvApplications.SelectedRows[0];
            int ldvlAppID = (int)row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication ldvlApp = await clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);

            if (ldvlApp.Application.ApplicationStatus == clsApplications.enAppStatus.Completed || ldvlApp.Application.ApplicationStatus == clsApplications.enAppStatus.Cancelled)
            {
                MessageBox.Show("Can't cancel a Completed or Canceled applications", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (await clsApplications.UpdateApplicationStatus(ldvlApp.Application.AppID,(byte)clsApplications.enAppStatus.Cancelled))
            {
                MessageBox.Show("Application Canceled ", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            
        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenAddNewLocalDVLApplication();
        }

        private async void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvApplications.SelectedRows[0];
            int ldvlAppID = (int)row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication ldvlApp = await clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);

            DialogResult res = MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                if (await clsLocalDrivingLicenseApplication.DeleteLocalDrvAppByIDAsync(ldvlAppID))
                {
                    MessageBox.Show("Successful application delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("fail application delete : The data is spread across multiple tables.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }


        }

        private void showDrivingLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private async void ShowDetailsTSMI_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an application first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow Row = dgvApplications.SelectedRows[0];

            int TestPassed = (int)Row.Cells["PassedTestCount"].Value;
            int ldvlAppID = (int)Row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication LDVlapp = await clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);
            clsApplications app = await clsApplications.FindApplicationByID(LDVlapp.ApplicationID);

            using (var details_form = new Frm_Application_Details(app) )
            {
                details_form.ShowDialog();
            }

        }

        private async void writtenTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an application first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow Row = dgvApplications.SelectedRows[0];

            int TestPassed = (int)Row.Cells["PassedTestCount"].Value;
            int ldvlAppID = (int)Row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication LDVlapp = await clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);
            clsApplications app = await clsApplications.FindApplicationByID(LDVlapp.ApplicationID);


            using (var frm = new Frm_View_Shcudueled_Tests(LDVlapp, TestPassed, app, 2))
            {
                // (1) is TestTypeID of vision test
                frm.ShowDialog();
            }
            //REFRESH
            LoadDataGridView();
        }

        private async void practicalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an application first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow Row = dgvApplications.SelectedRows[0];

            int TestPassed = (int)Row.Cells["PassedTestCount"].Value;
            int ldvlAppID = (int)Row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication LDVlapp = await clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);
            clsApplications app = await clsApplications.FindApplicationByID(LDVlapp.ApplicationID);


            using (var frm = new Frm_View_Shcudueled_Tests(LDVlapp, TestPassed, app, 3))
            {
                // (1) is TestTypeID of vision test
                frm.ShowDialog();
            }
            //REFRESH
            LoadDataGridView();
        }








    }

}

