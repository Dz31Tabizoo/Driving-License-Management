using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestAppointments
    {
        public class TestAppsDTO
        {
            public int TestAppointId { get; set; }
            public int TestTtypeId { get; set; }
            public int LocalDLAppID{get; set;}
            public DateTime AppointDate { get; set; }
            public decimal  AppointFees { get; set; }
            public int UserIDApointTaker {  get; set; }
            public bool IsLocked { get; set; }

            //test
            public int TestID { get; set; }
            public bool TestResult { get; set; }
            public string Notes { get; set; }
            public int TesterUserID {  get; set; }

            //TestTypes
            public string TestTypeTitle { get; set; }
            public string TestDescrip { get; set; }
            public decimal TestTypeFee { get; set; }

            //User 
            public string AppointmentTakerUSerNAme { get; set; }
            public string TeserUSerName { get; set; }

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
                                        tt.TestTypeFees,

                                        u_app.UserName as AppointmentTaker_UserName,
                                        u_app.IsActive as AppointmentTaker_IsActive,
                                        u_test.UserName as Tester_UserName,
                                        u_test.IsActive as Tester_IsActive

                         FROM TestAppointments ta 
                         INNER JOIN Tests t on ta.TestAppointmentID = t.TestAppointmentID
                         INNER JOIN TestTypes tt on ta.TestTypeID = tt.TestTypeID
                         INNER JOIN Users u_app ON ta.CreatedByUserID = u_app.UserID
                         INNER JOIN Users u_test ON t.CreatedByUserID = u_test.UserID

                             ORDER BY ta.AppointmentDate Desc;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx))
                {
                    try
                    {

                        await cnx.OpenAsync();

                        using (SqlDataReader rdr = await cmd.ExecuteReaderAsync())
                        {
                            while (rdr.Read())
                            {
                                testApps.Add(new TestAppsDTO
                                {
                                    //Test Appointments
                                    TestAppointId = (int)rdr["TestAppointmentID"],
                                    TestTtypeId = (int)rdr["TestTypeID"],
                                    LocalDLAppID = (int)rdr["LocalDrivingLicenseApplicationID"],
                                    AppointDate = (DateTime)rdr["AppointmentDate"],
                                    AppointFees = (decimal)rdr["PaidFees"],
                                    UserIDApointTaker = (int)rdr["User_Appointment"],
                                    IsLocked = (bool)rdr["IsLocked"],
                                    // Tests
                                    TestID = (int)rdr["TestID"],
                                    TestResult = (bool)rdr["TestResult"],
                                    Notes = rdr["Notes"] != DBNull.Value ? rdr["Notes"].ToString() : string.Empty,
                                    TesterUserID = (int)rdr["User_Tester"],

                                    // Test Types
                                    TestTypeTitle = rdr["TestTypeTitle"].ToString(),
                                    TestDescrip = rdr["TestTypeDescription"].ToString(),
                                    TestTypeFee = (decimal)rdr["TestTypeFees"],

                                    // Users
                                    AppointmentTakerUSerNAme = rdr["AppointmentTaker_UserName"].ToString(),
                                    TeserUSerName = rdr["Tester_UserName"].ToString()
                                });

                            }
                            return testApps;
                        }
                    }
                    catch { return null; }

                }
            }




        }














    }
}
