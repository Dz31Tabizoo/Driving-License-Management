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

        // UI 



       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosePeopleMng_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void TxtSearchTerm_TextChanged(object sender, EventArgs e)
        {
            string col = cmbSearchCriteria.SelectedItem.ToString();
            if (col == "UserID" || col == "PersonID" )
            {
                foreach (char c in TxtSearchTerm.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        TxtSearchTerm.Clear();
                        errorProvider1.SetError(TxtSearchTerm, "Please, Only digits are accepted ");
                    }
                    else
                    {
                        errorProvider1.SetError(TxtSearchTerm, "");
                    }
                }
            }
            else if (col == "UserName")
            {
                foreach (char c in TxtSearchTerm.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        TxtSearchTerm.Clear();
                        errorProvider1.SetError(TxtSearchTerm, "Please, Only letters are accepted ");
                    }
                    else
                    {
                        errorProvider1.SetError(TxtSearchTerm, "");
                    }
                }
            }





                //Real Time Search
                btnSearch.PerformClick(); // trigger search 
        }
               
        private void TxtSearchTerm_MouseEnter(object sender, EventArgs e)
        {
            if (TxtSearchTerm.Text == "Search ...")
            {
                TxtSearchTerm.Text = string.Empty; 
                TxtSearchTerm.Focus();
            }

        }



        // check Columns
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




        //Logic on Event

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            TxtSearchTerm.Text = "";
            DataTable Dt = clsUser.GetAllUsers();
            dgvAllUsers.DataSource = Dt;
        }

        private void Frm_User_Load(object sender, EventArgs e)
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
            cmbSearchCriteria.Items.Insert(0, "Select an option...");
            
            foreach (DataColumn Col in Dt.Columns)
            {
                cmbSearchCriteria.Items.Add(Col.ColumnName);
            }
            cmbSearchCriteria.SelectedIndex = 0;
            cmbActiveStat.SelectedIndex = 0;
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
                        if (cmbActiveStat.SelectedIndex == 0)
                        {
                            Dt.DefaultView.RowFilter = $"[isActive] = {1}";
                        }
                        else
                        {
                            Dt.DefaultView.RowFilter = $"[isActive] = {0}";
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

        private void cmbSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dt = (DataTable)dgvAllUsers.DataSource;
            if (Dt == null) return;

            string SearchTerm = TxtSearchTerm.Text.Trim();
            string searchColumns = cmbSearchCriteria.SelectedItem.ToString();


            if (searchColumns == "IsActive")
            {
                TxtSearchTerm.Visible = false;
                cmbActiveStat.Visible = true;
            }
            else
            {
                TxtSearchTerm.Visible = true;
                cmbActiveStat.Visible = false;
                TxtSearchTerm.Text = string.Empty;
            }

            TxtSearchTerm.Text = string.Empty;
        }

        private void cmbActiveStat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DtUser = (DataTable)dgvAllUsers.DataSource;
            if (DtUser == null)
            {
                return;
            }

            if (cmbActiveStat.SelectedIndex == 0 )
            {
                DtUser.DefaultView.RowFilter = $"[isActive] = {1}";
            }
            else
            {
                DtUser.DefaultView.RowFilter = $"[isActive] = {0}";
            }



        }        

        private void lblAddPerson_Click(object sender, EventArgs e)
        {
            Form addUserForm = new Frm_Add_User();
            addUserForm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    } 
}
