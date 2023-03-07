using MealsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using System.Diagnostics;

namespace MealsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        // Cosmos DB details, In real use cases, these details should be configured in secure configuraion file.
        private readonly string CosmosDBAccountUri = "https://fitness-track-cn.documents.azure.com:443/";
        // host.docker.internal
        private readonly string CosmosDBAccountPrimaryKey = "nET8oDlA3KtgqkIyYefoe78mABsbTcOQgwTtYCBFyNOJs4htUPh9DXKjLPJd4BgtR3Z4XSsXLg8fACDbcNSiUQ==";
        private readonly string CosmosDbName = "FitnessTrack";
        private readonly string CosmosDbContainerName = "Meals";

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

        [HttpPost]
        public async Task<IActionResult> AddMeal(Meal meal)
        {
            try
            {

                var container = ContainerClient();
                ContainerProperties properties = await container.ReadContainerAsync();
                var response = await container.CreateItemAsync(meal, new PartitionKey(meal.applicationUserId));

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetMeals(string applicationUserId)
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
                    query: "SELECT * FROM Meals m WHERE m.applicationUserId = @partitionKey")
                        .WithParameter("@partitionKey", applicationUserId);
                //QueryDefinition queryDefinition = new QueryDefinition(parameterizedQuery);
                FeedIterator<Meal> queryResultSetIterator = container.GetItemQueryIterator<Meal>(parameterizedQuery);


                List<Meal> meals = new List<Meal>();
                var requestCharge = 0d;
                while (queryResultSetIterator.HasMoreResults)
                {
                    FeedResponse<Meal> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                    requestCharge += currentResultSet.RequestCharge;
                    foreach (Meal meal in currentResultSet)
                    {
                        meals.Add(meal);
                    }
                    Console.WriteLine("hello");
                   
                }
                stopwatch.Stop();
                Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds}ms to Get Meals\t RUs - {requestCharge}");
                return Ok(meals);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{mealId}")]
        public async Task<IActionResult> GetMealById(string mealId, string applicationUserId)
        {

            try
            {
                var container = ContainerClient();
                ItemResponse<Meal> response = await container.ReadItemAsync<Meal>(mealId, new PartitionKey(applicationUserId));
                return Ok(response.Resource);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMeal(Meal meal)
        {

            try
            {
                var container = ContainerClient();
                ItemResponse<Meal> res = await container.ReadItemAsync<Meal>(meal.Id, new PartitionKey(meal.applicationUserId));

                //Get Existing Item
                var existingItem = res.Resource;

                //Replace existing item values with new values 
                existingItem.TotalCalories = meal.TotalCalories;
                existingItem.Protein = meal.Protein;
                existingItem.Category = meal.Category;
                existingItem.Carbohydrates = meal.Carbohydrates;
                existingItem.Fats = meal.Fats;
                existingItem.Date = meal.Date;

                var updateRes = await container.ReplaceItemAsync(existingItem, meal.Id, new PartitionKey(meal.applicationUserId));

                return Ok(updateRes.Resource);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMeal(string mealId, string applicationUserId)
        {

            try
            {
                var container = ContainerClient();
                var response = await container.DeleteItemAsync<Meal>(mealId, new PartitionKey(applicationUserId));
                return Ok(response.StatusCode);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
