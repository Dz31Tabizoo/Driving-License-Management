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
            LoadLine(Type);
        }



        private clsApplicationTypes Type = null;

        private void LoadLine(clsApplicationTypes apType)
        {
            Type = apType;

            tbPrice.Text = apType.ApplicationFee.ToString();
            tbTitle.Text = apType.ApplicationTypeTitle.ToString();
            lblAppIDNumb.Text = apType.ApplicationTypeID.ToString();
            this.DialogResult = DialogResult.Abort;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbPrice.Text, out decimal newFee))
            {
                return;
            }
            else
            {
                Type.ApplicationFee = newFee;
                Type.ApplicationTypeTitle = tbTitle.Text;
                Type.ApplicationTypeID = int.Parse(lblAppIDNumb.Text);

                if (Type.UpdateAppFee())
                {
                    this.DialogResult = DialogResult.OK;

                    DialogResult res = MessageBox.Show("Edited Successfully!", "Edit Fees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    if (res == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
            }
        }
    }
}
