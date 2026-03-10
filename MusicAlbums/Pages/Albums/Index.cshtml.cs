using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicAlbums.Models;

namespace MusicAlbums.Pages.Albums;

public class IndexModel : PageModel
{
    private readonly MusicAlbumsContext _context;

    public IndexModel(MusicAlbumsContext context)
    {
        _context = context;
    }

    public IList<Album> Albums { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Albums = await _context.Album.ToListAsync();
    }
}