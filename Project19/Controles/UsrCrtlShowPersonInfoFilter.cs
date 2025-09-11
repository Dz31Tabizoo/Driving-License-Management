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
        public DataRow PersonRow { get; set; }

        private int _PersonID = -1;
        public int PersID
        {
            get
            {
                if (int.TryParse(lblPersonIdOutput.Text, out int result))
                    return result;

                return -1;
            }
            set { _PersonID = value; }
        }


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
                if (!dtC.ColumnName.EndsWith("Path") && dtC.DataType != typeof(byte)  )
                {
                    cmbPersonSearch.Items.Add(dtC);
                }
                
            }
            if (cmbPersonSearch.Items.Count > 0)
            {
                cmbPersonSearch.SelectedIndex = 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string TextSearch = TxtSearchTerm.Text.Trim();

            string ColToSearchIn = cmbPersonSearch.SelectedItem.ToString();

            if (cmbPersonSearch.SelectedItem == null || cmbPersonSearch.SelectedIndex == 0 || string.IsNullOrWhiteSpace(TextSearch))
            {
                MessageBox.Show("Choosing a filter and filling the search bar are required Please", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }           
            else
            {
                string filter;

                try
                {
                    if (DtPerson.Columns[ColToSearchIn].DataType == typeof(DateTime))
                    {
                        if (DateTime.TryParse(TextSearch, out DateTime dateSearch))
                        {
                            filter = $"{ColToSearchIn} = #{dateSearch:yyyyy,MM,dd#}#";
                        }
                        else
                        {

                            MessageBox.Show("Please Enter a Valide format {yyyy,MM,dd}.", "Search Results",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                        }
                    }
                    else
                    {
                        filter = $"{ColToSearchIn} = {TextSearch}";

                        DataRow[] dtPersonRow = DtPerson.Select(filter);

                        if (dtPersonRow != null || dtPersonRow.Length > 0)
                        {
                            MessageBox.Show($"Found {dtPersonRow.Length} matching records.", "Search Results",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                            PersonRow = dtPersonRow[0];
                            FillLabelsPersonInfo(dtPersonRow[0]);

                        }
                        else
                        {

                            MessageBox.Show("No matching records found.", "Search Results",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
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

        private void TxtSearchTerm_MouseEnter(object sender, EventArgs e)
        {
            if (TxtSearchTerm.Text == "Search ...")
            {
                TxtSearchTerm.Text = string.Empty;
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Frm_Person_Add_Edit frm = new Frm_Person_Add_Edit();
            frm.PersonBack += GetThePerson;
            frm.ShowDialog();

        }

        private void GetThePerson(object sender, clsPeople NewPerson)
        {
                 _PersonID = NewPerson.PersonID;

                lblPersonIdOutput.Text = NewPerson.PersonID.ToString();          

            
                lblNameOutput.Text = NewPerson.FirstName.ToString() + " " + NewPerson.SecondName.ToString() + " " + NewPerson.ThirdName.ToString() + " " + NewPerson.LastName.ToString().Trim();
            



            
                lblNationalNoOutput.Text = NewPerson.NationalNo.ToString();
           

                lblDateOfBirthOutput.Text = NewPerson.DateOfBirth.ToString("yyyy MMM dd");

                if (NewPerson.Gender.ToString() == "0")
                {
                    lblGenderOutput.Text = "Male";
                    pictureBox1.Image = Properties.Resources.male;
                }
                else
                {
                    lblGenderOutput.Text = "Female";
                    pictureBox1.Image = Properties.Resources.muslimah;
                }


                lblAddressOutput.Text = NewPerson.Address.ToString();
                lblPhoneOutput.Text = NewPerson.Phone.ToString();
                lblEmailOut.Text = NewPerson.Email.ToString();

                 

                lblCountryOutput.Text = clsPeople.GetCountryNameByID(NewPerson.NationalityCountryID);


                //if (!string.IsNullOrEmpty(NewPerson.ImagePath.ToString()))
                //{
                //    pictureBox1.Image = Image.FromFile(NewPerson.ImagePath.ToString());
                //}


        }




    }
}