using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicAlbums.Models;

namespace MusicAlbums.Pages.Albums;

public class DeleteModel : PageModel
{
    private readonly MusicAlbumsContext _context;

    public DeleteModel(MusicAlbumsContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int id)
    {
        var album = await _context.Album.FindAsync(id);

        if (album != null)
        {
            _context.Album.Remove(album);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}