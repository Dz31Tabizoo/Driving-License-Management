using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPeopleDAL
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
                            gender = reader["Gendor"] as byte? ?? 0;
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
            string Query = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName,
                             People.LastName, People.DateOfBirth,People.Gendor,
                                                        CASE WHEN People.Gendor = 0 THEN 'Male' 
                                                             ELSE 'Female'
                                                             END as 'Gender Caption',
                             People.Address,People.Phone,People.Email,
                             People.NationalityCountryID,Countries.CountryName,People.ImagePath
                             
                             FROM People INNER JOIN Countries
                               ON People.NationalityCountryID = Countries.CountryID
                                    ORDER BY People.FirstName";

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
                cmd.Parameters.AddWithValue("@secondname", secondname);
                cmd.Parameters.AddWithValue("@thirdname", thirdname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@nationalitycountryid", nationalcountryid);
                cmd.Parameters.AddWithValue("@imagepath", imagepath ?? (object)DBNull.Value);

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
                catch 
                {
                    return -1;
                }
            }            
        }

        

        

        public static bool isNationalNoExist(string nationalNumb)
        {
            bool Result = false;
            string Query = @"SELECT CAST ( CASE WHEN EXISTS 
                              (SELECT 1 FROM People WHERE NationalNo = @Nt) 
                                   THEN 1 ELSE 0 END AS BIT) AS Value_exists ;";
            
            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, cnx))
                {
                    cnx.Open();

                    cmd.Parameters.AddWithValue("@Nt", nationalNumb);
                    
                    Result = (bool)cmd.ExecuteScalar();

                }
            }
            
            return Result;
        }


        public static bool UpdatePerson(int PersonID ,string firstname, string secondname, string thirdname, string lastname,
             string nationalNo, DateTime dateofbirth, byte gender, string address, string phone, string email,
             int nationalcountryid, string imagepath)
        {

            int RowAffected = 0;

            string Query = @"UPDATE People SET
                              NationalNo = @Nt,
                              FirstName = @Fn,  
                              SecondName = @Sn,
                              ThirdName = @Thn,
                              LastName = @Ln,
                              DateOfBirth = @DtBth,
                              Gendor = @Gn,
                              Address = @Adr,
                              Phone = @Ph,
                              Email = @Em,
                              NationalityCountryID = @IdCtr,
                              ImagePath = @ImgPth 
                           WHERE PersonID = @Personid;";

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@Personid", PersonID);
                    cmd.Parameters.AddWithValue("@Nt", nationalNo);
                    cmd.Parameters.AddWithValue("@Fn", firstname);
                    cmd.Parameters.AddWithValue("@Sn", secondname);
                    cmd.Parameters.AddWithValue("@Thn", thirdname ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Ln", lastname);
                    cmd.Parameters.AddWithValue("@DtBth", dateofbirth);
                    cmd.Parameters.AddWithValue("@Gn", gender);
                    cmd.Parameters.AddWithValue("@Adr", address);
                    cmd.Parameters.AddWithValue("@Ph", phone);
                    cmd.Parameters.AddWithValue("@Em", email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdCtr", nationalcountryid);
                    cmd.Parameters.AddWithValue("@ImgPth", imagepath ?? (object)DBNull.Value);

                    try
                    {
                        con.Open();

                        RowAffected = cmd.ExecuteNonQuery();

                        return (! (RowAffected == 0));

                    }
                    catch 
                    {
                        return false;
                    }


                }
            }




        }


        public static bool DeletePerson (int ID)
        {
            string Query = "DELETE FROM People WHERE PersonID = @pID;";
            int RowAffected = 0;

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            {
                using (SqlCommand cmd = new SqlCommand(Query,cnx))
                {
                    cmd.Parameters.AddWithValue("@pID", ID);
                    try
                    {
                        cnx.Open();

                        RowAffected = cmd.ExecuteNonQuery() ;
                        return (! (RowAffected == 0));
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
