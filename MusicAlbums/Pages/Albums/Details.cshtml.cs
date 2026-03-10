using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicAlbums.Models;

namespace MusicAlbums.Pages.Albums;

public class DetailsModel : PageModel
{
    private readonly MusicAlbumsContext _context;

    public DetailsModel(MusicAlbumsContext context)
    {
        _context = context;
    }

    public Album Album { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var album = await _context.Album.FirstOrDefaultAsync(m => m.Id == id);

        if (album == null)
        {
            return NotFound();
        }

        Album = album;
        return Page();
    }
}