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
        public Frm_Shcuduel_Tests(clsLocalDrivingLicenseApplication localApp ,int testPassed, clsApplications application)
        {
            InitializeComponent();
            crtlLDVLappInfo1._LoadCrtlLocalAppInfo(localApp, testPassed);
            crtlApplicationInfo1.LoadApplicationInfo(application);
            LoadDataGridView(localApp.LocalDrivingLicenseApplicationID);
        }

        
        private async void LoadDataGridView(int localDVL_ID)
        {
            //to fix
            DataTable list = await clsTestAppointment.GetAllAppointments(localDVL_ID);
            dgvAppointments.AutoGenerateColumns = true;
            dgvAppointments.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
