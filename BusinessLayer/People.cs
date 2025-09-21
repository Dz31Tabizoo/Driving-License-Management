using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer; 

namespace BusinessLayer
{
    //Custom Exception class
    public class BusinessLayerException : Exception
    {
        public BusinessLayerException(string message, Exception inner)
            : base(message, inner) { }
    }

    public class clsPeople
    {
        public enum enMode { AddNew=0, Update=1}
        public enMode CurrentMode { get; private set; } = enMode.AddNew;
        public int PersonID { get; set; }
        public string FirstName {  get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Byte Gender {  get; set; }
        public string Address {  get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        // constructor

        public clsPeople()
        {
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.NationalNo = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gender = 0;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;
            this.CurrentMode = enMode.AddNew;

        }

        public clsPeople(int Personid, string firstname, string secondname, string thirdname, string lastname,
            string nationalNo, DateTime dateofbirth, byte gender, string address, string phone, string email,
            int nationalcountryid, string imagepath)
        {
            this.PersonID = Personid;
            this.FirstName = firstname;
            this.SecondName = secondname;
            this.ThirdName = thirdname;
            this.LastName = lastname;
            this.NationalNo = nationalNo;
            this.DateOfBirth = dateofbirth;
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalcountryid;
            this.ImagePath = imagepath;

            this.CurrentMode = enMode.Update;
        }

        // OBV
        public static clsPeople FindPersonByID(int ID)
        {
            try
            {
                string firstname = ""; string secondname = ""; string thirdname = ""; string lastname = "";
                string nationalNo = "";
                DateTime dateofbirth = DateTime.Now;
                byte gender = 0; string address = string.Empty; string phone = string.Empty; string email = string.Empty;
                int nationalcountryid = -1; string imagepath = string.Empty;


                if (clsPeopleDAL.FindPersonByID(ID, ref firstname, ref secondname, ref thirdname, ref lastname, ref nationalNo, ref dateofbirth, ref gender, ref address, ref phone, ref email, ref nationalcountryid, ref imagepath))
                {
                    return new clsPeople(ID, firstname, secondname, thirdname, lastname, nationalNo, dateofbirth, gender, address, phone, email, nationalcountryid, imagepath);
                }
                else return null;
            }
            catch(SqlException Sqlex)
            {
                throw new BusinessLayerException("Error retriving person data", Sqlex);
            }
            catch(Exception ex)
            {
                throw new BusinessLayerException("Unexpected error occurred", ex);
            }
        }

        public static DataTable GetAllPeople()
        {
            
            try
            {
                return clsPeopleDAL.GetAllPeople()?? new DataTable();
            }
            catch (SqlException Sqlex)
            {
                throw new BusinessLayerException("Error retriving data", Sqlex);
            }
            catch (Exception ex)
            {
                throw new BusinessLayerException("Unexpected error occurred", ex);
            }
            
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDAL.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _Update()
        {
            return (clsPeopleDAL.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath));
        }

        public static DataTable GetCountries()
        {
            return clsPeopleDAL.GetCountries();
        }

        public static bool isNationaNoExists(string Nat_num)
        {
            return clsPeopleDAL.isNationalNoExist(Nat_num);
        }

        public bool Save()
        {
            switch(CurrentMode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        CurrentMode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return (_Update());
            }
            return false;
        }

        public static string GetCountryNameByID(int ID)
        {
            return clsPeopleDAL.GetCounryNameByID(ID);
        }

        public static bool DeletePerson(int ID)
        {
            return clsPeopleDAL.DeletePerson(ID);
        }

    }
}
