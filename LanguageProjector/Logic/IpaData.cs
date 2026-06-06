namespace LanguageProjector.Logic;

public static class IpaData
{
    public static string? ResolveConsonant(ConsonantPlace place, ConsonantManner manner, bool voiced)
        => s_consonants.GetValueOrDefault((place, manner, voiced));

    public static string? ResolveVowel(VowelHeight height, VowelBackness backness, bool rounded)
        => s_vowels.GetValueOrDefault((height, backness, rounded));

    private static readonly Dictionary<(ConsonantPlace, ConsonantManner, bool), string> s_consonants = new()
    {
        // Plosives
        [(ConsonantPlace.Bilabial, ConsonantManner.Plosive, false)] = "p",
        [(ConsonantPlace.Bilabial, ConsonantManner.Plosive, true)] = "b",
        [(ConsonantPlace.Dental, ConsonantManner.Plosive, false)] = "t̪",
        [(ConsonantPlace.Dental, ConsonantManner.Plosive, true)] = "d̪",
        [(ConsonantPlace.Alveolar, ConsonantManner.Plosive, false)] = "t",
        [(ConsonantPlace.Alveolar, ConsonantManner.Plosive, true)] = "d",
        [(ConsonantPlace.Retroflex, ConsonantManner.Plosive, false)] = "ʈ",
        [(ConsonantPlace.Retroflex, ConsonantManner.Plosive, true)] = "ɖ",
        [(ConsonantPlace.Palatal, ConsonantManner.Plosive, false)] = "c",
        [(ConsonantPlace.Palatal, ConsonantManner.Plosive, true)] = "ɟ",
        [(ConsonantPlace.Velar, ConsonantManner.Plosive, false)] = "k",
        [(ConsonantPlace.Velar, ConsonantManner.Plosive, true)] = "ɡ",
        [(ConsonantPlace.Uvular, ConsonantManner.Plosive, false)] = "q",
        [(ConsonantPlace.Uvular, ConsonantManner.Plosive, true)] = "ɢ",
        [(ConsonantPlace.Glottal, ConsonantManner.Plosive, false)] = "ʔ",

        // Nasals
        [(ConsonantPlace.Bilabial, ConsonantManner.Nasal, true)] = "m",
        [(ConsonantPlace.Labiodental, ConsonantManner.Nasal, true)] = "ɱ",
        [(ConsonantPlace.Dental, ConsonantManner.Nasal, true)] = "n̪",
        [(ConsonantPlace.Alveolar, ConsonantManner.Nasal, true)] = "n",
        [(ConsonantPlace.Retroflex, ConsonantManner.Nasal, true)] = "ɳ",
        [(ConsonantPlace.Palatal, ConsonantManner.Nasal, true)] = "ɲ",
        [(ConsonantPlace.Velar, ConsonantManner.Nasal, true)] = "ŋ",
        [(ConsonantPlace.Uvular, ConsonantManner.Nasal, true)] = "ɴ",

        // Trills
        [(ConsonantPlace.Bilabial, ConsonantManner.Trill, true)] = "ʙ",
        [(ConsonantPlace.Alveolar, ConsonantManner.Trill, true)] = "r",
        [(ConsonantPlace.Uvular, ConsonantManner.Trill, true)] = "ʀ",

        // Taps
        [(ConsonantPlace.Labiodental, ConsonantManner.Tap, true)] = "ⱱ",
        [(ConsonantPlace.Alveolar, ConsonantManner.Tap, true)] = "ɾ",
        [(ConsonantPlace.Retroflex, ConsonantManner.Tap, true)] = "ɽ",

        // Fricatives (non-sibilant)
        [(ConsonantPlace.Bilabial, ConsonantManner.Fricative, false)] = "ɸ",
        [(ConsonantPlace.Bilabial, ConsonantManner.Fricative, true)] = "β",
        [(ConsonantPlace.Labiodental, ConsonantManner.Fricative, false)] = "f",
        [(ConsonantPlace.Labiodental, ConsonantManner.Fricative, true)] = "v",
        [(ConsonantPlace.Dental, ConsonantManner.Fricative, false)] = "θ",
        [(ConsonantPlace.Dental, ConsonantManner.Fricative, true)] = "ð",
        [(ConsonantPlace.Palatal, ConsonantManner.Fricative, false)] = "ç",
        [(ConsonantPlace.Palatal, ConsonantManner.Fricative, true)] = "ʝ",
        [(ConsonantPlace.Velar, ConsonantManner.Fricative, false)] = "x",
        [(ConsonantPlace.Velar, ConsonantManner.Fricative, true)] = "ɣ",
        [(ConsonantPlace.Uvular, ConsonantManner.Fricative, false)] = "χ",
        [(ConsonantPlace.Uvular, ConsonantManner.Fricative, true)] = "ʁ",
        [(ConsonantPlace.Pharyngeal, ConsonantManner.Fricative, false)] = "ħ",
        [(ConsonantPlace.Pharyngeal, ConsonantManner.Fricative, true)] = "ʕ",
        [(ConsonantPlace.Glottal, ConsonantManner.Fricative, false)] = "h",
        [(ConsonantPlace.Glottal, ConsonantManner.Fricative, true)] = "ɦ",

        // Sibilants
        [(ConsonantPlace.Alveolar, ConsonantManner.Sibilant, false)] = "s",
        [(ConsonantPlace.Alveolar, ConsonantManner.Sibilant, true)] = "z",
        [(ConsonantPlace.Postalveolar, ConsonantManner.Sibilant, false)] = "ʃ",
        [(ConsonantPlace.Postalveolar, ConsonantManner.Sibilant, true)] = "ʒ",
        [(ConsonantPlace.Retroflex, ConsonantManner.Sibilant, false)] = "ʂ",
        [(ConsonantPlace.Retroflex, ConsonantManner.Sibilant, true)] = "ʐ",

        // Approximants
        [(ConsonantPlace.Labiodental, ConsonantManner.Approximant, true)] = "ʋ",
        [(ConsonantPlace.Alveolar, ConsonantManner.Approximant, true)] = "ɹ",
        [(ConsonantPlace.Retroflex, ConsonantManner.Approximant, true)] = "ɻ",
        [(ConsonantPlace.Palatal, ConsonantManner.Approximant, true)] = "j",
        [(ConsonantPlace.Velar, ConsonantManner.Approximant, true)] = "ɰ",

        // Laterals
        [(ConsonantPlace.Dental, ConsonantManner.Lateral, true)] = "l̪",
        [(ConsonantPlace.Alveolar, ConsonantManner.Lateral, true)] = "l",
        [(ConsonantPlace.Retroflex, ConsonantManner.Lateral, true)] = "ɭ",
        [(ConsonantPlace.Palatal, ConsonantManner.Lateral, true)] = "ʎ",
        [(ConsonantPlace.Velar, ConsonantManner.Lateral, true)] = "ʟ",

        // Affricates
        [(ConsonantPlace.Bilabial, ConsonantManner.Affricate, false)] = "pɸ",
        [(ConsonantPlace.Bilabial, ConsonantManner.Affricate, true)] = "bβ",
        [(ConsonantPlace.Labiodental, ConsonantManner.Affricate, false)] = "pf",
        [(ConsonantPlace.Labiodental, ConsonantManner.Affricate, true)] = "bv",
        [(ConsonantPlace.Dental, ConsonantManner.Affricate, false)] = "tθ",
        [(ConsonantPlace.Dental, ConsonantManner.Affricate, true)] = "dð",
        [(ConsonantPlace.Alveolar, ConsonantManner.Affricate, false)] = "ts",
        [(ConsonantPlace.Alveolar, ConsonantManner.Affricate, true)] = "dz",
        [(ConsonantPlace.Postalveolar, ConsonantManner.Affricate, false)] = "tʃ",
        [(ConsonantPlace.Postalveolar, ConsonantManner.Affricate, true)] = "dʒ",
        [(ConsonantPlace.Retroflex, ConsonantManner.Affricate, false)] = "ʈʂ",
        [(ConsonantPlace.Retroflex, ConsonantManner.Affricate, true)] = "ɖʐ",
        [(ConsonantPlace.Palatal, ConsonantManner.Affricate, false)] = "cç",
        [(ConsonantPlace.Palatal, ConsonantManner.Affricate, true)] = "ɟʝ",
        [(ConsonantPlace.Velar, ConsonantManner.Affricate, false)] = "kx",
        [(ConsonantPlace.Velar, ConsonantManner.Affricate, true)] = "ɡɣ",
        [(ConsonantPlace.Uvular, ConsonantManner.Affricate, false)] = "qχ",
        [(ConsonantPlace.Uvular, ConsonantManner.Affricate, true)] = "ɢʁ",

        // Clicks
        [(ConsonantPlace.Bilabial, ConsonantManner.Click, false)] = "ʘ",
        [(ConsonantPlace.Dental, ConsonantManner.Click, false)] = "ǀ",
        [(ConsonantPlace.Alveolar, ConsonantManner.Click, false)] = "ǃ",
        [(ConsonantPlace.Palatal, ConsonantManner.Click, false)] = "ǂ",
    };

    private static readonly Dictionary<(VowelHeight, VowelBackness, bool), string> s_vowels = new()
    {
        // Close
        [(VowelHeight.Close, VowelBackness.Front, false)] = "i",
        [(VowelHeight.Close, VowelBackness.Front, true)] = "y",
        [(VowelHeight.Close, VowelBackness.Central, false)] = "ɨ",
        [(VowelHeight.Close, VowelBackness.Central, true)] = "ʉ",
        [(VowelHeight.Close, VowelBackness.Back, false)] = "ɯ",
        [(VowelHeight.Close, VowelBackness.Back, true)] = "u",

        // Near-close
        [(VowelHeight.NearClose, VowelBackness.Front, false)] = "ɪ",
        [(VowelHeight.NearClose, VowelBackness.Front, true)] = "ʏ",
        [(VowelHeight.NearClose, VowelBackness.Back, true)] = "ʊ",

        // Close-mid
        [(VowelHeight.CloseMid, VowelBackness.Front, false)] = "e",
        [(VowelHeight.CloseMid, VowelBackness.Front, true)] = "ø",
        [(VowelHeight.CloseMid, VowelBackness.Central, false)] = "ɘ",
        [(VowelHeight.CloseMid, VowelBackness.Central, true)] = "ɵ",
        [(VowelHeight.CloseMid, VowelBackness.Back, false)] = "ɤ",
        [(VowelHeight.CloseMid, VowelBackness.Back, true)] = "o",

        // Mid
        [(VowelHeight.Mid, VowelBackness.Central, false)] = "ə",

        // Open-mid
        [(VowelHeight.OpenMid, VowelBackness.Front, false)] = "ɛ",
        [(VowelHeight.OpenMid, VowelBackness.Front, true)] = "œ",
        [(VowelHeight.OpenMid, VowelBackness.Central, false)] = "ɜ",
        [(VowelHeight.OpenMid, VowelBackness.Central, true)] = "ɞ",
        [(VowelHeight.OpenMid, VowelBackness.Back, false)] = "ʌ",
        [(VowelHeight.OpenMid, VowelBackness.Back, true)] = "ɔ",

        // Near-open
        [(VowelHeight.NearOpen, VowelBackness.Front, false)] = "æ",
        [(VowelHeight.NearOpen, VowelBackness.Central, false)] = "ɐ",

        // Open
        [(VowelHeight.Open, VowelBackness.Front, false)] = "a",
        [(VowelHeight.Open, VowelBackness.Front, true)] = "ɶ",
        [(VowelHeight.Open, VowelBackness.Back, false)] = "ɑ",
        [(VowelHeight.Open, VowelBackness.Back, true)] = "ɒ",
    };
}
