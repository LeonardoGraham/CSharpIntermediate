using System;

namespace CSharpIntermediate
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidCastException("connectionString");
            }

            this._connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
