using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using notationRestApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var conStrBuilder = new MySqlConnectionStringBuilder(builder.Configuration.GetConnectionString("Database"));
conStrBuilder.Password = builder.Configuration["Notation:DatabasePw"];
var connection = conStrBuilder.ConnectionString;

var serverVersion = new MariaDbServerVersion(ServerVersion.AutoDetect(connection));
builder.Services.AddDbContext<UserContext>(opt => opt.UseMySql(connection, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors());

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
