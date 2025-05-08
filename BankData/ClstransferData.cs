using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public class ClstransferData
    {
        public static int AddNewTransfer(int ClientFromID, int ClientToID, float AmountInDollar, int TransferByUserID, DateTime TransferDate)
        {
            int TransferID = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "insert into Transfers (FromClientID,ToClientID,AmountInDollar,TransferByUserID,TransferDate)" +
                "values(@ClientFromID,@ClientToID,@AmountInDollar,@TransferByUserID,@TransferDate)" +
                ";select Scope_identity()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientFromID", ClientFromID);
            command.Parameters.AddWithValue("@ClientToID", ClientToID);
            command.Parameters.AddWithValue("@AmountInDollar", AmountInDollar);
            command.Parameters.AddWithValue("@TransferByUserID", TransferByUserID);
            command.Parameters.AddWithValue("@TransferDate", TransferDate);
            try {
                connection.Open();
                object res = command.ExecuteScalar();
                if (res != null)
                {
                    TransferID = Convert.ToInt32(res);

                }
            }
            catch (Exception) { } finally { connection.Close(); }
            return TransferID;
        }

        public static bool DeleteTransfer(int ClientFromID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "Delete From Transfers where FromClientID = @ClientFromID or ToClientID=@ClientFromID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientFromID", ClientFromID);
            try {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            } catch (Exception ex) { } finally { connection.Close(); }
            return RowsAffected > 0;
        }
        public
             static DataTable GetAllTransfers()
        {
            DataTable Transfers = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.StringConnection);
            string Query = "select *from Transfers";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Transfers.Load(reader);
                }
                reader.Close();


            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return Transfers;
        }
    }
}
