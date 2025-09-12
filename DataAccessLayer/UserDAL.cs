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

        public static bool isUsernameExist(string UserName)
        {
            bool result = false;
            string Query = "SELECT 1 as found FROM Users WHERE UserName = @username;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("username", UserName);
                    try
                    {
                        cnx.Open();

                        result = (bool)cmd.ExecuteScalar();

                        return result;
                          
                        
                    }
                    catch { return false; }
                }
            }

            
        }

        public static bool isThePersonIsaUser(int PersonID)
        {
            bool found = false;
            string Query = "SELECT 1 as found FROM Users WHERE PersonID = @pID;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cmd.Parameters.AddWithValue("@pID", PersonID);
                    try
                    {
                        cnx.Open();

                        found = (bool)cmd.ExecuteScalar();

                        return found;


                    }
                    catch { return false; }
                }
            }


        }


        public static bool FindUserByID(int UserID,ref string username,ref string password,ref bool isactive,ref int personid)
        {
            string query = "Select * From Users WHERE UserID = @USID;";
            bool isfound = false;

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(query,cnx))
                {
                    cnx.Open();

                    try
                    {
                        cmd.Parameters.AddWithValue("@USID",UserID);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                isfound = true;

                                username = rdr["UserName"] as string ?? string.Empty;
                                password = rdr["Password"] as string ?? string.Empty;
                                isactive = Convert.ToBoolean( rdr["IsActive"]);
                                personid = rdr["PersonID"] as int? ?? int.MinValue;


                            }
                        }


                        return isfound;

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
