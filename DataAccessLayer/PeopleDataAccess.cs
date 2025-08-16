using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPeopleDataAccess
    {
       
        public static bool  FindPersonByID(int Personid,ref string firstname,ref string secondname,ref string thirdname,ref string lastname,
            ref string nationalNo,ref DateTime dateofbirth,ref byte gender,ref string address,ref string phone,ref string email,
            ref int nationalcountryid,ref string imagepath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                string Query = "SELECT * FROM People WHERE PersonID = @PersID";
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@PersID", Personid);
                                     
                        connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            firstname = reader["FirstName"] as string ?? string.Empty;
                            secondname = reader["SecondName"] as string ?? string.Empty ;
                            thirdname = reader["ThirdName"] as string ?? string.Empty;
                            lastname = reader["LastName"] as string ?? string.Empty;
                            nationalNo = reader["NationalNo"] as string ?? string.Empty;
                            dateofbirth = reader["DateOfBirth"] as DateTime? ?? DateTime.MinValue;
                            gender = reader["Gender"] as byte? ?? byte.MinValue;
                            address = reader["Address"] as string ?? string.Empty;
                            phone = reader["Phone"] as string ?? string.Empty;
                            email = reader["Email"] as string ?? string.Empty;
                            nationalcountryid = reader["NationalityCountryID"] as int? ?? int.MinValue;
                            imagepath = reader["ImagePath"] as string ?? string.Empty;

                            return isFound;
                        }
                        else 
                        { 
                            return isFound = false; 
                        }
                    }                
                }
            }
            
        }


        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT * FROM People ORDER BY PersonID;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                cnx.Open();
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {                        
                            dt.Load(reader);                        
                    }
                }
            }
            return dt;
        }




    }
}
