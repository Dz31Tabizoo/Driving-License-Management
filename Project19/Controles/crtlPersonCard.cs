using BusinessLayer;
using Project19.Properties;

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
using System.IO;

namespace Project19
{
    public partial class UsCTRLPersonCard : UserControl
    {
        public DataGridViewRow PersonDetailsRow {  get; set; }

        private clsPeople _Person;
        public clsPeople SelectedPerson { get { return _Person;  } }
       public int PERSONID { get { return Convert.ToInt32(lblPersonIdOutput.Text); }  }



        public UsCTRLPersonCard()
        {
            InitializeComponent();           
        }

        public void LoadLabels(int personID)
        {
            _Person = clsPeople.FindPersonByID(personID);

            lblPersonIdOutput.Text = personID.ToString();
            lblNationalNoOutput.Text = _Person.NationalNo;
            lblAddressOutput.Text = _Person.Address;
            lblNameOutput.Text = (_Person.FirstName ?? "" + " " +
                                      _Person.SecondName ?? "" + " " +
                                      _Person.ThirdName ?? "" + " " +
                                      _Person.LastName?? "").Trim();
            lblGenderOutput.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblDateOfBirthOutput.Text = _Person.DateOfBirth.ToString("dd-MM-yyyy");
            lblCountryOutput.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName.ToString();
                //clsPeople.GetCountryNameByID(_Person.NationalityCountryID);
            lblPhoneOutput.Text = _Person.Phone;
            _LoadPersonPicture();
        }

        private void _LoadPersonPicture()
        {
            if (_Person.Gender == 0)
            {
                pbPersonImage.Image = Resources.male;

            }
            else
            {
                pbPersonImage.Image = Resources.muslimah;
            }


            string imagePath = _Person.ImagePath;



            if (!string.IsNullOrEmpty(imagePath))
            {
                if (File.Exists(imagePath))
                {
                    pbPersonImage.ImageLocation = imagePath;
                }
                else
                {
                    MessageBox.Show("Could not find this image: " + imagePath, "Image Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void lblEditPerson_LinkClicked(object sender, EventArgs e)
        {
            Frm_Person_Add_Edit frm = new Frm_Person_Add_Edit(PersonDetailsRow);            
            frm.ShowDialog();
        }



    }
}
