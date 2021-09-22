using System;

namespace CSharpIntermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void Close()
        {
            Console.WriteLine("SQL database connection is closed.");
        }

        public override void Open()
        {
            Console.WriteLine("SQL database connection is opened.");
        }
    }
}
