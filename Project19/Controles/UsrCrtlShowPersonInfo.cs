using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Project19
{
    public partial class UsCrtlPersonCard : UserControl
    {
        public DataGridViewRow RR {  get; set; }

        public UsCrtlPersonCard()
        {
            InitializeComponent();           
        }

        public void LoadPersonData(DataGridViewRow row)
        {
            RR = row;

            try
            {
                lblPersonIdOutput.Text = row.Cells["PersonID"].Value?.ToString() ?? "N/A";
                lblNationalNoOutput.Text = row.Cells["NationalNo"].Value.ToString();
                lblNameOutput.Text = (row.Cells["FirstName"].Value?.ToString() + " " +
                                      row.Cells["SecondName"].Value?.ToString() + " " +
                                      row.Cells["ThirdName"].Value?.ToString() + " " +
                                      row.Cells["LastName"].Value?.ToString()).Trim();

                if (row.Cells["DateOfBirth"].Value is DateTime dateTimeValue)
                {
                    lblDateOfBirthOutput.Text = dateTimeValue.ToString("yyyy,MM,dd");
                }
                else
                {
                    lblDateOfBirthOutput.Text = "N/A";
                }


                object GENDOR = row.Cells["Gendor"].Value;
                if (GENDOR?.ToString() == "0")
                {
                    lblGenderOutput.Text = "Male";
                    pictureBox1.Image = Properties.Resources.male;
                }
                else
                {
                    lblGenderOutput.Text = "Female";
                    pictureBox1.Image = Properties.Resources.muslimah;

                }
                lblAddressOutput.Text = row.Cells["Address"].Value.ToString();
                lblPhoneOutput.Text = row.Cells["Phone"].Value.ToString();
                lblEmailOut.Text = row.Cells["Email"].Value.ToString();
                int UserCountryID = (int)row.Cells["NationalityCountryID"].Value;

                lblCountryOutput.Text = clsPeopleBusinessLayer.GetCountryNameByID(UserCountryID);

                string imgPath = row.Cells["Address"].Value.ToString();
                if ( string.IsNullOrEmpty(imgPath))
                {
                    pictureBox1.Image = Image.FromFile(imgPath);
                }
                
                    

            }
            catch (Exception ex) { MessageBox.Show("Error Loading Details: "+ ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lblEditPerson_LinkClicked(object sender, EventArgs e)
        {
            Frm_Person_Add_Edit frm = new Frm_Person_Add_Edit(RR);            
            frm.ShowDialog();
        }
    }
}
