namespace MovIedatabase.Entities.DTO
{
    public record MovieDTO(
        int Id,
        string Title,
        DateTime? ReleaseDate,
        string Director,
        string Genre,
        string Language,
        long? Gross,
        string MainActor,
        string Description,
        string Country,
        int? Duration
    );

}
