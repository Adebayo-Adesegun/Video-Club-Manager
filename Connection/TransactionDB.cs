using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VideoClub
{
    public static class TransactionDB
    {
        public static string AddTransaction(Transaction transaction)
        {
            SqlConnection connection = VideoConnection.GetConnection();
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = connection;
            addCommand.CommandType = CommandType.StoredProcedure;
            addCommand.CommandText = "INSERT_TRANSACTION";
            addCommand.Parameters.AddWithValue("@TransactionID", transaction.TransactionID);
            addCommand.Parameters.AddWithValue("@CustomerID", transaction.CustomerID);
            addCommand.Parameters.AddWithValue("@VideoName", transaction.VideoName);
            addCommand.Parameters.AddWithValue("@TDborrowed", transaction.TdBorrowed);
            addCommand.Parameters.AddWithValue("@RDate", transaction.RDate);
            addCommand.Parameters.AddWithValue("@AmountPaid", transaction.AmountPaid);
            addCommand.Parameters.AddWithValue("@LateReturnFee", transaction.LatereturnFee);
            addCommand.Parameters.AddWithValue("@Quantity", transaction.Quantity);
            try
            {
                connection.Open();
                const string message = "Transaction has been carried out successfully";
                addCommand.ExecuteNonQuery();
                return message;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
