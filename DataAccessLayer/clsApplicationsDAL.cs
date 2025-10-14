using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class clsApplicationsDAL
    {
        public class AppDTO
        {
            public int appId { get; set; }
            public int applicantId { get; set; }
            public DateTime appDate { get; set; }
            public int appTypeId { get; set; }
            public byte appStatus { get; set; }
            public DateTime lastStatusDate { get; set; }
            public decimal paidFees { get; set; }
            public int userID { get; set; }
        }

        public static async Task<List<AppDTO>> GetAllApplications()
        {
            List<AppDTO> appDTOList = new List<AppDTO>();
            string query = "SELECT * FROM Applications ORDER BY LastStatusDate DESC;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    await cnx.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            appDTOList.Add(new AppDTO
                            {
                                appId = (int)reader["ApplicationID"],
                                applicantId = (int)reader["ApplicantPersonID"],
                                appDate = (DateTime)reader["ApplicationDate"],
                                appTypeId = (int)reader["ApplicationTypeID"],
                                appStatus = (byte)reader["ApplicationStatus"],
                                lastStatusDate = (DateTime)reader["LastStatusDate"],
                                paidFees = (decimal)reader["PaidFees"],
                                userID = (int)reader["CreatedByUserID"]
                            });
                        }
                        return appDTOList;
                    }

                }
            }
        }


        public static async Task<bool> isApplicationExisteAsync(int ID)
        {
            string query = "SELECT 1 as Found FROM Applications WHERE ApplicationID = @id;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    await cnx.OpenAsync();

                    object result = await cmd.ExecuteScalarAsync();

                    return (result != null);
                }
            }
        }


        public static async Task<bool> UpdateApplicationStatusAsync(int applicationID, byte applicationStatus, DateTime lastStatusDate)
        {
            string query = @"UPDATE Application
                                                SET ApplicationStatus = @appstat , LastStatusDate = @lastStDate
                                       WHERE ApplicationID = @appId ;";
            int rowAffected = -1;

            using (SqlConnection conx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, conx))
                {
                    cmd.Parameters.AddWithValue("@appstat", applicationStatus);
                    cmd.Parameters.AddWithValue("@lastStDate", lastStatusDate);
                    cmd.Parameters.AddWithValue("@appId", applicationID);

                    await conx.OpenAsync();

                    rowAffected = await cmd.ExecuteNonQueryAsync();
                    return rowAffected > 0;
                }
            }

        }


        public static async Task<int> AddNewApplication( int PersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationSatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees , CreatedByUserID)
                                VALUES (@personId,@appDate,@AppTypeId,@appStat,@lastStatDate, @paidFees,@userID);
                                SELECT CAST (SCOPE_IDENTITY() AS INT );";



            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@personId", PersonID);
                    cmd.Parameters.AddWithValue("@appDate", ApplicationDate);
                    cmd.Parameters.AddWithValue("@appTypeId", ApplicationTypeID);
                    cmd.Parameters.AddWithValue("@lastStatDate", LastStatusDate);
                    cmd.Parameters.AddWithValue("@appStat", ApplicationSatus);
                    cmd.Parameters.AddWithValue("@paidFees", PaidFees);
                    cmd.Parameters.AddWithValue("@userID", CreatedByUserID);

                    try
                    {
                        await cnx.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int newAppID))
                        {
                            return newAppID;
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


        public static async Task<AppDTO> FindApplicationByIDasync(int ApplicationID)
        {
            AppDTO obj = new AppDTO();
            string query = "SELECT * FROM Applications WHERE ApplicationID = @applicationId;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@applicationId", ApplicationID);

                    await cnx.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {


                            obj.appId = (int)reader["ApplicationID"];
                            obj.applicantId = (int)reader["ApplicantPersonID"];
                            obj.appDate = (DateTime)reader["ApplicationDate"];
                            obj.appTypeId = (int)reader["ApplicationTypeID"];
                            obj.appStatus = (byte)reader["ApplicationStatus"];
                            obj.lastStatusDate = (DateTime)reader["LastStatusDate"];
                            obj.paidFees = (decimal)reader["PaidFees"];
                            obj.userID = (int)reader["CreatedByUserID"];
                           
                        }
                        return obj;
                    }

                }
            }
        }


    }
}