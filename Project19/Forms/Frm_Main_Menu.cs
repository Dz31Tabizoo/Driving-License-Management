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

namespace Project19
{
    public partial class Frm_Main_Menu : KryptonForm
    {
        public Frm_Main_Menu()
        {
            InitializeComponent();
            CostumTools();
        }

        public void CostumTools()
        {
            kryptonPanel2.Visible = false;

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonPanel2.Visible == false)
            {
                kryptonPanel2.Visible= true;
                return;
            }
            else
            {
                kryptonPanel2.Visible = false;
            }

        }

        private void btnPeopleMng_Click(object sender, EventArgs e)
        {
            KryptonForm frm = new People_Managment();
            frm.ShowDialog();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            KryptonForm frm = new Frm_User_Managment();
            frm.ShowDialog();
        }
    }
}
