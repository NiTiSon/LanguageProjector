namespace LanguageProjector.Logic;

public sealed class Phoneme
{
    public Guid Id { get; init; }
    public string Symbol { get; set; } = string.Empty; // should replace with IPA Symbol struct
    public PhonemeType Type { get; set; } = PhonemeType.Consonant;

    public ConsonantPlace? Place { get; set; }
    public ConsonantManner? Manner { get; set; }
    public bool? Voiced { get; set; }

    public VowelHeight? Height { get; set; }
    public VowelBackness? Backness { get; set; }
    public bool? Rounded { get; set; }

    public string? Description { get; set; }

    public static Phoneme Create(string symbol, PhonemeType type) => new()
    {
        Id = Guid.CreateVersion7(),
        Symbol = symbol,
        Type = type
    };
}
