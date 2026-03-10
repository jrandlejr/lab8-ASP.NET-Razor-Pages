using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MusicAlbums.Models;

public class MusicAlbumsContextFactory : IDesignTimeDbContextFactory<MusicAlbumsContext>
{
    public MusicAlbumsContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MusicAlbumsContext>();
        optionsBuilder.UseSqlite("Data Source=MusicAlbums.db");

        return new MusicAlbumsContext(optionsBuilder.Options);
    }
}