using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Data.SqlClient;

namespace FirstMVCApplication.Models
{
    public class SQLHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2839\SQLEXPRESS;database=testdb;integrated security=true;Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
