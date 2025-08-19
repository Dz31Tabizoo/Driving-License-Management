using BusinessLayer;
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
        public UsrCtrlEditPerson()
        {
            InitializeComponent();
            SetUpUserControls();
        }

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
            ImageHandler imageHandler = new ImageHandler();

            string imagePath = imageHandler.SelectAndSaveImage();
            pictureBox1.Image = Image.FromFile(imagePath);
            pictureBox1.BackColor = Color.Transparent;
            if (string.IsNullOrEmpty(imagePath))
            {
                return ;
            }
        }
    }
}
