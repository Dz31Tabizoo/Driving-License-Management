using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19
{
    public partial class Frm_Add_User : KryptonForm
    {
        public Frm_Add_User()
        {
            InitializeComponent();
        }

        public DataRow PersonFoundinfo {  get; set; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           btnClear.PerformClick();
        }

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            Frm_Find_Person frm = new Frm_Find_Person();
            frm.EvGetPerson += GetPerson;
            frm.ShowDialog();
        }
        
        
        private void GetPerson(object sender,int PersID)
        {
            usCrtlPersonCard1.LoadLabels(PersID);
        }

    }
}
