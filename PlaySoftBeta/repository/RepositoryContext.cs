using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Models;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Playlist> PlaylistsLines { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<PlaylistLines> PlaylistLines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Song>().HasData(
                new Song
                {
                    songID = 1,
                    songName = "Nocturne Op.9 No.2",
                    duration = 4.30M,
                    publicationDate = DateTime.ParseExact("15/06/2015", "dd/MM/yyyy" ,null)
                },
                new Song
                {
                    songID = 2,
                    songName = "Invierno",
                    duration = 9.25M,
                    publicationDate = DateTime.ParseExact("15/06/2015", "dd/MM/yyyy",null)
                }
            );
    }
}
