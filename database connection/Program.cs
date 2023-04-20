using System;

namespace Exercise1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty", nameof(connectionString));

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("SQL connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("SQL connection closed");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection closed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("sqlconnectionstring");
            sqlConnection.Open();
            sqlConnection.Close();

            var oracleConnection = new OracleConnection("oracleconnectionstring");
            oracleConnection.Open();
            oracleConnection.Close();
        }
    }
}
