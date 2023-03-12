using MeasurementsAPI.Context;
using MeasurementsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MeasurementsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasuremetsController : ControllerBase
    {
        //// Cosmos DB details, In real use cases, these details should be configured in secure configuraion file.
        //private readonly string CosmosDBAccountUri = "https://fitness-track-cn.documents.azure.com:443/";
        //// host.docker.internal
        //private readonly string CosmosDBAccountPrimaryKey = "nET8oDlA3KtgqkIyYefoe78mABsbTcOQgwTtYCBFyNOJs4htUPh9DXKjLPJd4BgtR3Z4XSsXLg8fACDbcNSiUQ==";
        //private readonly string CosmosDbName = "FitnessTrack";
        //private readonly string CosmosDbContainerName = "Measurements";

        ///// <summary>
        ///// Commom Container Client, you can also pass the configuration paramter dynamically.
        ///// </summary>
        ///// <returns> Container Client </returns>
        //private Container ContainerClient()
        //{

        //    CosmosClient cosmosDbClient = new CosmosClient(CosmosDBAccountUri, CosmosDBAccountPrimaryKey);
        //    Container containerClient = cosmosDbClient.GetContainer(CosmosDbName, CosmosDbContainerName);
        //    return containerClient;

        //}

        private readonly DatabaseContext _context;

        public MeasuremetsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Measurement>> AddMeasurement(Measurement measurement)
        {
            //try
            //{

            //    var container = ContainerClient();
            //    ContainerProperties properties = await container.ReadContainerAsync();
            //    var response = await container.CreateItemAsync(measurement, new PartitionKey(measurement.applicationUserId));

            //    return Ok(response);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}

            _context.Measurements.Add(measurement);
            await _context.SaveChangesAsync();

            return Ok(measurement);
        }

        [HttpGet]
        public async Task<IActionResult> GetMeasurements(string applicationUserId)
        {

            if(applicationUserId == null)
            {
                return BadRequest("User ID is a required parameter");
            }
            var measurements = await _context.Measurements.Where(m => m.applicationUserId == applicationUserId).ToListAsync();
            return Ok(measurements);

            //try
            //{

            //    Stopwatch stopwatch2 = new Stopwatch();
            //    stopwatch2.Start();
            //    var container = ContainerClient();
            //    stopwatch2.Stop();
            //    Console.WriteLine($"It took {stopwatch2.ElapsedMilliseconds}ms to Get Container");
            //    // add user filter;
            //    Stopwatch stopwatch = new Stopwatch();
            //    stopwatch.Start();
            //    var parameterizedQuery = new QueryDefinition(
            //        query: "SELECT * FROM Measurements m WHERE m.applicationUserId = @partitionKey")
            //            .WithParameter("@partitionKey", applicationUserId);
            //    //QueryDefinition queryDefinition = new QueryDefinition(parameterizedQuery);
            //    FeedIterator<Measurement> queryResultSetIterator = container.GetItemQueryIterator<Measurement>(parameterizedQuery);


            //    List<Measurement> measurements = new List<Measurement>();
            //    var requestCharge = 0d;
            //    while (queryResultSetIterator.HasMoreResults)
            //    {
            //        FeedResponse<Measurement> currentResultSet = await queryResultSetIterator.ReadNextAsync();
            //        requestCharge += currentResultSet.RequestCharge;
            //        foreach (Measurement employee in currentResultSet)
            //        {
            //            measurements.Add(employee);
            //        }
            //        Console.WriteLine("hello");

            //    }
            //    stopwatch.Stop();
            //    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds}ms to Get Measurements\t RUs - {requestCharge}");
            //    return Ok(measurements);
            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}
        }

        [HttpGet("{measurementId}")]
        public async Task<IActionResult> GetMeasurementById(int measurementId) //, string applicationUserId)
        {
            var measurement = await _context.Measurements.FirstOrDefaultAsync(m => m.Id == measurementId);
            if (measurement == null)
            {
                return NotFound("Measurement not found");
            }
            return Ok(measurement);
            //try
            //{
            //    var container = ContainerClient();
            //    ItemResponse<Measurement> response = await container.ReadItemAsync<Measurement>(measurementId, new PartitionKey(applicationUserId));
            //    return Ok(response.Resource);
            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Measurement>> UpdateMeasurement(Measurement measurement, int id)
        {
            var dbMeasurement = await _context.Measurements.FirstOrDefaultAsync(m => m.Id == id);
            if (dbMeasurement == null)
            {
                return NotFound("Measurement Not Found");
            }
            dbMeasurement.Value = measurement.Value;
            dbMeasurement.Unit = measurement.Unit;
            dbMeasurement.Type = measurement.Type;
            dbMeasurement.Date = measurement.Date;
            await _context.SaveChangesAsync();

            return Ok(dbMeasurement);
            //try
            //{
            //    var container = ContainerClient();
            //    ItemResponse<Measurement> res = await container.ReadItemAsync<Measurement>(measurement.Id, new PartitionKey(measurement.applicationUserId));

            //    //Get Existing Item
            //    var existingItem = res.Resource;

            //    //Replace existing item values with new values
            //    existingItem.Value = measurement.Value;
            //    existingItem.Type = measurement.Type;
            //    existingItem.Unit = measurement.Unit;
            //    existingItem.Date = measurement.Date;

            //    var updateRes = await container.ReplaceItemAsync(existingItem, measurement.Id, new PartitionKey(measurement.applicationUserId));

            //    return Ok(updateRes.Resource);

            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
        // }

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMeasurement(int id) // (string measurementId, string applicationUserId)
        {
            var dbMeasurement = await _context.Measurements.FirstOrDefaultAsync(w => w.Id == id);
            if (dbMeasurement == null)
            {
                return NotFound("Workout Not Found");
            }

            _context.Measurements.Remove(dbMeasurement);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
