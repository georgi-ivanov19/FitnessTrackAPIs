using MealsAPI.Context;
using MealsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace MealsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public MealsController(DatabaseContext context)
        {
            _context = context;
        }

        // Cosmos DB details, In real use cases, these details should be configured in secure configuraion file.
        //private readonly string CosmosDBAccountUri = "https://fitness-track-cn.documents.azure.com:443/";
        //// host.docker.internal
        //private readonly string CosmosDBAccountPrimaryKey = "nET8oDlA3KtgqkIyYefoe78mABsbTcOQgwTtYCBFyNOJs4htUPh9DXKjLPJd4BgtR3Z4XSsXLg8fACDbcNSiUQ==";
        //private readonly string CosmosDbName = "FitnessTrack";
        //private readonly string CosmosDbContainerName = "Meals";

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

        [HttpPost]
        public async Task<ActionResult<Meal>> AddMeal(Meal meal)
        {
            _context.Meals.Add(meal);
            await _context.SaveChangesAsync();

            return Ok(meal);

            //try
            //{

            //    var container = ContainerClient();
            //    ContainerProperties properties = await container.ReadContainerAsync();
            //    var response = await container.CreateItemAsync(meal, new PartitionKey(meal.applicationUserId));

            //    return Ok(response);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }

        [HttpGet]
        public async Task<ActionResult<List<Meal>>> GetMeals(string applicationUserId)
        {
            if (applicationUserId == null)
            {
                return BadRequest("User ID is a required parameter");
            }
            var meals = await _context.Meals.Where(m => m.applicationUserId == applicationUserId).ToListAsync();
            if (meals == null)
            {
                return NotFound();
            }
            return Ok(meals);

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
            //        query: "SELECT * FROM Meals m WHERE m.applicationUserId = @partitionKey")
            //            .WithParameter("@partitionKey", applicationUserId);
            //    //QueryDefinition queryDefinition = new QueryDefinition(parameterizedQuery);
            //    FeedIterator<Meal> queryResultSetIterator = container.GetItemQueryIterator<Meal>(parameterizedQuery);


            //    List<Meal> meals = new List<Meal>();
            //    var requestCharge = 0d;
            //    while (queryResultSetIterator.HasMoreResults)
            //    {
            //        FeedResponse<Meal> currentResultSet = await queryResultSetIterator.ReadNextAsync();
            //        requestCharge += currentResultSet.RequestCharge;
            //        foreach (Meal meal in currentResultSet)
            //        {
            //            meals.Add(meal);
            //        }
            //        Console.WriteLine("hello");

            //    }
            //    stopwatch.Stop();
            //    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds}ms to Get Meals\t RUs - {requestCharge}");
            //    return Ok(meals);
            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}

        }

        [HttpGet("{mealId}")]
        public async Task<IActionResult> GetMealById(int mealId)
        {
            var meal = await _context.Meals.FirstOrDefaultAsync(m => m.Id == mealId);
            if (meal == null)
            {
                return NotFound("Meal not found");
            }
            return Ok(meal);
            //try
            //{
            //    var container = ContainerClient();
            //    ItemResponse<Meal> response = await container.ReadItemAsync<Meal>(mealId, new PartitionKey(applicationUserId));
            //    return Ok(response.Resource);
            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMeal(Meal meal, int id)
        {
            var dbMeal = await _context.Meals.FirstOrDefaultAsync(m => m.Id == id);
            if (dbMeal == null)
            {
                return NotFound("Meal Not Found");
            }
            dbMeal.Category = meal.Category;
            dbMeal.Date = meal.Date;
            dbMeal.TotalCalories = meal.TotalCalories;
            dbMeal.Protein = meal.Protein;
            dbMeal.Fats = meal.Fats;
            dbMeal.Carbohydrates = meal.Carbohydrates;

            await _context.SaveChangesAsync();

            return Ok(dbMeal);

            //try
            //{
            //    var container = ContainerClient();
            //    ItemResponse<Meal> res = await container.ReadItemAsync<Meal>(meal.Id, new PartitionKey(meal.applicationUserId));

            //    //Get Existing Item
            //    var existingItem = res.Resource;

            //    //Replace existing item values with new values 
            //    existingItem.TotalCalories = meal.TotalCalories;
            //    existingItem.Protein = meal.Protein;
            //    existingItem.Category = meal.Category;
            //    existingItem.Carbohydrates = meal.Carbohydrates;
            //    existingItem.Fats = meal.Fats;
            //    existingItem.Date = meal.Date;

            //    var updateRes = await container.ReplaceItemAsync(existingItem, meal.Id, new PartitionKey(meal.applicationUserId));

            //    return Ok(updateRes.Resource);

            //}
            //catch (Exception ex)
            //{

            //    return BadRequest(ex.Message);
            //}

        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMeal(int mealId)
        {

            var dbMeal = await _context.Meals.FirstOrDefaultAsync(m => m.Id == mealId);
            if (dbMeal == null)
            {
                return NotFound("Meal Not Found");
            }

            _context.Meals.Remove(dbMeal);
            await _context.SaveChangesAsync();
            return Ok();

            //try
            //{
            //    var container = ContainerClient();
            //    var response = await container.DeleteItemAsync<Meal>(mealId, new PartitionKey(applicationUserId));
            //    return Ok(response.StatusCode);
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest(ex.Message);
            //}
        }

        [HttpGet("GetAverages")]
        public async Task<ActionResult<List<AverageResults>>> GetAverages([FromQuery] string userId, [FromQuery] DateTime date)
        {
            var userMeals = await _context.Meals.Where(m => m.applicationUserId == userId && m.Date >= date.AddDays(-14) && m.Date <= date).ToListAsync();


            if (userMeals == null)
            {
                return NotFound("User has not Meals");
            }

            return CalculateAverages(date, userMeals);
        }

        private List<AverageResults> CalculateAverages(DateTime date, List<Meal> meals)
        {
            var currentWeekMeals = meals.Where(m => m.Date >= date.AddDays(-7)).ToList();
            var previousWeekMeals = meals.Where(m => m.Date < date.AddDays(-7)).ToList();


            double[] averageCals = new double[2];
            double[] averageProtein = new double[2];
            double[] averageCarbs = new double[2];
            double[] averageFats = new double[2];

            if (currentWeekMeals.Any())
            {
                var currentTotals = new MealMacros(
                    currentWeekMeals.Sum(m => (double)m.TotalCalories),
                    currentWeekMeals.Sum(m => (double)m.Protein),
                    currentWeekMeals.Sum(m => (double)m.Carbohydrates),
                    currentWeekMeals.Sum(m => (double)m.Fats));

                averageCals[0] = currentTotals.Calories / 7;
                averageProtein[0] = currentTotals.Protein / 7;
                averageCarbs[0] = currentTotals.Carbs / 7;
                averageFats[0] = currentTotals.Fats / 7;
            }

            if (previousWeekMeals.Any())
            {
                var previousTotals = new MealMacros(
                previousWeekMeals.Sum(m => (double)m.TotalCalories),
                previousWeekMeals.Sum(m => (double)m.Protein),
                previousWeekMeals.Sum(m => (double)m.Carbohydrates),
                previousWeekMeals.Sum(m => (double)m.Fats));

                averageCals[1] = previousTotals.Calories / 7;
                averageProtein[1] = previousTotals.Protein / 7;
                averageCarbs[1] = previousTotals.Carbs / 7;
                averageFats[1] = previousTotals.Fats / 7;
            }

            return new List<AverageResults> {
                new AverageResults(averageCals[0],0, averageCals[1]),
                new AverageResults(averageProtein[0],0, averageProtein[1]),
                new AverageResults(averageCarbs[0],0, averageCarbs[1]),
                new AverageResults(averageFats[0],0, averageFats[1])
            };
        }
    }
}
