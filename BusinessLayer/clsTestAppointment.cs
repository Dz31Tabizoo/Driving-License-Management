using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestAppointment
    {

        public enum enMode {AddNew=1, Update=2 }

        public enMode Mode { get; set; } = enMode.AddNew;

        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
       
        public int LDLA_ID {get;set;}
        public DateTime TestAppointmentDate { get; set; }
        public decimal PaidFees  { get; set; }
        public int CreatedUSerID { get; set; }
        public bool IsLocked { get; set; }
        
        
        
        
        
        
        public clsTestTypes Types { get; set; }
        public clsLocalDrivingLicenseApplication LDLA { get; set; }
        public clsUser TheUser { get; set; }

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LDLA_ID = -1;
            TestAppointmentDate = DateTime.Now;
            PaidFees = 0;
            IsLocked = false;

        }

        public clsTestAppointment(int testAppointmentID, int testTypeID, int lDLA_ID, DateTime testAppointmentDate, decimal paidFees, int createdUSerID, bool isLocked, clsTestTypes types, clsLocalDrivingLicenseApplication lDLA, clsUser theUser)
        {
            Mode = enMode.Update;
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LDLA_ID = lDLA_ID;
            TestAppointmentDate = testAppointmentDate;
            PaidFees = paidFees;            
            IsLocked = isLocked;
            Types = types;
            LDLA = lDLA;
            TheUser = theUser;
        }
    }
}
