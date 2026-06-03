namespace LanguageProjector.Logic;

public sealed class Language
{
    public Guid Id { get; }

    private Language(Guid id)
    {
        Id = id;
    }

    public static Language Create()
    {
        Guid id = Guid.CreateVersion7();
        return new(id);
    }
}