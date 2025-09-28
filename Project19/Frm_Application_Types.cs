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
    public partial class Frm_Application_Types : KryptonForm
    {
        public Frm_Application_Types()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            DataTable dt = await clsApplicationTypes.GetAllAppTypes();
            dgvAllUsers.DataSource = dt;
        }


    }
}
