using System;
namespace CSharpIntermediate
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbInstruction;

        public DbCommand(DbConnection dbConnection, string dbInstruction)
        {
            if (dbConnection == null)
            {
                throw new ArgumentNullException("dbConnection is null.");
            }
            if (string.IsNullOrWhiteSpace(dbInstruction))
            {
                throw new ArgumentNullException("dbInstruction is null, empty, or whitespace.");
            }

            this._dbConnection = dbConnection;
            this._dbInstruction = dbInstruction;
        }

        public void Execute()
        {
            this._dbConnection.Open();
            Console.WriteLine(_dbInstruction);
            this._dbConnection.Close();
        }
    }
}
