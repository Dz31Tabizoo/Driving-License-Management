using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsApplicationTypesDAL
    {
        public static async Task<DataTable> GetApplicationTypes()
        {
            DataTable dt = new DataTable();
            
            string query = "SELECT * FROM ApplicationTypes ORDER BY ApplicationTypeID ASC;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx))
                {
                    try
                    {
                        await cnx.OpenAsync();

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dt.Load(reader);
                        }
                        return dt;
                    }
                    catch 
                    {  
                        //log
                        return null;
                    }
                }
            }



        }


        public static bool UpdateAppType(int ID,short Fee)
        {
            string query = @"UPDATE ApplicationTypes 
                                        SET ApplicationFees = @newfee 
                                        WHERE ApplicationTypeID = @id;";
            int RowAffected = 0;

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx) )
                {
                    cmd.Parameters.AddWithValue("@newfee", Fee);
                    try
                    {
                        cnx.Open();
                        RowAffected = cmd.ExecuteNonQuery();
                        return (RowAffected != 0);
                    }
                    catch { return false; }
                   

                }
            }


            
        }




    }
}
