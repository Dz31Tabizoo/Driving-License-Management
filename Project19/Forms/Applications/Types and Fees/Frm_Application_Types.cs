using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dgvQpps.DataSource = dt;

            dgvQpps.Columns[0].HeaderText = "App ID";
            dgvQpps.Columns[0].Width = 70;
            dgvQpps.Columns[1].HeaderText = "App Title";
            dgvQpps.Columns[1].Width = 200;
            dgvQpps.Columns[2].HeaderText = "App Fee";
            dgvQpps.Columns[2].Width = 100;

            lblTotalAppsNumb.Text = dt.Rows.Count.ToString(); 
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvQpps.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "No Selection",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var rowID = dgvQpps.CurrentRow.Cells["ApplicationTypeID"].Value;
            var rowPrice = dgvQpps.CurrentRow.Cells["ApplicationFees"].Value;
            string Title = dgvQpps.CurrentRow.Cells["ApplicationTypeTitle"].Value.ToString();

            if(int.TryParse(rowID.ToString(), out int id) && decimal.TryParse(rowPrice.ToString(), out decimal fee))
            {
                clsApplicationTypes tp = new clsApplicationTypes(id, Title, fee);

                using (Form editPrice = new Frm_edit_apps_price(tp))
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

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

