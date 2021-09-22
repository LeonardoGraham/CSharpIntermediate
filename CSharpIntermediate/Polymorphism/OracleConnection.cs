using System;

namespace CSharpIntermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void Close()
        {
            Console.WriteLine("Oracle database connection is closed.");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle database connection is opened.");
        }
    }
}
