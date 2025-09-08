using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUserDAL
    {
        public static bool FindUserByName(string UserName, ref string PassWord, ref bool isActive,ref int PersonID,ref int UserID)
        {
            bool isFouned = false;
            string Query = "SELECT * FROM Users WHERE UserName = @username;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("username", UserName);
                    try
                    {
                        cnx.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFouned = true;

                                UserID = reader["UserID"] as int? ?? int.MinValue;
                                PersonID = reader["PersonID"] as int? ?? int.MinValue;
                                PassWord = reader["Password"] as string;
                                isActive = reader["IsActive"] as bool? ?? false;

                                return isFouned;
                            }

                        }
                    }
                    catch { return false; }
                }
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            string Query = @"SELECT u.UserID,u.PersonID,
                                     CONCAT_WS(' ',p.FirstName,p.SecondName,p.ThirdName,p.LastName) AS FullName,
                                     u.UserName, u.Password , u.isActive 
                                     FROM Users AS u 
                                     INNER JOIN People AS p ON u.PersonID = p.PersonID ";
            DataTable dtUsers = new DataTable();

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cnx.Open();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dtUsers.Load(rdr);
                    }
                }
            }
            return dtUsers;
        }

        public static int AddNewUserToDB(string username , string password, bool isactive,int personid)
        {
            string Query = "Insert into Users (UserName , Password , IsActive , PersonID) VALUES (@username,@password,@isactive,@personid);" +
                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@isactive", isactive);
                    cmd.Parameters.AddWithValue("@personid", personid);

                    try
                    {
                        cnx.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int newUserID))
                        {
                            return newUserID;
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
    }
}
