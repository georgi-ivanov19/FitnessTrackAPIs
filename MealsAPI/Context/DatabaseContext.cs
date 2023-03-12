namespace MealsAPI.Context
{
    using MealsAPI.Models;
    using Microsoft.EntityFrameworkCore;
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Meal> Meals { get; set; }
    }
}
