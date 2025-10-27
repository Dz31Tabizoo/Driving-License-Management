using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestsDAL
    {
        public static async Task <int> AddNewTest(int testAppointmentId,bool testResult,string Note,int CreatedByUserID)
        {
            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                       VALUES (@testAppID, @testResult, @notes, @userID );
                              SELECT SCOPE_IDENTITY();";

            

            using (var cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (var cmd = new SqlCommand(query,cnx))
                {
                    cmd.Parameters.AddWithValue("@testAppID",testAppointmentId);
                    cmd.Parameters.AddWithValue("@testResult",testResult);
                    cmd.Parameters.AddWithValue("@notes", Note ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@userID",CreatedByUserID);

                    try
                    {
                        await cnx.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int newTestID))
                        {
                            return newTestID;
                        }
                        else
                        {
                            return - 1;
                        }



                    }
                    catch 
                    { return -1; }
                }
            }


        }

    }
}
