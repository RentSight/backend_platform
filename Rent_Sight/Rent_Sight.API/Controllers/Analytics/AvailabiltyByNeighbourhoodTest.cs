using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_Sight.API.Data;
using Rent_Sight.API.Model;

namespace Rent_Sight.API.Controllers.Analytics
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailabiltyByNeighbourhoodTest : ControllerBase
    {
        private readonly IDbConnectionFactory _dbConnection;

        public AvailabiltyByNeighbourhoodTest(IDbConnectionFactory dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AvailabilityByNeighbourhood>>> GetAvalabiltyByNeighbourhood()
        {
            using var db = _dbConnection.CreateConnection();
            db.Open();

            var sql = @"
                SELECT
                    neighbourhood,
                    room_type_simulated,
                    listings_count,
                    avg_availability_365,
                    p50_availability_365     
                FROM gold_availability_by_neighbourhood_roomtype
                 ";

            var result = await db.QueryAsync<AvailabilityByNeighbourhood>(sql);

            return Ok(result);
        }


        [HttpGet("count")]
        public async Task<ActionResult<int>> CountAvailabilityByNeighbourhood()
        {
            using var db = _dbConnection.CreateConnection();
            db.Open();

            var sql = @"
                SELECT COUNT(*)
                FROM gold_availability_by_neighbourhood_roomtype
                ";

            var count = await db.ExecuteScalarAsync<int>(sql);

            return Ok(count);
        }


    }
}
