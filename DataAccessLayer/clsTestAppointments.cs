using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestAppointments
    {
        public class TestAppsDTO
        {
            






            public TestAppsDTO() { }
        }




        public static async Task<List<TestAppsDTO>> GetTestApps()
        {
            List<TestAppsDTO> testApps = new List<TestAppsDTO>();
            string query = @"SELECT     ta.TestAppointmentID,
                                        ta.TestTypeID,
                                        ta.LocalDrivingLicenseApplicationID,
                                        ta.AppointmentDate,
                                        ta.PaidFees,
                                        ta.CreatedByUserID as User_Appointment,
                                        ta.IsLocked as Passed,

                                        t.TestID,
                                        t.TestResult,
                                        t.Notes,
                                        t.CreatedByUserID as User_Tester,

                                        tt.TestTypeTitle,
                                        tt.TestTypeDescription,
                                        tt.TestTypeFees

                         FROM TestAppointments ta 
                         INNER JOIN Tests t on ta.TestAppointmentID = t.TestAppointmentID
                         INNER JOIN TestTypes tt on ta.TestTypeID = tt.TestTypeID; 
                             ORDER BY ta.AppointmentDate Desc";




        }














    }
}
