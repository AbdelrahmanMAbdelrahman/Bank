using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public class ClsUserData
    {
        public static DataTable GetAllUsers ()
        {
            DataTable Users = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select *from Users join Persons on Users.PersonID=Persons.PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Users.Load(reader);
                    reader.Close();
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return Users;
        }
        public static int AddNewUser(int PersonID)
        {
            int UserID = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "insert into Users (PersonID) values(@PersonID) select scope_identity()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object res = command.ExecuteScalar();
                if (res != null)
                {
                    UserID = Convert.ToInt32(res);
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return UserID;
        }
        public static bool FindBy(int UserID, ref int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select *from Users where UserID =@UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); };
            return IsFound;
        }
        public static bool FindBy(ref int UserID, int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select *from Users where PersonID =@PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];

                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); };
            return IsFound;
        }
        public static bool DeleteUser(int PersonID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "delete from Users where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); };
            return RowsAffected > 0;
        }
    }
}
