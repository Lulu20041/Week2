using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace DapperWeek2.Database
{
    class SQLServerDatabase : IDatabase
    {
        private readonly string connectionString = ConfigurationManager.AppSettings["connectionString"];
        private SqlConnection connection;

        public SqlConnection Connection { get => connection; }

        public void OpenConnection()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine($"Succesfully connected to database {connection.Database}");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        public void Dispose()
        {
            
            connection.Close();
        }
    }
}
