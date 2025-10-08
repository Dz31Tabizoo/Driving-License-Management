using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTests
    {
        public enum enMode {AddNEw = 1 , Update=2 }
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int UserID { get; set; }

        public enMode Mode {  get; set; }= enMode.AddNEw;

        public clsTests()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = string.Empty;
            UserID = -1;
        }


        public clsTests(int testID, int testAppointmentID, bool testResult, string notes, int userID)
        {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            UserID = userID;
            Mode = enMode.Update;
        }
    }
}
