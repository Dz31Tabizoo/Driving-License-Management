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
        }

        // public Frm_Person_Add_Edit(DataTable DtCountry) : this()
        //{
        //    InitializeComponent(DtCountry);
        //}


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
            Person.NationalityCountryID = usrCtrlEditPerson1.NATIONALCOUNTRYID;
            Person.ImagePath = usrCtrlEditPerson1.IMAGEPATH;

            return Person.Save() ? true : false;


            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SavePersonInfo()) {MessageBox.Show("Person Save Successfuly","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);}
            else 
            {
                MessageBox.Show("Person Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
