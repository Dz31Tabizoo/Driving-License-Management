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


        public static int AddNewPerson(string firstname,  string secondname,  string thirdname,  string lastname,
             string nationalNo,  DateTime dateofbirth,  byte gender,  string address,  string phone,  string email,
             int nationalcountryid,  string imagepath)
        {


            string query = "INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)" +
                "VALUES (@nationalNo,@firstname,@secondname,@thirdname,@lastname,@dateofbirth,@gender,@address,@phone,@email,@nationalitycountryid,@imagepath);" +
                "SELECT SCOPE_IDENTITY();";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            using (SqlCommand cmd = new SqlCommand(query, cnx))
            {
                cmd.Parameters.AddWithValue("@nationalNo", nationalNo);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@secondtname", secondname);
                cmd.Parameters.AddWithValue("@thirdname", thirdname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nationalitycountryid", nationalcountryid);
                cmd.Parameters.AddWithValue("@imagepath", imagepath);

                try
                {
                    cnx.Open();

                    object Result = cmd.ExecuteScalar();
                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    {
                        return InsertedID;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    return -1;
                }
            }            
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

        public static bool isNationalNoExist(int nationalNumb)
        {
            string Query = "SELECT 1 FROM People WHERE NationalNo = @Nt;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cnx.Open();

                    cmd.Parameters.AddWithValue("@Nt", nationalNumb);

                }
            }
        }
    }
}
