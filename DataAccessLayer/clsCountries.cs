using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCountries
    {

        public string CountryName { get; set; }
        public int CountryID { get; set; }




        public clsCountries Find(int CountryID)
        {
            return new clsCountries();
        }


    }
}
