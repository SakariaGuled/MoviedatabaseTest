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

    public long Gross { get; set; } = string.Empty;
}
