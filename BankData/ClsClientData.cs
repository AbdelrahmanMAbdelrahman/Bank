using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
  

        public class ClsClientData
        {
            public static DataTable GetAllClients()
            {
                DataTable Clients = new DataTable();
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
                string Query = "select *from Clients join Persons on Clients.PersonID=Persons.PersonID";
                SqlCommand command = new SqlCommand(Query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Clients.Load(reader);
                    }
                    reader.Close();

                }
                catch (Exception ex) { }
                finally { connection.Close(); }
                return Clients;
            }
            public static int AddNewClient(int PersonID)
            {
                int ClientID = 0;
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
                string Query = "insert into Clients (PersonID) values(@PersonID) select scope_identity()";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    object res = command.ExecuteScalar();
                    if (res != null)
                    {
                        ClientID = Convert.ToInt32(res);
                    }

                }
                catch (Exception ex) { }
                finally { connection.Close(); }
                return ClientID;
            }
            public static bool FindBy(int personID, ref int ClientID)
            {
                bool IsFound = false;
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
                string Query = "select *from Clients where PersonID =@PersonID";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@PersonID", personID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader != null)
                    {
                        IsFound = true;
                        ClientID = (int)reader["ClientID"];
                    }
                }
                catch (Exception ex) { }
                finally { connection.Close(); }
                ;
                return IsFound;
            }
            public static bool FindBy(ref int personID, int ClientID)
            {
                bool IsFound = false;
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
                string Query = "select *from Clients where ClientID =@ClientID";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@PersonID", personID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader != null)
                    {
                        IsFound = true;
                        personID = (int)reader["PersonID"];

                    }
                }
                catch (Exception ex) { }
                finally { connection.Close(); }
                ;
                return IsFound;
            }
            public static bool DeleteClient(int PersonID)
            {
                int RowsAffected = 0;
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
                string Query = "delete from Clients where PersonID = @PersonID";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                try
                {
                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception ex) { }
                finally { connection.Close(); }
                ;
                return RowsAffected > 0;
            }
        }
    }
 
