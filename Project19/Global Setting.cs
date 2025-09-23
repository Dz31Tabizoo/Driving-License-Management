using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

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


        public static bool RememberUserNameAndPassWord(string username, string password)
        {
            try
            {
                //get the current project directory folder
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                string filePath = currentDirectory + "\\data.txt";

                if (username=="" && File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }

                string dataToSave = username + "#//#" + password;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(dataToSave);
                    return true;
                }

            }
            catch(Exception ex)
            {
                _ = MessageBox.Show($"Error Saving Credential Record: {ex.Message}", "Error");
                return false;
            }



            
        }

        public static bool GetStoredCredential(ref string Username,ref string Password)
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();

                string filePath = currentDirectory + "\\data.txt";

                if (!File.Exists(filePath))
                {
                    return false;
                }
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                        Username = result[0];
                        Password = result[1];
                    }

                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred getting record: {ex.Message}");
                return false;
            }

        }


    }
}
