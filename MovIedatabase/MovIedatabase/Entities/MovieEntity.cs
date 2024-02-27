using System.ComponentModel.DataAnnotations;

public class MovieEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    [Required]
    public DateTime ReleaseDate { get; set; }

    [Required]
    public string Director { get; set; } = string.Empty;

    [Required]
    public string Genre { get; set; } = string.Empty; 

    public string MainActor { get; set; } = string.Empty;

    public long? Gross { get; set; }

    public string Language { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public int? Duration { get; set; }
}
