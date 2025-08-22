using BusinessLayer;
using Project19.Handlers;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19
{
    public partial class UsrCtrlEditPerson : UserControl
    {
       
        public string FIRSTNAME { get { return txtFirstName.Text; } }
        public string NaTIONALNO { get {return txtNationalnumb.Text; } }
        public string SECONDNAME { get { return txtSencondNAme.Text; } }    
        public string THIRDNAME { get { return txtThirdName.Text; } }
        public string LASTNAME { get{ return txtLastName.Text; } }
        public string EMAIL { get { return txtEmal.Text; } }
        public string PHONE { get{ return txtPhone.Text; } }

        private string _imagePath = null;
        public string IMAGEPATH { get { return _imagePath; } set { _imagePath = value; } }

        public Byte _Gendor = 0;
        public Byte GENDOR { get { return _Gendor; } set { _Gendor = value; } }

        public DateTime DATEOFBIRTH { get { return dtpDateOfBirth.Value; } }

        public string ADDRESS { get { return txtAddress.Text; } }

        public int NATIONALCOUNTRYID { get { return cmbCountry.SelectedIndex; } }

        public UsrCtrlEditPerson()
        {
            InitializeComponent();
            SetUpUserControls();
        }

        // My
        // Error desginTime
        //public UsrCtrlEditPerson(DataTable countrydt) : this()
        //{
        //    InitializeComponent();
        //    SetUpUserControls(countrydt);
        //}

        public void SetUpUserControls()
        {
            DataTable countries = new DataTable();
            countries= clsPeopleBusinessLayer.GetCountries();
            //DateTime MinAdultDate = DateTime.Today.AddYears(-18);

            //dtpDateOfBirth.MaxDate = MinAdultDate;
            cmbCountry.DataSource = countries;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";
            cmbCountry.SelectedValue = 3;
        }

        private void lblEditPicture_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                ImageHandler imageHandler = new ImageHandler();
                string imagePath = imageHandler.SelectAndSaveImage();

                if (string.IsNullOrEmpty(imagePath))
                {
                    return;
                }

                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.BackColor = Color.Transparent;
                _imagePath = imagePath;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error Loading Image:{ex.Message}");
                _imagePath = null;
            }
           
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {

            if (!ValidationHaldler.NameValidation(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider.SetError(txtFirstName, "Wrong Input");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFirstName, "");
            }
            
        }

        private void txtNationalnumb_Validating(object sender, CancelEventArgs e)
        {
            // Clear Previous Error
            errorProvider.SetError(txtNationalnumb, "");

            //input Validation
            if (!ValidationHaldler.NationalNumbValidation(txtNationalnumb.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNationalnumb, "Wrong National Number Input");
                return;
            }
            e.Cancel = false;


        }

        private void txtEmal_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmal.Text) )
            {                
                e.Cancel = true;
                txtEmal.Focus();
                errorProvider.SetError(txtEmal, "Email Requeiered");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmal, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidationHaldler.PhoneValidation(txtPhone.Text))
            {

                e.Cancel = true;
                txtEmal.Focus();
                errorProvider.SetError(txtPhone, "Wrong Input");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPhone, "");
            }
        }

        private void UsrCtrlEditPerson_Load(object sender, EventArgs e)
        {
            txtNationalnumb.Focus();
        }

        private async void txtNationalnumb_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalnumb.Text.Length >= 2 )
            {
                if (string.IsNullOrEmpty(txtNationalnumb.Text) || !ValidationHaldler.NationalNumbValidation(txtNationalnumb.Text))
                {
                    return;
                }

                try
                {
                    errorProvider.SetError(txtNationalnumb, "Checking...");

                    bool exists = await Task.Run(() => clsPeopleBusinessLayer.isNationaNoExists(txtNationalnumb.Text));
                    errorProvider.SetError(txtNationalnumb, exists ? "Already Exists" : "");

                }
                catch
                {
                    errorProvider.SetError(txtNationalnumb, "Check error");
                }
            }
        }

        private void rdbGendorMale_CheckedChanged(object sender, EventArgs e)
        {
            _Gendor = 1;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            _Gendor = 0;
        }
    }
    
}
