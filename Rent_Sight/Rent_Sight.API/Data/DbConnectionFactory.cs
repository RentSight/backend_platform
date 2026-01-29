// Data/DbConnectionFactory.cs
using System.Data;
using Npgsql;

namespace Rent_Sight.API.Data
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString)
        {
            // Garantia extra (mesmo validando no Program.cs)
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string não pode ser nula/vazia.", nameof(connectionString));

            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            // Retorna FECHADA; o Service abre/usa/descarta com using.
            return new NpgsqlConnection(_connectionString);
        }
    }
}
