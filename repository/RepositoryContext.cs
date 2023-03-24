using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Models;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlaylistLines>().HasKey(pl => new { pl.playlistID, pl.songID });
        modelBuilder.Entity<Song>().HasData(new Song { songID = 1, songName = "pumbaPumba", publicationDate = DateTime.ParseExact("15/06/2015", "dd/MM/yyyy", null) });
        modelBuilder.Entity<Song>().HasData(new Song { songID = 2, songName = "Temardo bien de guapo", publicationDate = DateTime.ParseExact("15/12/2021", "dd/MM/yyyy", null) });
        modelBuilder.Entity<Song>().HasData(new Song { songID = 3, songName = "AngryBirdsSongTheme", publicationDate = DateTime.ParseExact("25/02/1015", "dd/MM/yyyy", null) });
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<PlaylistLines> PlaylistLines { get; set; }


}
