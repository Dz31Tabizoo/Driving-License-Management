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
    public partial class frmPerson_Details : KryptonForm
    {
        public frmPerson_Details(DataGridViewRow roo)
        {
            InitializeComponent();
            usCrtlPersonCard1.LoadPersonData(roo);

        }  

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
