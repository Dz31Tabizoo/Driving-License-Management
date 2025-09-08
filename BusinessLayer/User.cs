using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUser
    {

        public enum enMode { AddNew = 0, Update = 1 }

        public enMode CurrentMode { get; private set; } = enMode.AddNew;
        public int UserID { get; set; }
        
        public clsPeople Person { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        
        public clsUser() 
        {
            UserID = -1;
            Person = new clsPeople();
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
        
            CurrentMode = enMode.AddNew;     
        }

        public clsUser(int userID , clsPeople person , string username , string password , bool isactive)
        {
            this.UserID = userID;
            this.Person = person ?? new clsPeople();
            this.UserName = username;
            this.Password = password;
            this.IsActive = isactive;

            this.CurrentMode = enMode.Update;
        }

        

        public static clsUser FindUserByUserName(string Username)
        {
            int PersonID = -1;
            string PassWord = string.Empty;
            bool isAvtive = false;
            int UserID = -1;

            if (Username == null) { return null; }
            try
            {
                if (clsUserDAL.FindUserByName(Username, ref PassWord, ref isAvtive, ref PersonID, ref UserID))
                {
                    clsPeople person = clsPeople.FindPersonByID(PersonID);

                    return new clsUser(UserID, person, Username, PassWord, isAvtive);

                }
                return null;
            }
            catch (SqlException Sqlex)
            {
                throw new BusinessLayerException("Error retriving person data", Sqlex);
            }
            catch (Exception ex)
            {
                throw new BusinessLayerException("Unexpected error occurred", ex);
            }
            
        }

        public static DataTable GetAllUsers()
        {           
             return clsUserDAL.GetAllUsers();          
        }

        private bool _AddNewUser()
        {

            this.UserID = clsUserDAL.AddNewUserToDB(this.UserName, this.Password, this.IsActive, this.Person.PersonID);

            return (this.UserID != -1);
        }

        public bool Save()
        {
            switch (CurrentMode)
            {
                case enMode.AddNew:
                    return _AddNewUser();

                case enMode.Update:
                    break;

                default:
                    break;

            }
                


            return true;
        }

    }
}
