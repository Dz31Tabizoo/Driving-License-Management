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
        private bool isDropDownOpening = false;

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
                MessageBox.Show("Load Applications Data Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            using (var form = new Frm_New_Local_DVL())
            {
                form.ShowDialog();
            }

        }

       

        private async void visionTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a user first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow Row = dgvApplications.SelectedRows[0];

            int TestPassed = (int)Row.Cells["PassedTestCount"].Value;
            int ldvlAppID = (int)Row.Cells["LocalDrivingLicenseApplicationID"].Value;

            clsLocalDrivingLicenseApplication LDVlapp = clsLocalDrivingLicenseApplication.FindLDVLapplicationById(ldvlAppID);
            clsApplications app = await clsApplications.FindApplicationByID(LDVlapp.ApplicationID);


            using (var frm = new Frm_Shcuduel_Tests(LDVlapp, TestPassed, app))
            {
                frm.ShowDialog();
            }
        }
    }

}

