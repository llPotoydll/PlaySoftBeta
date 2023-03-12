using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Services;
using PlaySoftBeta.Models;
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
            options.UseSqlServer(("RepositoryContext"));
        });

        services.AddCors();
        services.AddScoped<IAuthService, AuthServiceImpl>();
        services.AddTransient<IAuthRepositoy, AuthRepository>();

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUserService, UserServiceImpl>();

        services.AddScoped<IPLaylistService, PlaylistService>();
        services.AddScoped<IPLaylistRepository, PlaylistRepository>();

        services.AddScoped<ISongRepository, SongRepository>();
        services.AddScoped<ISongService, SongServiceImpl>();

        services.AddScoped<IPlaylistLinesRepository, PlaylistLinesRepositoryImpl>();


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
        app.UseCors(
            options =>
                options.WithOrigins("http://localhost:8080").AllowAnyHeader().AllowAnyMethod()
        );
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
        app.UseAuthorization();
        app.MapControllers();
        AddCustomerData(app);
        app.MapRazorPages();
        app.Run();
    }
    static void AddCustomerData(WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetService<RepositoryContext>();

        context.Songs.Add(new Song
        {
            songID = 1,
            songName = "Nocturne Op.9 No.2",
            //duration = 4.30M,
            publicationDate = DateTime.ParseExact("15/06/2015", "dd/MM/yyyy", null)
        });
        context.Songs.Add(new Song
        {
            songID = 2,
            songName = "Invierno",
            //duration = 9.25M,
            publicationDate = DateTime.ParseExact("15/06/2015", "dd/MM/yyyy", null)
        });
        context.Users.Add(new User
        {
            email = "string",
            username = "string",
            password = "string",
        });
        context.SaveChanges();
    }
}