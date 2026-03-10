using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicAlbums.Models;

namespace MusicAlbums.Pages.Albums;

public class CreateModel : PageModel
{
    private readonly MusicAlbumsContext _context;

    public CreateModel(MusicAlbumsContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Album Album { get; set; } = default!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Album.Add(Album);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}