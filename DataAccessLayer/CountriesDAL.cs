using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCountriesDAL
    {

        public static bool Find(int countryId,ref string Country_Name)
        {
            string query = "SELECT * FROM Countries WHERE CountryID = @countryId;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@countryId", countryId);
                    try
                    {
                        cnx.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Country_Name = reader["CountryName"].ToString() ?? string.Empty;
                                return true;
                            }
                        }
                    }
                    catch 
                    {
                        return false;
                    }


                }
            }

            return false;
        }

        public static bool Find(ref int countryId, string countyName)
        {
            string query = "SELECT * FROM Countries WHERE CountryName = @countryname;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@countryname", countyName);
                    try
                    {
                        cnx.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                 int.TryParse(reader["CountryID"]?.ToString(), out countryId);
                                return true;
                            }

                        }


                    }
                    catch 
                    {
                        return false;
                    }


                }
            }

            return false;
        }

        public static DataTable GetCountries()
        {
            string Query = "Select * From Countries ORDER BY CountryName;";
            DataTable dt = new DataTable();

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            using (SqlCommand cmd = new SqlCommand(Query, cnx))
            {
                cnx.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }


    }
}
