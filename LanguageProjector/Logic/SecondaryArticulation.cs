namespace LanguageProjector.Logic;

[Flags]
public enum SecondaryArticulation
{
    None = 0,

    Palatalized = 1 << 0,
    Labialized = 1 << 1,
    Velarized = 1 << 2,
    Pharyngealized = 1 << 3,
    Rhoticized = 1 << 4,
    Nasalized = 1 << 5
}