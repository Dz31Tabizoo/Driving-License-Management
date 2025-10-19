using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestTypeDAL
    {
        public static async Task<DataTable> GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM TestTypes ORDER BY TestTypeID ASC;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
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


        public static bool UpdateTestType(int ID, string Title, string Description, decimal Fee)
        {
            string query = @"UPDATE TestTypes 
                                        SET TestTypeFees = @newfee,
                                            TestTypeTitle = @title,
                                            TestTypeDescription = @Descrp
                                        WHERE TestTypeID = @id;";
            int RowAffected = 0;

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@newfee", Fee);
                    cmd.Parameters.AddWithValue("@title", Title);
                    cmd.Parameters.AddWithValue("@Descrp", Description);
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


        public static bool GetTestTypeByID(int iD, ref string testTitle, ref string testDescription, ref decimal testTypeFee)
        {
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @id;";


            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {

                    cmd.Parameters.AddWithValue("@id", iD);

                    try
                    {
                        cnx.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                testTitle = reader["TestTypeTitle"].ToString();
                                testDescription = reader["TestTypeDescription"].ToString();
                                testTypeFee = (decimal)reader["TestTypeFees"];
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    catch { return false; }
                }
            }


        }

    }

}
