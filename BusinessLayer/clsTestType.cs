using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    internal class clsTestTypes
    {
        int TestID { get; set; }
        string TestTitle { get; set; }
        string TestDescription { get; set; }
        decimal TestFee { get; set; }

        public clsTestTypes(int id, string title, string description, decimal fee)
        {
            this.TestID = id;
            this.TestTitle = title;
            this.TestDescription = description;
            this.TestFee = fee;
        }

    }
}
