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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Applications Data Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally { this.Cursor = Cursors.Default; }



        }

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

