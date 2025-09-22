using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project19
{
    public static class GlobalSetting
    {
        private static readonly AsyncLocal<clsUser> _currentUser = new AsyncLocal<clsUser>();

        public static clsUser CurrentUser
        {
            get => _currentUser.Value;
            set
            {
                _currentUser.Value = value; 
                OnUserChange? .Invoke(null,EventArgs.Empty);
            }

        }

        public static event EventHandler OnUserChange;
        
        public static bool LoginAuthontification(string username, string password)
        {
            var user = clsUser.FindUserByUserNameAndPassword(username, password);

            if (user != null)
            {
                CurrentUser = user;
                return true;
            }
            return false;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

    }
}
