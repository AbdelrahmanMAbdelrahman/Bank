using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public class ClsCurrencyData
    {
        public static DataTable GetAllCurrencies()
        {
            DataTable currencies = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select *from Currency;";
            SqlCommand command = new SqlCommand(Query, connection);
            try { 
               connection.Open();
            SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) { 
                currencies.Load(reader);
                }reader.Close();
            }catch (Exception ex) { } finally { 
            connection.Close();
            }return currencies;

        }




        public static int AddNewCurrency(string CurrencyName,float CurrencyInDollar)
        {
            int CurrencyID = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "insert into Currency (CurrencyName,CurrencyInDollar)values (@CurrencyName,@CurrencyInDollar);" +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            command.Parameters.AddWithValue("@CurrencyInDollar", CurrencyInDollar);
            try {
                connection.Open();
               object res= command.ExecuteScalar();//WHAT IS THE REASON MAKE THE RES =NULL OTHERWISE THE DATA HAS BEEN SAVED SUCCESSFULLY 
                if (res != null) { 
                CurrencyID= Convert.ToInt32(res);
                }
            } catch (Exception ex) { } finally {
                connection.Close();
            }return CurrencyID;

        }



        public static bool UpdateCurrency(string CurrencyName, float CurrencyInDollar,int CurrencyID) {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "update Currency set CurrencyName=@CurrencyName,CurrencyInDollar=@CurrencyInDollar where CurrencyID=@CurrencyID;";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            command.Parameters.AddWithValue("@CurrencyInDollar", CurrencyInDollar);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            try {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            } catch (Exception ex) { } finally { connection.Close(); }
            return RowsAffected>0;
        }     




        public static bool DeleteCurrency( int CurrencyID) {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "delete from Currency where CurrencyID =@CurrencyID;";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            try {
                connection.Open();
           RowsAffected = command.ExecuteNonQuery();

            } catch (Exception ex) { } finally { connection.Close(); }return RowsAffected>0;
        }



        public static bool GetCurrencyBy(int CurrencyID,ref string CurrencyName,ref float CurrencyInDollar) {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select *from Currency where CurrencyID=@CurrencyID;";
            SqlCommand command=new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyID",CurrencyID);
            try {
                connection.Open();
              SqlDataReader reader=command.ExecuteReader();
                if (reader.Read()) { 
                IsFound = true;
                    CurrencyInDollar =Convert.ToSingle( reader["CurrencyInDollar"]);
                    CurrencyName = (string)reader["CurrencyName"];
                }
            }catch (Exception ex) { } finally {connection.Close(); } return IsFound;

        }




        public static bool GetCurrencyBy(ref  int CurrencyID,  string CurrencyName, ref float CurrencyInDollar)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select *from Currency where CurrencyName=@CurrencyName;";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyName", CurrencyName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    CurrencyInDollar = Convert.ToSingle(reader["CurrencyInDollar"]);
                    CurrencyID = (int)reader["CurrencyID"];
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return IsFound;

        }

    }
}
