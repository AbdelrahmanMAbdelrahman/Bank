using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankData
{
    public  class ClsPersonData
    {
        public static DataTable GetAllPeople()
        {
            DataTable persons=new DataTable();
            SqlConnection connection=new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select * from Persons";
            SqlCommand command=new SqlCommand(Query, connection);
            try { 
            connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) {
                    persons.Load(reader);
                }reader.Close();
            }catch (Exception ex) { } finally { connection.Close(); }
            return persons; 
        }
        public static bool DeletePerson(int PersonID) 
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "delete from Persons where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }catch(Exception ex) { } 
            finally { connection.Close(); };
            return RowsAffected > 0;

        }




        public static bool UpdatePerson(int PersonID,string Name,string Password,string AccountNumber,string ImagePath
            ,float AccountBalance,int CurrencyID,DateTime DateOfBirth) {
        int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "update Persons set CurrencyID=@CurrencyID," +
                "AccountBalance=@AccountBalance,AccountNumber=@AccountNumber," +
                "Password=hashbytes('Sha2_256',@Password),Name=@Name,ImagePath=@ImagePath," +
                "DateOfBirth=@DateOfBirth where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
            //command.Parameters.AddWithValue("@IsUser", IsUser);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); };
            return RowsAffected > 0;
        }
        



        public static int AddNewPerson( string Name, string Password, string AccountNumber,string ImagePath
            , float AccountBalance, int CurrencyID, DateTime DateOfBirth)
        {
            int PersonID = 0;
            SqlConnection connection=new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "insert into Persons (Name,Password,AccountNumber,AccountBalance,CurrencyID,DateOfBirth,ImagePath) " +
                "values (@Name,Hashbytes('Sha2_256',@Password),@AccountNumber,@AccountBalance,@CurrencyID,@DateOfBirth,@ImagePath) " +
                "select Scope_identity();";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
           // command.Parameters.AddWithValue("@IsUser", IsUser);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            try {
                connection.Open();
                object res= command.ExecuteScalar();
                if (res != null) { 
                PersonID = Convert.ToInt32(res);
                }
            }catch (Exception ex) { }finally { connection.Close(); };
            return PersonID;
        }



        public static bool GetPersonBy(int PersonID, ref string Name, ref string Password, ref string AccountNumber,ref string ImagePath
            , ref float AccountBalance,  ref int CurrencyID, ref DateTime DateOfBirth)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "Select *from Persons join Users on Persons.personID=Users.PersonID where Persons.PersonID =@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.Read()) { 
                IsFound = true;
                    byte[] PasswordBytes = (byte[])reader["Password"];
                    Password = BitConverter.ToString(PasswordBytes).Replace("-","").ToLower();
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
                    Name = (string)reader["Name"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CurrencyID = (int)reader["CurrencyID"];
                   // IsUser = (byte)reader["IsUser"];
                    if (reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                }
            } catch (Exception ex) { } finally { connection.Close(); }
            return IsFound;
        }

        public static bool GetClientBy(int PersonID, ref string Name, ref string Password, ref string AccountNumber, ref string ImagePath
            , ref float AccountBalance, ref int CurrencyID, ref DateTime DateOfBirth)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "Select *from Persons join Clients on Persons.personID=Clients.PersonID where Persons.PersonID =@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    byte[] PasswordBytes = (byte[])reader["Password"];

                    Password = BitConverter.ToString( PasswordBytes).Replace("-","").ToLower();
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
                    Name = (string)reader["Name"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CurrencyID = (int)reader["CurrencyID"];
                    // IsUser = (byte)reader["IsUser"];
                    if (reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return IsFound;
        }


        public static bool GetPersonBy(ref int PersonID,   string Name, ref string Password, ref string AccountNumber,ref string ImagePath
            , ref float AccountBalance, ref int CurrencyID, ref DateTime DateOfBirth)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "Select *from Persons join Clients on Persons.personID=Clients.PersonID where Name =@Name";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            try {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader != null) {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CurrencyID = (int)reader["CurrencyID"];
                 //   IsUser = (byte)reader["IsUser"];
                    if (reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                }
            } catch (Exception ex) { } finally { connection.Close(); }
            return IsFound;
        }

        public static bool GetUserBy(ref int PersonID, string Name,  string Password, ref string AccountNumber, ref string ImagePath
    , ref float AccountBalance, ref int CurrencyID, ref DateTime DateOfBirth)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "Select *from Persons join Users on Persons.personID=Users.PersonID " +
                "where Name =@Name and Password =Hashbytes('Sha2_256',@Password)";
    
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CurrencyID = (int)reader["CurrencyID"];
                    //   IsUser = (byte)reader["IsUser"];
                    if (reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return IsFound;
        }


        public static bool GetPersonBy(ref int PersonID,   string Name,   string Password, ref string AccountNumber,ref string ImagePath
            , ref float AccountBalance,  ref int CurrencyID, ref DateTime DateOfBirth)
        {
            bool IsFound = false;
          //  byte[] NewPassword =Encoding.UTF8.GetBytes( Password);
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "Select *from Persons join Clients on Persons.personID=Clients.PersonID where Name =@Name and Password =" +
                "hashbytes('Sha2_256', @Password)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Password", Password);
            try {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if (reader.Read()) { 
                IsFound = true;
                    
                    PersonID = (int)reader["PersonID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CurrencyID = (int)reader["CurrencyID"];
                  //  IsUser = (byte)reader["IsUser"];
                    if (reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }

                }
            } catch (Exception ex) { } finally { connection.Close(); }
            return IsFound;
        }



        public static bool GetPersonBy(ref int PersonID,ref  string Name, ref string Password,  string AccountNumber,ref string ImagePath
            , ref float AccountBalance,  ref int CurrencyID, ref DateTime DateOfBirth)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "Select *from Persons join Clients on Persons.personID=Clients.PersonID where AccountNumber =@AccountNumber";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader .Read())
                {
                    IsFound = true;
                    PersonID = (int)reader["PersonID"];
                    Password = (string)reader["Password"];
                    Name = (string)reader["Name"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CurrencyID = (int)reader["CurrencyID"];
                 //   IsUser = (byte)reader["IsUser"];
                    if (reader["ImagePath"] == DBNull.Value) { ImagePath = ""; }
                    else
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return IsFound;
        }
        public static bool DepositeAndWithdraw(int FromPersonID,int ToPersonID,decimal Amount,DateTime TransferDate,
            int transferByUserID)
        {
            int RowsAffected = 0;
            SqlConnection connection=new SqlConnection(ClsDataAccessSettings.StringConnection);
           // string Query = "update Persons set AccountBalance = @AccountBalance where PersonID =@PersonID";
            SqlCommand command=new SqlCommand("TransactMoney", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AmountInDollar", Amount);
            command.Parameters.AddWithValue("@PersonToID", ToPersonID);
            command.Parameters.AddWithValue("@PersonFromID", FromPersonID);
            command.Parameters.AddWithValue("@TransferByUserID", transferByUserID);
            command.Parameters.AddWithValue("@TransferDate", TransferDate);

            try { 
            connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }catch (Exception ex) { }finally { connection.Close(); }
            return RowsAffected > 0;
        }
    }
}
