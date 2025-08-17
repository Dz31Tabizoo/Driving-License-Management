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
    public partial class People_Managment : KryptonForm
    {
        

        public People_Managment()
        {
            InitializeComponent();
        }

        private void People_Managment_Load(object sender, EventArgs e)
        {
            //Fill Data Grid View
            DataTable Dt = new DataTable();
            Dt = clsPeopleBusinessLayer.GetAllPeople();
            dgvAllPeople.DataSource = Dt;
            //Count Data
            var Count = Dt.Rows.Count;
            lblTotalPeople.Text = lblTotalPeople.Text + ": [" + Count.ToString()+"]";
            //Search
               //Add Columns
            foreach (DataColumn Col in Dt.Columns)
            {
                cmbSearchCriteria.Items.Add(Col.ColumnName);
            }
               //select first item by defaul
            if (cmbSearchCriteria.Items.Count > 0)
            {
                cmbSearchCriteria.SelectedIndex = 0;
            }
            
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable Dt = (DataTable)dgvAllPeople.DataSource;
            if (Dt == null) return;

            string SearchTerm = TxtSearchTerm.Text.Trim();
            string searchColumns = cmbSearchCriteria.SelectedItem.ToString();
             // if search is empty allow all data
            if (string.IsNullOrEmpty(SearchTerm))
            {
                Dt.DefaultView.RowFilter = "";
            }
            else 
            {
                //for string columns
                Dt.DefaultView.RowFilter = $"[{searchColumns}] LIKE '%{SearchTerm}%'";
            }

        }      

        private void TxtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            //Real Time Search
            btnSearch.PerformClick(); // trigger search 
        }
        // Empty text filed
        private void TxtSearchTerm_MouseClick(object sender, MouseEventArgs e)
        {
            TxtSearchTerm.Text = "";
            TxtSearchTerm.Focus();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            TxtSearchTerm.Text = "";
            DataTable Dt = clsPeopleBusinessLayer.GetAllPeople();
            dgvAllPeople.DataSource = Dt;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllPeople.SelectedRows.Count == 0)
                return;
            

            DataGridViewRow selectedRow = dgvAllPeople.SelectedRows[0];

            Form frm = new frmPerson_Details(selectedRow);
            frm.ShowDialog();
            

        }

        
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblAddPerson_Click(object sender, EventArgs e)
        {
            KryptonForm form = new Add_Edit_Person();
            form.ShowDialog();
        }
    }
}
