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

    public class clsTestTypes
    {
        public enum enTestType {VisionTest = 1 , WrittenTest = 2, StreetTest = 3 };
        public clsTestTypes.enTestType TestID { get; set; }
        public string TestTitle { get; set; }
        public string TestDescription { get; set; }
        public decimal TestFee { get; set; }

        public clsTestTypes(enTestType id, string title, string description, decimal fee)
        {
            this.TestID = id;
            this.TestTitle = title;
            this.TestDescription = description;
            this.TestFee = fee;
        }


        public static async Task<DataTable> GetData()
        {
            return await clsTestTypeDAL.GetAllTestTypes();
        }

        public bool UpdateTest()
        {
            return clsTestTypeDAL.UpdateTestType((int)this.TestID, this.TestTitle, this.TestDescription, this.TestFee);
        }

        public static clsTestTypes GetTestTypeByID (int ID )
        {
            string testTypeTitle = string.Empty;
            string testTypeDescription = string.Empty;

            decimal testTypeFees = -1;

            bool isFound = clsTestTypeDAL.GetTestTypeByID(ID, ref testTypeTitle, ref testTypeDescription,ref testTypeFees);

            return new clsTestTypes((enTestType)ID,testTypeTitle,testTypeDescription,testTypeFees);
        }

    }
}
