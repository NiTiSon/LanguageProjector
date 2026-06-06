namespace LanguageProjector.Logic;

public sealed class Phoneme
{
    public Guid Id { get; init; }
    public PhonemeType Type { get; set; } = PhonemeType.Consonant;

    public ConsonantPlace? Place { get; set; }
    public ConsonantManner? Manner { get; set; }
    public bool? Voiced { get; set; }

    public VowelHeight? Height { get; set; }
    public VowelBackness? Backness { get; set; }
    public bool? Rounded { get; set; }

    public string? Description { get; set; }

    public string Symbol => Type switch
    {
        PhonemeType.Consonant when Place is not null && Manner is not null && Voiced is not null
            => IpaData.ResolveConsonant(Place.Value, Manner.Value, Voiced.Value) ?? "",
        PhonemeType.Vowel when Height is not null && Backness is not null && Rounded is not null
            => IpaData.ResolveVowel(Height.Value, Backness.Value, Rounded.Value) ?? "",
        _ => ""
    };

    public static Phoneme Create(PhonemeType type) => new()
    {
        Id = Guid.CreateVersion7(),
        Type = type
    };
}
