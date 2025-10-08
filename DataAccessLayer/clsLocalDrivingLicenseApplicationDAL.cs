using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationDAL
    {
        public class LocalDrivingLicenseAppDTO
        {

            // LocalDrivingLicenseApplications table
            public int localDrivingLicenseApplicationID { get; set; }
            public int applicationID { get; set; }
            public int licenseClassID { get; set; }

            // Applications table columns
            public int appId { get; set; }
            public int applicantId { get; set; }
            public DateTime appDate { get; set; }
            public int appTypeId { get; set; }
            public byte appStatus { get; set; }
            public DateTime lastStatusDate { get; set; }
            public decimal paidFees { get; set; }
            public int userID { get; set; }

            // LicenseClasses table columns
            public string className { get; set; }
            public string classDescription { get; set; }
            public byte minimumAllowedAge { get; set; }
            public byte defaultValidityLength { get; set; }
            public decimal classFees { get; set; }

            // Person data
            public string NationalNo { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }

            // User data
            public string Username { get; set; }
            public bool IsActive { get; set; }

            public LocalDrivingLicenseAppDTO() { }
        }
    
        public static async Task<List<LocalDrivingLicenseAppDTO>> GetAllLocalDrivingLicenseApps()
        {
            List<LocalDrivingLicenseAppDTO> LDLA_List = new List<LocalDrivingLicenseAppDTO>();

            string query =  @"SELECT 
                    l.LocalDrivingLicenseApplicationID, 
                    l.ApplicationID, 
                    l.LicenseClassID,

                    a.ApplicationID as AppId,
                    a.ApplicantPersonID,
                    a.ApplicationDate,
                    a.ApplicationTypeID,
                    a.ApplicationStatus,
                    a.LastStatusDate,
                    a.PaidFees,
                    a.CreatedByUserID,

                    lc.LicenseClassID,
                    lc.ClassName,
                    lc.ClassDescription,
                    lc.MinimumAllowedAge,
                    lc.DefaultValidityLength,
                    lc.ClassFees,
                    
                    p.FirstName,
                    p.SecondName,
                    p.ThirdName,
                    p.LastName,
                    p.NationalNo,
                    p.Email,
                    p.Phone,
                      
                    u.Username,
                    u.IsActive

                 FROM LocalDrivingLicenseApplications l 
                 INNER JOIN Applications a ON l.ApplicationID = a.ApplicationID 
                 INNER JOIN LicenseClasses lc ON l.LicenseClassID = lc.LicenseClassID
                 INNER JOIN People p ON a.ApplicantPersonID = p.PersonID
                 INNER JOIN Users u ON a.CreatedByUserID = u.UserID;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx))
                {

                    await cnx.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            LDLA_List.Add(new LocalDrivingLicenseAppDTO
                            {
                                // LocalDrivingLicenseApplications
                                localDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"],
                                applicationID = (int)reader["ApplicationID"],
                                licenseClassID = (int)reader["LicenseClassID"],

                                // Applications
                                appId = (int)reader["AppId"],
                                applicantId = (int)reader["ApplicantPersonID"],
                                appDate = (DateTime)reader["ApplicationDate"],
                                appTypeId = (int)reader["ApplicationTypeID"],
                                appStatus = (byte)reader["ApplicationStatus"],
                                lastStatusDate = (DateTime)reader["LastStatusDate"],
                                paidFees = (decimal)reader["PaidFees"],
                                userID = (int)reader["CreatedByUserID"],

                                // LicenseClasses
                                className = reader["ClassName"].ToString(),
                                classDescription = reader["ClassDescription"].ToString(),
                                minimumAllowedAge = (byte)reader["MinimumAllowedAge"],
                                defaultValidityLength = (byte)reader["DefaultValidityLength"],
                                classFees = (decimal)reader["ClassFees"],

                                // Person
                                NationalNo = reader["NationalNo"].ToString(),
                                FirstName = reader["FirstName"].ToString(),
                                SecondName = reader["SecondName"].ToString(),
                                ThirdName = reader["ThirdName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),

                                // User
                                Username = reader["Username"].ToString(),
                                IsActive = (bool)reader["IsActive"]


                            });
                        }

                        return LDLA_List;
                    }
                }
            }
        }




    }
}
