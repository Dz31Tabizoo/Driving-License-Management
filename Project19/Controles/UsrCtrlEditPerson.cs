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
       public int PERSONID { get { return Convert.ToInt32( lblPersonIdOutput.Text); } }
        public string FIRSTNAME { get { return txtFirstName.Text; } }
        public string NaTIONALNO { get {return txtNationalnumbOutput.Text; } }
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

        


       
        public void SetUpUserControls()
        {
            DataTable countries = new DataTable();
            countries = clsCountries.GetAllCountries();
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
            errorProvider.SetError(txtNationalnumbOutput, "");

            //input Validation
            if (!ValidationHaldler.NationalNumbValidation(txtNationalnumbOutput.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNationalnumbOutput, "Wrong National Number Input");
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
            txtNationalnumbOutput.Focus();
        }

        private async void txtNationalnumb_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalnumbOutput.Text.Length >= 2 )
            {
                if (string.IsNullOrEmpty(txtNationalnumbOutput.Text) || !ValidationHaldler.NationalNumbValidation(txtNationalnumbOutput.Text))
                {
                    return;
                }

                try
                {
                    errorProvider.SetError(txtNationalnumbOutput, "Checking...");

                    bool exists = await Task.Run(() => clsPeople.isNationaNoExists(txtNationalnumbOutput.Text));
                    errorProvider.SetError(txtNationalnumbOutput, exists ? "Already Exists" : "");

                }
                catch
                {
                    errorProvider.SetError(txtNationalnumbOutput, "Check error");
                }
            }
        }

        private void rdbGendorMale_CheckedChanged(object sender, EventArgs e)
        {
            _Gendor = 0;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            _Gendor = 1;
        }

        private void txtSencondNAme_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidationHaldler.NameValidation(txtSencondNAme.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider.SetError(txtSencondNAme, "Wrong Input");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSencondNAme, "");
            }
        }

        public void LoadPersonDetailsToEdit(DataGridViewRow row)
        {

            try
            {
                lblEditPicture.Text = "Edit Picture";
                lblPersonIdOutput.Text = row.Cells["PersonID"].Value?.ToString() ?? "N/A";
                txtNationalnumbOutput.Text = row.Cells["NationalNo"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
                txtSencondNAme.Text = row.Cells["SecondName"].Value?.ToString();
                txtThirdName.Text = row.Cells["ThirdName"].Value?.ToString();
                txtLastName.Text = row.Cells["LastName"].Value?.ToString();

                if (row.Cells["DateOfBirth"].Value is DateTime dateTimeValue)
                {
                    dtpDateOfBirth.Value = dateTimeValue;
                }
                else
                {
                    dtpDateOfBirth.Value = new DateTime(2010, 01, 01);
                }


                GENDOR = (Byte)( row.Cells["Gendor"].Value);


                if (GENDOR == 0)
                {
                    rdbGendorMale.Checked = true;
                    
                }
                else
                {
                    rdbGenderFemale.Checked = true;
                  
                }

                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmal.Text = row.Cells["Email"].Value.ToString();

                int UserCountryID = (int)row.Cells["NationalityCountryID"].Value;

                cmbCountry.SelectedIndex = UserCountryID - 1;

                ImageHandler imgH = new ImageHandler();
                string ImagePath = row.Cells["ImagePath"].Value?.ToString();
                if ((ImagePath == null || ImagePath == "") && GENDOR == 0)
                {
                    pictureBox10.Image = Properties.Resources.male;
                }
                else if ((ImagePath == null || ImagePath == "") && GENDOR == 1)
                {
                    pictureBox10.Image = Properties.Resources.muslimah;
                }
                else
                {                    
                    pictureBox10.Image = Image.FromFile(ImagePath);
                }

                

            }
            catch (Exception ex) { MessageBox.Show("Error Loading Details: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }

        
    }
    
}
