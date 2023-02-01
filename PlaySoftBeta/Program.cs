using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Models;
// using Npgsql;


var builder = WebApplication.CreateBuilder(args);

//var conBuilder = new NpgsqlConnectionStringBuilder(builder.Configuration.GetConnectionString("local"));

builder.Services.AddDbContext<RepositoryContext>(options =>
{
   options.UseSqlServer(builder.Configuration.GetConnectionString("RepositoryContext"));
});

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
