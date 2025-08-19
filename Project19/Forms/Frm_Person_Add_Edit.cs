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
    public partial class Frm_Person_Add_Edit : KryptonForm
    {
        public Frm_Person_Add_Edit()
        {
            InitializeComponent();
        }

        // public Frm_Person_Add_Edit(DataTable DtCountry) : this()
        //{
        //    InitializeComponent(DtCountry);
        //}


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
