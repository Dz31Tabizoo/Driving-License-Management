using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    internal class clsUser
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








    }
}
