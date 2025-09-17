using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class clsPeopleDAL
    {
        /*// In your Common/Shared project
 public class OperationResult<T>
 {
     public bool IsSuccess { get; set; }
     public T Data { get; set; }
     public string ErrorMessage { get; set; }
     public Exception Exception { get; set; }

     public static OperationResult<T> Success(T data) => new OperationResult<T> 
     { 
         IsSuccess = true, 
         Data = data 
     };

     public static OperationResult<T> Failure(string error, Exception ex = null) => new OperationResult<T> 
     { 
         IsSuccess = false, 
         ErrorMessage = error,
         Exception = ex
     };
 }
        ----------------------------------------
        Data Access Layer Implementation
csharp
public static OperationResult<bool> IsNationalNoExist(int nationalNo)
{
    const string query = @"
        SELECT CAST(
            CASE WHEN EXISTS (
                SELECT 1 FROM People WHERE NationalNo = @NationalNo
            ) THEN 1 ELSE 0 
        END AS BIT);";

    try
    {
        using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
        using (var command = new SqlCommand(query, connection))
        {
            command.Parameters.Add("@NationalNo", SqlDbType.Int).Value = nationalNo;
            
            connection.Open();
            var result = (bool)command.ExecuteScalar();
            
            return OperationResult<bool>.Success(result);
        }
    }
    catch (SqlException ex)
    {
        // Log the technical details (for developers)
        Logger.LogError(ex, "Database error checking NationalNo");
        
        // Return user-friendly message
        return OperationResult<bool>.Failure(
            "Unable to verify national number. Please try again later.", 
            ex
        );
    }
    catch (Exception ex)
    {
        Logger.LogError(ex, "Unexpected error in IsNationalNoExist");
        return OperationResult<bool>.Failure(
            "An unexpected error occurred. Please contact support.", 
            ex
        );
    }
}
         -----------------------------------------------
         Business Layer Implementation
csharp
public class PeopleBusinessLogic
{
    public OperationResult<bool> CheckNationalNoExists(int nationalNo)
    {
        // Business validation first
        if (nationalNo <= 0)
            return OperationResult<bool>.Failure("National number must be positive.");
        
        // Call DAL
        var dalResult = DataAccessLayer.IsNationalNoExist(nationalNo);
        
        if (!dalResult.IsSuccess)
        {
            // You can transform DAL errors here if needed
            return OperationResult<bool>.Failure(
                $"Validation error: {dalResult.ErrorMessage}",
                dalResult.Exception
            );
        }
        
        return OperationResult<bool>.Success(dalResult.Data);
    }
}
         --------------------------------------------
         Presentation Layer (WinForms) Implementation
csharp
// In your form code
private void btnCheckNationalNo_Click(object sender, EventArgs e)
{
    try
    {
        if (int.TryParse(txtNationalNo.Text, out int nationalNo))
        {
            var businessLogic = new PeopleBusinessLogic();
            var result = businessLogic.CheckNationalNoExists(nationalNo);
            
            if (result.IsSuccess)
            {
                if (result.Data)
                    MessageBox.Show("National number already exists!", "Validation", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("National number is available.", "Validation", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show user-friendly error message
                MessageBox.Show(result.ErrorMessage, "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Log technical details for debugging
                Logger.LogError(result.Exception, "Error in national number check");
            }
        }
        else
        {
            MessageBox.Show("Please enter a valid national number.", "Input Error", 
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    catch (Exception ex)
    {
        // Catch any unexpected errors in the UI layer
        MessageBox.Show("An unexpected error occurred. Please contact support.", "Error", 
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        Logger.LogError(ex, "Unexpected error in btnCheckNationalNo_Click");
    }
}       
         
         */



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

        public static string GetCounryNameByID(int ID)
        {
            string Query = "SELECT CountryName from Countries WHERE CountryID = @id;";

            using (SqlConnection cnx = new SqlConnection(clsDataAccessSettings.ConnectionAddress))
            using (SqlCommand cmd = new SqlCommand(Query, cnx))
            {

                cmd.Parameters.AddWithValue("@id", ID);
                try
                {
                    cnx.Open();
                    object Result = cmd.ExecuteScalar();
                    if (Result != null)
                    {
                        return Result.ToString();
                    }
                    else
                    {
                        return null;
                    }


                }
                catch
                {
                    return null;
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
