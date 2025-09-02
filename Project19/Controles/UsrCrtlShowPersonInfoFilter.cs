using BusinessLayer;
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
    public partial class UsrCrtlShowPersonInfoFilter : UserControl
    {
        public UsrCrtlShowPersonInfoFilter()
        {
            InitializeComponent();
            LoadPersonsToSearch();
        }


        private DataTable DtPerson = clsPeople.GetAllPeople();

        private void LoadPersonsToSearch()
        {
            DataTable DtPerson = new DataTable();
            DtPerson = clsPeople.GetAllPeople();

            cmbPersonSearch.Items.Insert(0, "Select an option...");

            foreach (DataColumn dtC in DtPerson.Columns)
            {
                cmbPersonSearch.Items.Add(dtC);
            }
            if (cmbPersonSearch.Items.Count > 0)
            {
                cmbPersonSearch.SelectedIndex = 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string TextSearch = TxtSearchTerm.Text;
            string ColToSearchIn = cmbPersonSearch.SelectedItem.ToString();

            if (string.IsNullOrEmpty(TextSearch) || string.IsNullOrEmpty(ColToSearchIn))
            {
                MessageBox.Show("Chose a Filter and Searsh Please", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string filter = $"{ColToSearchIn} = {TextSearch}";
                try
                {
                    DataRow[] DtPersonRow = DtPerson.Select(filter);
                    if (DtPersonRow.Length != 0)
                    {
                        MessageBox.Show($"There is {DtPersonRow.Length} matching record(s) found.", "Search Results",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataRow PersonInfos = DtPersonRow[0];
                        FillLabelsPersonInfo(PersonInfos);
                    }
                    else
                    {

                        MessageBox.Show("No matching records found.", "Search Results",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Search Error : {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }




        }

        private void FillLabelsPersonInfo(DataRow row)
        {
            if (row.Table.Columns.Contains("PersonID"))
            {
                lblPersonIdOutput.Text = row["PersonID"].ToString();
            }

            if (row.Table.Columns.Contains("FirstName") && row.Table.Columns.Contains("SecondName") && row.Table.Columns.Contains("ThirdName") && row.Table.Columns.Contains("LastName"))
            {
                lblNameOutput.Text = (row["FirstName"].ToString() + " " + row["SecondName"].ToString() + " " + row["ThirdName"].ToString() + " " + row["LastName"].ToString()).Trim();
            }



            if (row.Table.Columns.Contains("NationalNo"))
            {
                lblNationalNoOutput.Text = row["NationalNo"].ToString();
            }

            if (row.Table.Columns.Contains("DateOfBirth") && row["DateOfBirth"] is DateTime DateTimeValue)
            {
                lblDateOfBirthOutput.Text = DateTimeValue.ToString("yyyy MMM dd");
            }

            if (row.Table.Columns.Contains("Gendor"))
            {

                if (row["Gendor"].ToString() == "0")
                {
                    lblGenderOutput.Text = "Male";
                    pictureBox1.Image = Properties.Resources.male;
                }
                else
                {
                    lblGenderOutput.Text = "Female";
                    pictureBox1.Image = Properties.Resources.muslimah;
                }
            }


            if (row.Table.Columns.Contains("Address"))
            {
                lblAddressOutput.Text = row["Address"].ToString();
            }

            if (row.Table.Columns.Contains("Phone"))
            {
                lblPhoneOutput.Text = row["Phone"].ToString();
            }

            if (row.Table.Columns.Contains("Email"))
            {
                lblEmailOut.Text = row["Email"].ToString();
            }


            if (row.Table.Columns.Contains("NationalityCountryID"))
            {
                int PersonCountryId = (int)row["NationalityCountryID"];

                lblCountryOutput.Text = clsPeople.GetCountryNameByID(PersonCountryId);
            }




            if (row.Table.Columns.Contains("ImagePath"))
            {
                if (!string.IsNullOrEmpty(row["ImagePath"].ToString()))
                {
                    pictureBox1.Image = Image.FromFile(row["ImagePath"].ToString());
                }
                
            }

        }


    }
}