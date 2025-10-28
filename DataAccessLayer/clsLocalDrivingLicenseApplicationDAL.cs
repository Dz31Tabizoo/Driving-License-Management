using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationDAL
    {


        public static async Task<DataTable> GetAllLocalDrivingLicenseApps()
        {
            DataTable LDLA_dt = new DataTable();

            string query = @"SELECT        l.LocalDrivingLicenseApplicationID,
                                           lc.ClassName,
                                           
                                           p.NationalNo,
                                           p.FirstName + ' ' + p.SecondName + ' ' 
                                                             + ISNULL(p.ThirdName, '') 
                                                             + ' ' + p.LastName AS FullName,
                                           a.ApplicationDate,
                             (SELECT        COUNT(ta.TestTypeID) AS PassedTestCount
                               FROM            Tests t INNER JOIN
                                                         TestAppointments ta ON t.TestAppointmentID = ta.TestAppointmentID
                               WHERE        (ta.LocalDrivingLicenseApplicationID = l.LocalDrivingLicenseApplicationID) AND (t.TestResult = 1)) AS PassedTestCount, 
                         CASE WHEN a.ApplicationStatus = 1 THEN 'New' WHEN a.ApplicationStatus = 2 THEN 'Cancelled' WHEN a.ApplicationStatus = 3 THEN 'Completed' END AS Status
FROM                     LocalDrivingLicenseApplications l INNER JOIN
                         Applications a ON l.ApplicationID = a.ApplicationID INNER JOIN
                         LicenseClasses lc ON l.LicenseClassID = lc.LicenseClassID INNER JOIN
                         People p ON a.ApplicantPersonID = p.PersonID;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {

                    await cnx.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        LDLA_dt.Load(reader);

                        return LDLA_dt;
                    }
                }
            }
        }


        public static async Task<int> AddNewLocalApplication(int applicationID, int licenseClassID)
        {
            string Query = @"Insert into LocalDrivingLicenseApplications 
                               (ApplicationID , LicenseClassID)
                        VALUES (@appID,@licenseApp);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@appID", applicationID);
                    cmd.Parameters.AddWithValue("@licenseApp", licenseClassID);


                    try
                    {
                        await cnx.OpenAsync();
                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int newLDVLapp))
                        {
                            return newLDVLapp;
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


        public static bool FindLDVlApplicationByID(int ID, ref int appID, ref int licenClassID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                string Query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ldvlID";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@ldvlID", ID);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            appID = (int)reader["ApplicationID"];
                            licenClassID = (int)reader["LicenseClassID"];

                            return isFound;
                        }
                        else
                        {
                            return isFound;
                        }

                    }
                }
            }
        }

        public static async Task<bool> DeleteLdvlApplication(int ID)
        {
            string Query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingApplicationID = @LappID;";
            int RowAffected = 0;

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@LappID", ID);
                    try
                    {
                        await cnx.OpenAsync();

                        RowAffected = await cmd.ExecuteNonQueryAsync();
                        return (!(RowAffected == 0));
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}
