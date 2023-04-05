using DashboardAPI.Models.Workouts;
using DashboardAPI.Models.Meals;
using DashboardAPI.Models.Measuremets;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});
var mealsDbConnectionString = builder.Configuration.GetConnectionString("MealsDBConnection") ?? throw new InvalidOperationException("Connection string 'MealsDBConnection'... not found.");
var measurementsDbConnectionString = builder.Configuration.GetConnectionString("MeasurementsDBConnection") ?? throw new InvalidOperationException("Connection string 'MeasurementsDBConnection'... not found.");
var workoutsDbConnectionString = builder.Configuration.GetConnectionString("WorkoutsDBConnection") ?? throw new InvalidOperationException("Connection string 'WorkoutsDBConnection'... not found.");
builder.Services.AddDbContext<WorkoutsDatabaseContext>(options =>
    options.UseSqlServer(workoutsDbConnectionString, builder => {
        builder.EnableRetryOnFailure();
    }).EnableDetailedErrors());
builder.Services.AddDbContext<MealsDatabaseContext>(options =>
    options.UseSqlServer(mealsDbConnectionString, builder => {
        builder.EnableRetryOnFailure();
    }).EnableDetailedErrors());
builder.Services.AddDbContext<MeasurementsDatabaseContext>(options =>
    options.UseSqlServer(measurementsDbConnectionString, builder => {
        builder.EnableRetryOnFailure();
    }).EnableDetailedErrors());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseAuthorization();
app.UseCors("MyPolicy");
app.MapControllers();

app.Run();
