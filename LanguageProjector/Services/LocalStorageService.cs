using System.Text.Json;
using LanguageProjector.Logic;
using Microsoft.JSInterop;

namespace LanguageProjector.Services;

public sealed class LocalStorageService
{
    private const string Key = "languages";
    private readonly IJSRuntime _js;

    public LocalStorageService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task<List<Language>> GetLanguagesAsync()
    {
        var json = await _js.InvokeAsync<string?>("localStorage.getItem", Key);
        if (string.IsNullOrEmpty(json))
            return [];

        return JsonSerializer.Deserialize<List<Language>>(json) ?? [];
    }

    public async Task SaveLanguagesAsync(List<Language> languages)
    {
        var json = JsonSerializer.Serialize(languages);
        await _js.InvokeVoidAsync("localStorage.setItem", Key, json);
    }
}
