using System;
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
            public int appId { get;set; }
            public int applicantId { get;set; }
            public DateTime appDate { get;set; }
            public int appTypeId { get;set; }
            public byte appStatus { get;set; }
            public DateTime lastStatusDate { get; set;}
            public decimal paidFees { get; set; }
            public int userID { get; set; }          
        }




        public static async Task<List<AppDTO>> GetAllApplications()
        {
            List<AppDTO> appDTOList = new List<AppDTO>();
            string query = "SELECT * FROM Applications ORDER BY LastStatusDate DESC;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx))
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






    }
}
