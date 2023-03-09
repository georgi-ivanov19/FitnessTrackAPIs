using Microsoft.EntityFrameworkCore;
using WorkoutsAPI.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("WorkoutDBConnectionString") ?? throw new InvalidOperationException("Connection string 'WorkoutDBConnectionString' not found.");
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connectionString).EnableDetailedErrors());
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
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("MyPolicy");
app.MapControllers();

app.Run();
