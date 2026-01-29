using Microsoft.AspNetCore.Mvc;
using Rent_Sight.API.Data;
using System.Data;
using Dapper;

namespace Rent_Sight.API.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public HealthController(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        [HttpGet("db")]
        public async Task<IActionResult> CheckDatabase()
        {
            try
            {
                using IDbConnection connection = _connectionFactory.CreateConnection();
                connection.Open();

                var result = await connection.ExecuteScalarAsync<int>("SELECT 1");

                return Ok(new
                {
                    status = "ok",
                    database = "connected",
                    result
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    status = "error",
                    message = ex.Message
                });
            }
        }
    }
}
