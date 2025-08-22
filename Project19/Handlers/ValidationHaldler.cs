using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Project19.Handlers
{

    internal class ValidationHaldler
    {
        public static bool NameValidation(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            if (name.Contains("  "))
            {
                return false;
            }

            name = name.Trim();

            if (name.Length < 2 || name.Length > 50)
            {
                return false;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-' && c != '\'' && c != '.')
                {
                    return false;
                }
            }

           



            return true;
        }

        //public static bool EmailValidation(string email)
        //{
        //    private static readonly string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
         
        //    Regex.is
             

            
        //}

        public static bool PhoneValidation(string Phone)
        {
            if (string.IsNullOrEmpty(Phone))
                { return false; }

            foreach (char c in Phone) 
            {
                if(!char.IsDigit(c) && c != '+')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool NationalNumbValidation(string NtioNumb)
        {
            if (string.IsNullOrEmpty(NtioNumb))
            {
                return false;
            }

            if (NtioNumb.Contains(" "))
            {
                return false;
            }

            if (!char.IsLetter(NtioNumb[0]))
            {
                return false;
            }
            return true;

        }
    }
}
