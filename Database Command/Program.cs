using System;

namespace DatabaseCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlCommand = "SELECT * FROM Customers";
            var sqlConnection = new SqlConnection("sqlconnectionstring");

            var dbCommand = new DbCommand(sqlCommand, sqlConnection);
            dbCommand.Execute();

            Console.WriteLine();

            var oracleCommand = "SELECT * FROM Users";
            var oracleConnection = new OracleConnection("oracleconnectionstring");

            dbCommand = new DbCommand(oracleCommand, oracleConnection);
            dbCommand.Execute();
        }
    }

    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty.");

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine("Sql connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection closed");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine("Oracle connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection closed");
        }
    }

    public class DbCommand
    {
        public string Instruction { get; private set; }
        public DbConnection DbConnection { get; private set; }

        public DbCommand(string instruction, DbConnection dbConnection)
        {
            if (string.IsNullOrEmpty(instruction))
                throw new ArgumentException("Instruction cannot be null or empty.");

            Instruction = instruction;

            DbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
        }

        public void Execute()
        {
            DbConnection.Open();

            Console.WriteLine(Instruction);

            DbConnection.Close();
        }
    }
}
