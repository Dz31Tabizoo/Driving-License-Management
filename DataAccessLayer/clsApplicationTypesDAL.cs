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


        public static bool UpdateAppType(int ID,string Title,decimal Fee)
        {
            string query = @"UPDATE ApplicationTypes 
                                        SET ApplicationFees = @newfee,
                                            ApplicationTypeTitle = @title
                                        WHERE ApplicationTypeID = @id;";
            int RowAffected = 0;

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx) )
                {
                    cmd.Parameters.AddWithValue("@newfee", Fee);
                    cmd.Parameters.AddWithValue("@title", Title);
                    cmd.Parameters.AddWithValue("@id", ID);
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


        public static bool FindApplicationTypeByID(int AppTypeID,ref string ApplicationTypeTitle , ref decimal ApplicationFees)
        {
            bool isFouned = false;
            string Query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @appTypeId;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@appTypeId", AppTypeID);
                    try
                    {
                        cnx.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFouned = true;

                                ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();
                                ApplicationFees = reader["ApplicationFees"] as decimal? ?? int.MinValue;

                                return isFouned;
                            }

                        }
                    }
                    catch { return false; }
                }
            }

            return false;

        }

    }
}
