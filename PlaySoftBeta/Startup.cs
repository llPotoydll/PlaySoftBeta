using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Services;
using PlaySoftBeta.Repository;

public class Startup
{
    public IConfiguration configRoot { get; }

    public Startup(IConfiguration configuration)
    {
        configRoot = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(
                "AllowAllHeaders",
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                }
            );
        });
        services.AddDbContext<RepositoryContext>(options =>
        {
            options.UseInMemoryDatabase("PlaysoftDB");
        });
        services.AddScoped<IAuthService, AuthServiceImpl>();
        services.AddTransient<IAuthRepositoy, AuthRepository>();

        services.AddAutoMapper(typeof(PlaysoftProfile));
        services.AddRazorPages();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddMvc();
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.UseCors("AllowAllHeaders");
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
        app.UseAuthorization();
        app.MapControllers();
        app.MapRazorPages();
        app.Run();
    }
}
