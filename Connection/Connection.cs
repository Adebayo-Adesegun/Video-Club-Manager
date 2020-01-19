using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace VideoClub
{
    public static class VideoConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString;
            connectionString = "Data Source=DANIEL\\DANIEL;Initial Catalog=VideoClub Db;" + "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
