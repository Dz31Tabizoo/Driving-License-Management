using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class clsDriversDAL
    {

        public static async Task<DataTable> GetAllDrivers()
        {
            string Query = "Select * From Drivers ORDER BY CreatedDate DESC;";
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            using (SqlCommand cmd = new SqlCommand(Query, cnx))
            {
                await cnx.OpenAsync();

                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        public static async Task<int> AddNewDriver(int personId, int userId, DateTime createdDate)
        {


            string Query = "Insert into Drivers (PersonID , CreatedByUserID , CreatedDate) " +
                "VALUES (@personID,@userID,@createdDATE);" +
                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@personID", personId);
                    cmd.Parameters.AddWithValue("@userID", userId);
                    cmd.Parameters.AddWithValue("@createdDATE", createdDate);


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



    }
}
