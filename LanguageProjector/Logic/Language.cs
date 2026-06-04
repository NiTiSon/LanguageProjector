namespace LanguageProjector.Logic;

public sealed class Language
{
    public Guid Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public List<Phoneme> Phonemes { get; set; } = [];
    public DateTime LastModified { get; set; }

    public static Language Create(string name) => new()
    {
        Id = Guid.CreateVersion7(),
        Name = name,
        LastModified = DateTime.UtcNow
    };
}
