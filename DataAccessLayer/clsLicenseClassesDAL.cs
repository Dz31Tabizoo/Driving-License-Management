using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLicenseClassesDAL  
    {
        public class LicenseClassDTO
        {
            public int LicenseClassID { get; set; }
            public string ClassName { get; set; }
            public string ClassDescription { get; set; }
            public byte MinimumAge { get; set; }
            public byte DefaultValidityLength { get; set; }
            public decimal ClassFees { get; set; }
        }

        public static async Task<List<LicenseClassDTO>> GetClassesList()
        {
            List<LicenseClassDTO> classesList = new List<LicenseClassDTO>();
            string query = "SELECT * FROM LicenseClasses ORDER BY LicenseClassID ASC;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx))
                {
                    await cnx.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            classesList.Add(new LicenseClassDTO
                            {
                                LicenseClassID = (int)reader["LicenseClassID"],
                                ClassName = (string)reader["ClassName"],
                                ClassDescription = (string)reader["ClassDescription"],
                                MinimumAge = (byte)reader["MinimumAllowedAge"],
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"],
                                ClassFees = (decimal)reader["ClassFees"]
                            });                            
                        }
                        return classesList;
                    }

                }  
            }
        }

    }
}
