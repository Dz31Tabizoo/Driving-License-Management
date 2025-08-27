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
    public partial class Frm_User_Managment : KryptonForm
    {


        public Frm_User_Managment()
        {
            InitializeComponent();
        }


        private void People_Managment_Load(object sender, EventArgs e)
        {
            //Fill Data Grid View
            DataTable Dt = new DataTable();
            Dt = clsUser.GetAllUsers();
            dgvAllUsers.DataSource = Dt;
            //Count Data
            var Count = Dt.Rows.Count;
            lblTotalPeople.Text = lblTotalPeople.Text + ": [" + Count.ToString() + "]";
            //Search
            //Add Columns
            foreach (DataColumn Col in Dt.Columns)
            {
                cmbSearchCriteria.Items.Add(Col.ColumnName);
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
            DataTable Dt = (DataTable)dgvAllUsers.DataSource;
            if (Dt == null) return;

            string SearchTerm = TxtSearchTerm.Text.Trim();
            string searchColumns = cmbSearchCriteria.SelectedItem.ToString();


            // if search is empty allow all data
            if (string.IsNullOrEmpty(SearchTerm))
            {
                Dt.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                try
                {
                    if (IsNumericCulumn(Dt, searchColumns))
                    {
                        if (int.TryParse(SearchTerm, out int NumericValue))
                        {
                            Dt.DefaultView.RowFilter = $"[{searchColumns}] = {NumericValue}";
                        }
                        else
                        {
                            // show no result
                            Dt.DefaultView.RowFilter = "1 = 0";
                        }
                    }
                    else if (isDateTimeColumn(Dt, searchColumns))
                    {
                        if (DateTime.TryParse(SearchTerm, out DateTime DateValue))
                        {
                            Dt.DefaultView.RowFilter = $"[{searchColumns}] = #{DateValue:yyyy-MM-dd}#";
                        }
                        else
                        {
                            // show no result
                            Dt.DefaultView.RowFilter = "1 = 0";
                        }

                    }
                    else if (isByteColumn(Dt, searchColumns))
                    {
                        if (Byte.TryParse(SearchTerm, out Byte byteValue))
                        {
                            Dt.DefaultView.RowFilter = $"[{searchColumns}] = {byteValue}";
                        }
                    }
                    else
                    {
                        //for string columns

                        Dt.DefaultView.RowFilter = $"[{searchColumns}] LIKE '%{SearchTerm}%'";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Search : " + ex.Message, "SearchTerm Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void TxtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            //Real Time Search
            btnSearch.PerformClick(); // trigger search 
        }
        // Empty text filed

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            TxtSearchTerm.Text = "";
            DataTable Dt = clsPeople.GetAllPeople();
            dgvAllUsers.DataSource = Dt;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllUsers.SelectedRows.Count == 0)
                return;


            DataGridViewRow selectedRow = dgvAllUsers.SelectedRows[0];

            Form frm = new frmPerson_Details(selectedRow);
            frm.ShowDialog();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllUsers.SelectedRows.Count <= 0)
            {
                return;
            }
            DataGridViewRow SelectedRow = dgvAllUsers.SelectedRows[0];

            Form EdditFrom = new Frm_Person_Add_Edit(SelectedRow);
            EdditFrom.ShowDialog();


        }

        

        private void TxtSearchTerm_MouseEnter(object sender, EventArgs e)
        {
            if (TxtSearchTerm.Text == "Search ...")
            {
                TxtSearchTerm.Text = string.Empty; 
                TxtSearchTerm.Focus();
            }

        }

        private bool IsNumericCulumn(DataTable DDT, string ColumnName)
        {
            if (DDT.Columns.Contains(ColumnName))
            {
                Type ColumnType = DDT.Columns[ColumnName].DataType;
                return (ColumnType == typeof(int) || ColumnType == typeof(double) || ColumnType == typeof(float) || ColumnType == typeof(long) || ColumnType == typeof(short) || ColumnType == typeof(decimal));
            }
            else
            {
                return false;
            }
        }

        private bool isDateTimeColumn(DataTable DDT, string ColumnName)
        {
            if (!DDT.Columns.Contains(ColumnName))
            {
                return false;
            }

            Type ColType = DDT.Columns[ColumnName].GetType();
            return (ColType == typeof(DateTime));
        }

        private bool isByteColumn(DataTable DDT, string ColumnName)
        {
            if (!DDT.Columns.Contains(ColumnName))
            {
                return false;
            }

            Type type = DDT.Columns[ColumnName].GetType();
            return (type == typeof(Byte));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllUsers.SelectedRows.Count <= 0)
            {
                return;
            }
            DataGridViewRow SelectedRow = dgvAllUsers.SelectedRows[0];
            int PersID = Convert.ToInt32(SelectedRow.Cells["PersonID"].Value);
            DialogResult result = MessageBox.Show($"Do you confirm Delete ID {PersID} ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (clsPeople.DeletePerson(PersID))
                {
                    MessageBox.Show($"Person with ID {PersID} Deleted ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show($"Person with ID {PersID} is Not Deleted try again", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }



        }

        private void cmbSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dt = (DataTable)dgvAllUsers.DataSource;
            if (Dt == null) return;

            string SearchTerm = TxtSearchTerm.Text.Trim();
            string searchColumns = cmbSearchCriteria.SelectedItem.ToString();


            if (IsNumericCulumn(Dt,searchColumns))
            {
                
            }
        }
    } 
}
