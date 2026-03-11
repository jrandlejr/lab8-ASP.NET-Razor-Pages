using System.ComponentModel.DataAnnotations;

namespace MusicAlbums.Models;

public class Album
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Artist { get; set; } = string.Empty;

    [Required]
    [Range(1900, 2026)]
    public int Year { get; set; }

    [Required]
    [StringLength(30)]
    public string Genre { get; set; } = string.Empty;
}