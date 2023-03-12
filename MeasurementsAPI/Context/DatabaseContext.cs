using Microsoft.EntityFrameworkCore;
using MeasurementsAPI.Models;
namespace MeasurementsAPI.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Measurement> Measurements { get; set; }
    }
}
