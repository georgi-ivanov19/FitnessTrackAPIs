using Microsoft.EntityFrameworkCore;
using MeasurementsAPI.Models;
using System.Collections.Generic;
namespace MeasurementsAPI.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
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
                                        "5f9c85a5-0150-4a44-b5a8-e2bf0e72a6b1"
                                    };
            var measurements = new List<Measurement>();
            Random random = new Random();
            foreach (var userId in userIds){
                for(int j = 1; j <= 14; j++){
                    var measurement = new Measurement
                    {
                        Id = userIds.IndexOf(userId) * 14 + j,
                        Value = random.Next(80, 87),
                        applicationUserId = userId,
                        Type = "Weight",
                        Date = DateTime.Now.AddDays(0 - j),
                        Unit = "kg"
                    };
                    measurements.Add(measurement);
                }
            }
            modelBuilder.Entity<Measurement>().HasData(measurements);
        }
        public DbSet<Measurement> Measurements { get; set; }
    }
}
