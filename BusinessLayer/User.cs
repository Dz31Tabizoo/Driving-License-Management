using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
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

        public static bool IsUsernameExiste(string usnm)
        {
            return clsUserDAL.isUsernameExist(usnm);     
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

        public static clsUser FindUserByUserNameAndPassword(string Username,string PassWord)
        {
            int PersonID = -1;
            bool isActive = false;
            int UserID = -1;

            if (Username == null) { return null; }
            try
            {
                if (clsUserDAL.FindUserByNameAndPassword(Username,PassWord,ref isActive,ref PersonID,ref UserID))
                {
                    clsPeople person = clsPeople.FindPersonByID(PersonID);

                    return new clsUser(UserID, person, Username, PassWord, isActive);

                }
                return null;
            }
            catch (SqlException Sqlex)
            {
                //logger
                return null;
            }
            catch (Exception ex)
            {
                //log
                return null;
            }

        }

        public static DataTable GetAllUsers()
        {           
             return clsUserDAL.GetAllUsers();          
        }

        private async Task <bool> _AddNewUser()
        {
            this.UserID = await clsUserDAL.AddNewUserToDB(this.UserName, this.Password, this.IsActive, this.Person.PersonID);
            return this.UserID != -1;
        }

        public async Task <bool> Save()
        {
            switch (CurrentMode)
            {
                case enMode.AddNew:
                    return await _AddNewUser();

                case enMode.Update:
                    return await _Update();
                    

                default:
                    return false;                    

            }
        }

        public static clsUser FindUserByID(int UserId)
        {
            string Username = string.Empty;
            string PassWord = string.Empty;
            bool IsActive = false;
            int personID = -1;

            try
            {
                if (clsUserDAL.FindUserByID(UserId,ref Username,ref PassWord,ref IsActive,ref personID))
                {
                    clsPeople P = clsPeople.FindPersonByID(personID);
                    return new clsUser(UserId,P,Username,PassWord,IsActive);
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                //logger later
                return null;
            }

        }

        public static bool isThePersonIsAUser(int PersonID)
        {
            return clsUserDAL.isThePersonIsaUser(PersonID);
        }

        public static Task <bool> DeleteUser(int uerID)
        {
            return clsUserDAL.DeleteUserByID(uerID);
        }

        private async Task <bool> _Update()
        {
            return await clsUserDAL.UpdateUser(this.UserID,this.UserName,this.Password,this.IsActive);
        }

    }
}
