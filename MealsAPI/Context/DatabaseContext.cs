namespace MealsAPI.Context
{
    using MealsAPI.Models;
    using Microsoft.EntityFrameworkCore;
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var userIds = new List<string>{"620eebc4-69c6-48c1-b9bc-8ceb6855b607",
                                        "9bb8263a-6dd1-42e9-8f29-a847dbb3e059",
                                        "0371f684-9a41-4d40-ba2b-62cc5eabed46",
                                        "b2f2a636-d75c-48cf-8e01-e6f86ba36d4b",
                                        "aa88aabd-677b-4588-8cb0-213d5ba9e660",
                                        "f0e37b93-0558-458c-9e61-d0330ed9f4ec",
                                        "4d0bafc4-1d88-4433-9769-1e2d251530a7",
                                        "5febdbbe-d537-430f-9ccb-b48f252d2d4e",
                                        "c4824aab-c08f-4141-86c4-082fd8bbca8c",
                                        "2abf2679-ae98-456c-99ed-fe7ca2698c2e",
                                        "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1",
                                        "b62f0930-8324-4751-8f51-28ed952311a6",
                                        "fefae04f-02fd-4441-8cb3-5a55b1fff643",
                                        "4a839a6d-2961-466b-bb2b-38b840aabb69",
                                        "9bc75699-da3d-41ab-807b-854aba8662ca",
                                        "97fa9890-e273-49c4-82bc-4d1a7b7cc9f6",
                                        "e65338b5-6083-454a-991f-1c73d2d8530d",
                                        "5ee19786-6177-43cb-bfd0-22fb5498a481",
                                        "baf0862c-14d3-4832-8290-27d899b24c26",
                                        "ef1964f0-3deb-46cc-a016-d549b13701da"
                                    };
            var meals = new List<Meal>();
            Random random = new Random();
            foreach (var userId in userIds){
                for(int j = 1; j <= 14; j++){
                    var meal = new Meal
                    {
                        Id = userIds.IndexOf(userId) * 14 + j,
                        TotalCalories = random.Next(1300, 2000),
                        Protein = random.Next(100, 150),
                        Carbohydrates = random.Next(130, 180),
                        Fats = random.Next(30, 50),
                        Category = "Breakfast",
                        applicationUserId = userId,
                        Date = DateTime.Now.AddDays(0 - j)
                    };
                    meals.Add(meal);
                }
            }
            modelBuilder.Entity<Meal>().HasData(meals);
        }

        public DbSet<Meal> Meals { get; set; }
    }
}
