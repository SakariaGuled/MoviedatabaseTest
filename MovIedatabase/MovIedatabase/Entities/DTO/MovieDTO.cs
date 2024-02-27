namespace MovIedatabase.Entities.DTO;

    public record MovieDTO(
        int Id,
        string Title,
        DateTime? ReleaseDate,
        string Director,
        string Genre,
        string MainActor,
        long? Gross,
        string Language,
        string Description,
        string Country,
        int? Duration
    );
