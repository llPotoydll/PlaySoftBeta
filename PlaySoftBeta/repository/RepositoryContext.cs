using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Models;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlaylistLines>().HasKey(pl => new { pl.playlistID, pl.songID });
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Playlist> PlaylistsLines { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<PlaylistLines> PlaylistLines { get; set; }

}
