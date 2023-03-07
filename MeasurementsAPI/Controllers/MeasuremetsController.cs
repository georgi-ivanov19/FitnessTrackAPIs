using MeasurementsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using System.Diagnostics;

namespace MeasurementsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasuremetsController : ControllerBase
    {
        // Cosmos DB details, In real use cases, these details should be configured in secure configuraion file.
        private readonly string CosmosDBAccountUri = "https://fitness-track-cn.documents.azure.com:443/";
        // host.docker.internal
        private readonly string CosmosDBAccountPrimaryKey = "nET8oDlA3KtgqkIyYefoe78mABsbTcOQgwTtYCBFyNOJs4htUPh9DXKjLPJd4BgtR3Z4XSsXLg8fACDbcNSiUQ==";
        private readonly string CosmosDbName = "FitnessTrack";
        private readonly string CosmosDbContainerName = "Measurements";

        /// <summary>
        /// Commom Container Client, you can also pass the configuration paramter dynamically.
        /// </summary>
        /// <returns> Container Client </returns>
        private Container ContainerClient()
        {

            CosmosClient cosmosDbClient = new CosmosClient(CosmosDBAccountUri, CosmosDBAccountPrimaryKey);
            Container containerClient = cosmosDbClient.GetContainer(CosmosDbName, CosmosDbContainerName);
            return containerClient;

        }

        [HttpGet]
        public async Task<IActionResult> GetMeasurements(string applicationUserId)
        {
            try
            {

                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                var container = ContainerClient();
                stopwatch2.Stop();
                Console.WriteLine($"It took {stopwatch2.ElapsedMilliseconds}ms to Get Container");
                // add user filter;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                var parameterizedQuery = new QueryDefinition(
                    query: "SELECT * FROM Measurements m WHERE m.applicationUserId = @partitionKey")
                        .WithParameter("@partitionKey", applicationUserId);
                //QueryDefinition queryDefinition = new QueryDefinition(parameterizedQuery);
                FeedIterator<Measurement> queryResultSetIterator = container.GetItemQueryIterator<Measurement>(parameterizedQuery);


                List<Measurement> measurements = new List<Measurement>();
                var requestCharge = 0d;
                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<Measurement> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    requestCharge += currentResultSet.RequestCharge;
                    foreach (Measurement employee in currentResultSet)
                    {
                        measurements.Add(employee);
                    }
                    Console.WriteLine("hello");

                }
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds}ms to Get Measurements\t RUs - {requestCharge}");
                return Ok(measurements);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{measurementId}")]
        public async Task<IActionResult> GetMeasurementById(string measurementId, string applicationUserId)
        {

            try
            {
                var container = ContainerClient();
                ItemResponse<Measurement> response = await container.ReadItemAsync<Measurement>(measurementId, new PartitionKey(applicationUserId));
                return Ok(response.Resource);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
