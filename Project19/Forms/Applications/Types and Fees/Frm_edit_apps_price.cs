using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project19
{
    public partial class Frm_edit_apps_price : KryptonForm
    {
        public Frm_edit_apps_price(clsApplicationTypes Type)
        {
            InitializeComponent();
            LoadexPrice(Type);
        }

        private clsApplicationTypes Type = null;

        private void LoadexPrice(clsApplicationTypes apType)
        {
            Type = apType;
            tbPrice.Text = apType.ApplicationFee.ToString();
            this.DialogResult = DialogResult.Abort;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbPrice.Text,out decimal newFee))
            {            
                return;
            }

            if (clsApplicationTypes.UpdateAppFee(Type.ApplicationTypeID,newFee))
            {
                this.DialogResult = DialogResult.OK;
                DialogResult res = MessageBox.Show("Edit Price", "Price Edited Seccssefully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
