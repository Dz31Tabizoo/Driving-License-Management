using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
                using (SqlCommand cmd = new SqlCommand(query,cnx))
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




    }
}
