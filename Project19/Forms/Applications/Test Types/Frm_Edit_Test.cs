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

namespace Project19.Forms.Applications.Test_Types
{
    public partial class Frm_Edit_Test : KryptonForm
    {
        public Frm_Edit_Test(clsTestTypes TP)
        {
            InitializeComponent();
            LoadLabels(TP);
        }

        private clsTestTypes UpdTest = null;

        private void LoadLabels(clsTestTypes tp)
        {
            lblTestIDNumb.Text = tp.TestID.ToString();
            tbTitle.Text = tp.TestTitle.ToString();
            tbPrice.Text = tp.TestFee.ToString();
            tbDescription.Text =tp.TestDescription.ToString();
            UpdTest = tp;
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
                UpdTest.TestFee = newFee;
                UpdTest.TestTitle = tbTitle.Text;
                if (Decimal.TryParse(lblNewPrice.Text,out decimal np))
                {
                    UpdTest.TestFee = np;
                }
                
                UpdTest.TestDescription = tbDescription.Text;

                if (UpdTest.UpdateTest())
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
