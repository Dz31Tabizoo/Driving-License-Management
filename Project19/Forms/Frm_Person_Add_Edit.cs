using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ComponentFactory.Krypton.Toolkit;


namespace Project19
{
    public partial class Frm_Person_Add_Edit : KryptonForm
    {
        public Frm_Person_Add_Edit()
        {
            InitializeComponent();
            btnSaveEdit.Enabled = false;
            btnSaveEdit.Visible = false;
        }

        public Frm_Person_Add_Edit(DataGridViewRow EdRow)
        {
            InitializeComponent();
            usrCtrlEditPerson1.LoadPersonDetailsToEdit(EdRow);
            btnSave.Enabled = false;
            btnSave.Visible = false;
            lblTitle.Text = "Edit Person Information";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SavePersonInfo()
        {
            clsPeopleBusinessLayer Person = new clsPeopleBusinessLayer();
            Person.FirstName = usrCtrlEditPerson1.FIRSTNAME;
            Person.SecondName = usrCtrlEditPerson1.SECONDNAME;
            Person.ThirdName = usrCtrlEditPerson1.THIRDNAME;
            Person.LastName = usrCtrlEditPerson1.LASTNAME;
            Person.NationalNo = usrCtrlEditPerson1.NaTIONALNO;
            Person.DateOfBirth = usrCtrlEditPerson1.DATEOFBIRTH;
            Person.Gender = usrCtrlEditPerson1.GENDOR;
            Person.Address = usrCtrlEditPerson1.ADDRESS;
            Person.Email = usrCtrlEditPerson1.EMAIL;
            Person.Phone = usrCtrlEditPerson1.PHONE;
            Person.NationalityCountryID = usrCtrlEditPerson1.NATIONALCOUNTRYID+1;
            Person.ImagePath = usrCtrlEditPerson1.IMAGEPATH;

            return Person.Save() ? true : false;            
        }

        private bool SaveUpdatedPerson()
        {
            int PersonId = usrCtrlEditPerson1.PERSONID;
            string FirstName = usrCtrlEditPerson1.FIRSTNAME;
            string SecondName = usrCtrlEditPerson1.SECONDNAME;
            string ThirdName = usrCtrlEditPerson1.THIRDNAME;
            string LastName = usrCtrlEditPerson1.LASTNAME;
            string NationalNo = usrCtrlEditPerson1.NaTIONALNO;
            DateTime DateOfBirth = usrCtrlEditPerson1.DATEOFBIRTH;
            Byte Gender = usrCtrlEditPerson1.GENDOR;
            string Address = usrCtrlEditPerson1.ADDRESS;
            string Email = usrCtrlEditPerson1.EMAIL;
            string Phone = usrCtrlEditPerson1.PHONE;
            int NationalityCountryID = usrCtrlEditPerson1.NATIONALCOUNTRYID+1;
            string ImagePath = usrCtrlEditPerson1.IMAGEPATH;

            clsPeopleBusinessLayer EditedPerson = new clsPeopleBusinessLayer(PersonId, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            return (EditedPerson.Save()); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SavePersonInfo()) 
            {
                DialogResult Result = MessageBox.Show("Person Save Successfuly","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            else 
            {
                MessageBox.Show("Person Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (SaveUpdatedPerson())
            {
                DialogResult Result = MessageBox.Show("Person's Info Details Edited & Save Successfuly", "Edit_Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Result == DialogResult.OK)
                {
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Person's New Info Details Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
