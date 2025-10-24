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

namespace Project19.Forms.Applications.Test_Types
{
    public partial class Frm_Test_Types : KryptonForm
    {
        public Frm_Test_Types()
        {
            InitializeComponent();
            LoadData();
        }


        private async void LoadData()
        {
            DataTable dt = await clsTestTypes.GetData();
            dgvQpps.DataSource = dt;

            dgvQpps.Columns[0].HeaderText = "Test ID";
            dgvQpps.Columns[0].Width = 70;
            dgvQpps.Columns[1].HeaderText = "Test Title";
            dgvQpps.Columns[1].Width = 150;
            dgvQpps.Columns[2].HeaderText = "Test Description";
            dgvQpps.Columns[2].Width = 300;
            dgvQpps.Columns[3].HeaderText = "Test Fee";
            dgvQpps.Columns[3].Width = 100;

            lblTotalAppsNumb.Text = dt.Rows.Count.ToString();
        }

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvQpps.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "No Selection",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string rowID = dgvQpps.CurrentRow.Cells["TestTypeID"].Value.ToString();
            var rowPrice = dgvQpps.CurrentRow.Cells["TestTypeFees"].Value;
            string Title = dgvQpps.CurrentRow.Cells["TestTypeTitle"].Value.ToString();
            string Descrp= dgvQpps.CurrentRow.Cells["TestTypeDescription"].Value.ToString();

            if (Enum.TryParse<clsTestTypes.enTestType>(rowID,out clsTestTypes.enTestType enumValue)  && decimal.TryParse(rowPrice.ToString(), out decimal fee))
            {
                clsTestTypes tp = new clsTestTypes(enumValue,Title,Descrp,fee);

                using (Form editPrice = new Frm_Edit_Test(tp))
                {
                    DialogResult result = editPrice.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid data format in selected row.", "Parse Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
