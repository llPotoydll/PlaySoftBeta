using Microsoft.EntityFrameworkCore;
using PlaySoftBeta.Models;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        :base(options)
        {
        }

        public DbSet<User> Users {get; set;} = null!;
        DbSet<Playlist> Playlists {get; set;} = null!;
        DbSet<Song> Songs {get; set;} = null!;
}
