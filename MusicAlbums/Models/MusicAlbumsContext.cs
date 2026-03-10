using Microsoft.EntityFrameworkCore;

namespace MusicAlbums.Models;

public class MusicAlbumsContext : DbContext
{
    public MusicAlbumsContext(DbContextOptions<MusicAlbumsContext> options)
        : base(options)
    {
    }

    public DbSet<Album> Album { get; set; } = default!;
}