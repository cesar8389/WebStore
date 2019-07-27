using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebStory.Repository.Utility
{
    public class ConnectionFactory
    {
        public static SqlConnection GetConnection(string connectionString)
        {
            var conn = new SqlConnection(connectionString);

            conn.Open();

            return conn;
        }
    }
}
