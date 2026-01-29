using System.Data;

namespace Rent_Sight.API.Data
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
