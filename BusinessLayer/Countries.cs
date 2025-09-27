using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        clsCountries()
        {
            CountryID = -1;
            CountryName = "International";
        }

        clsCountries(int id,string Name)
        {
            this.CountryID = id;
            this.CountryName = Name;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesDAL.GetCountries();
        }

        public static clsCountries Find(int Id)
        {
            string CountryName = string.Empty;
            if (clsCountriesDAL.Find(Id,ref CountryName))
            {
                return new clsCountries(Id,CountryName);
            }
            else
            {
                return null;
            }
        }

        public static clsCountries Find(string CountryName)
        {
            int id = -1;
            if (clsCountriesDAL.Find(ref id, CountryName))
            {
                return new clsCountries(id, CountryName);
            }
            else
            {
                return null;
            }
        }
    }
}
