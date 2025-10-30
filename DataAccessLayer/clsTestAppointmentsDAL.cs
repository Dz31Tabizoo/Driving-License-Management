using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestAppointmentsDAL
    {
        public class TestAppsDTO
        {
            public int TestAppointId { get; set; }
            public int TestTtypeId { get; set; }
            public int LocalDLAppID { get; set; }
            public DateTime AppointDate { get; set; }
            public decimal AppointFees { get; set; }
            public int UserIDApointTaker { get; set; }
            public bool IsLocked { get; set; }

            //test
            public int TestID { get; set; }
            public bool TestResult { get; set; }
            public string Notes { get; set; }
            public int TesterUserID { get; set; }

            //TestTypes
            public int TestTypeID { get; set; }
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

                                        tt.TestTypeID,  
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
                using (SqlCommand cmd = new SqlCommand(query, cnx))
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
                                    IsLocked = (bool)rdr["Passed"],
                                    // Tests
                                    TestID = (int)rdr["TestID"],
                                    TestResult = (bool)rdr["TestResult"],
                                    Notes = rdr["Notes"] != DBNull.Value ? rdr["Notes"].ToString() : string.Empty,
                                    TesterUserID = (int)rdr["User_Tester"],

                                    // Test Types
                                    TestTypeID = (int)rdr["TestTypeID"],
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

        public static async Task<DataTable> GetAppointmentByLocalDVL_IDAndTestTypeID(int LDVL_ID, int testType)
        {
            DataTable dt = new DataTable();
            string Query = @"SELECT TestAppointmentID , 
                                    AppointmentDate ,
                                    PaidFees,
                                    IsLocked                               
                               FROM TestAppointments 
                               WHERE LocalDrivingLicenseApplicationID = @ldvlID AND TestTypeID = @testTypeId";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                await cnx.OpenAsync();
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@ldvlID", LDVL_ID);
                    cmd.Parameters.AddWithValue("@testTypeId", testType);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public static async Task<int> AddNewTestAppointmentAsyncDAL(int TestTtypeId, int LocalDLAppID, DateTime AppointDate, decimal AppointFees, int UserIDApointTaker, bool IsLocked = false)
        {
            string Query = "Insert into TestAppointments (TestTypeID , LocalDrivingLicenseApplicationID , AppointmentDate , PaidFees, CreatedByUserID, IsLocked) " +
                "VALUES (@testTypeID,@LDVLappID,@AppDate,@appFees,@userID, @isLocked);" +
                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@testTypeID", TestTtypeId);
                    cmd.Parameters.AddWithValue("@LDVLappID", LocalDLAppID);
                    cmd.Parameters.AddWithValue("@AppDate", AppointDate);
                    cmd.Parameters.AddWithValue("@appFees", AppointFees);
                    cmd.Parameters.AddWithValue("@userID", UserIDApointTaker);
                    cmd.Parameters.AddWithValue("@isLocked", IsLocked);

                    try
                    {
                        await cnx.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int newUserID))
                        {
                            return newUserID;
                        }
                        else
                        {
                            return -1;
                        }

                    }
                    catch
                    {
                        return -1;

                    }
                }
            }
        }

        public static async Task<bool> UpdateTestAppointmentDateAsyncDAL(int testAppointmentID, DateTime newAppointmentDate)
        {
            string query = @"UPDATE TestAppointments SET AppointmentDate  = @testAppointmentDate WHERE TestAppointmentID = @testAppId;";
            int RowAffected = -1;

            using (var cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (var cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@testAppId", testAppointmentID);
                    cmd.Parameters.AddWithValue("@testAppointmentDate", newAppointmentDate);

                    try
                    {
                        await cnx.OpenAsync();
                        RowAffected = await cmd.ExecuteNonQueryAsync();

                        return RowAffected != -1;

                    }
                    catch { return false; }


                }
            }
        }

       
        public static async Task<bool> CheckIfApplicantHasAlreadyAnAppointment(int LocaldvAppID)
        {
            string query = "Select COUNT(*) FROM TestAppointments Where LocalDrivingLicenseApplicationID = @ldvlID AND IsLocked = 0 ";
            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            using (var command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ldvlID", LocaldvAppID);

                await connection.OpenAsync();

                // Returns true if any records exist
                var result = (int)await command.ExecuteScalarAsync();
                return result > 0;

            }
        }

        public static async Task<int> CountTestTrielsForEachTestTypeAndLdvlApp(int localDVApplicationID, int TestType)
        {
            string query = "SELECT Trail = COUNT(LocalDrivingLicenseApplicationID) FROM TestAppointments WHERE TestTypeID = @testTypeId AND LocalDrivingLicenseApplicationID = @LdvlAppiD;";
            int Trails = 0;
            using (var cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (var cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@testTypeId", TestType);
                    cmd.Parameters.AddWithValue("@LdvlAppiD", localDVApplicationID);
                    try
                    {
                        await cnx.OpenAsync();

                        Trails = (int)await cmd.ExecuteScalarAsync();

                        return Trails;
                    }
                    catch
                    {
                        return 0;
                    }

                }
            }





        }

        public static async Task<bool> IsApplicantHasDoneThisTypeOfTestOnLicenceClassAsync(int localDvAppID, int testType, int licenseClassID)
        {
            const string query = @"
        SELECT COUNT(*)
        FROM Tests 
        INNER JOIN TestAppointments 
            ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID 
        INNER JOIN LocalDrivingLicenseApplications 
            ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
        WHERE TestAppointments.LocalDrivingLicenseApplicationID = @ldrvAppID 
            AND Tests.TestResult = 1 
            AND LocalDrivingLicenseApplications.LicenseClassID = @licenseClassId
            AND TestAppointments.TestTypeID = @testTypeID";

            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ldrvAppID", SqlDbType.Int).Value = localDvAppID;
                    command.Parameters.Add("@testTypeID", SqlDbType.Int).Value = testType;
                    command.Parameters.Add("@licenseClassId", SqlDbType.Int).Value = licenseClassID;
                    await connection.OpenAsync();

                    var count = (int)await command.ExecuteScalarAsync();
                    return count > 0;
                }
            }

        }

        public static async Task<bool> IsPreviousTestsIsFailAsync(int localDrivingLicenseApplicationID,int testTypeId)
        {
            const string query = @"
        SELECT CAST(
            CASE WHEN EXISTS (
                SELECT 1 
                FROM TestAppointments 
                INNER JOIN Tests 
                    ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                WHERE LocalDrivingLicenseApplicationID = @localDrivingLicenseApplicationID 
                    AND TestTypeID = @testTypeID 
                    AND TestResult = 0
            ) THEN 1 ELSE 0 END 
        AS BIT)";

            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (var command = new SqlCommand(query, connection))
                {

                    command.Parameters.Add("@localDrivingLicenseApplicationID", SqlDbType.Int).Value = localDrivingLicenseApplicationID;
                    command.Parameters.Add("@testTypeID", SqlDbType.Int).Value = testTypeId;

                    await connection.OpenAsync();

                    return (bool)await command.ExecuteScalarAsync();
                }
            }
        }

        public static async Task<bool> LockedTestAppointmentAsyncDAL(int testAppointmentID, bool IsLocked= true)
        {
            string query = @"UPDATE TestAppointments SET IsLocked  = @isLocked WHERE TestAppointmentID = @testAppId;";
            int RowAffected = -1;

            using (var cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (var cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@testAppId", testAppointmentID);
                    cmd.Parameters.AddWithValue("@isLocked", IsLocked);

                    try
                    {
                        await cnx.OpenAsync();
                        RowAffected = await cmd.ExecuteNonQueryAsync();

                        return RowAffected != -1;

                    }
                    catch { return false; }


                }
            }
        }

    }
}
