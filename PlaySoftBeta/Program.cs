using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Models;
// using Npgsql;


var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RepositoryContext>(options =>
{
   options.UseInMemoryDatabase("testDb");
   //options.UseSqlServer(builder.Configuration.GetConnectionString("RepositoryContext"));
});

var app = builder.Build();
startup.Configure(app, builder.Environment);

