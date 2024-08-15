using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAXApp1
{
    public class DatabaseManager
    {
        private string server;
        private string database;
        private string userId;
        private string password;

        // Constructor to initialize the DatabaseManager with connection details
        public DatabaseManager(string server, string database, string userId, string password)
        {
            this.server = server;
            this.database = database;
            this.userId = userId;
            this.password = password;
        }

        // Property to get the connection string
        public string ConnectionString
        {
            get
            {
                return $"Server={server};Database={database};User Id={userId};Password={password};";
            }
        }

        // Method to open a connection
        public SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
