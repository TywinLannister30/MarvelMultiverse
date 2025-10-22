using MarvelMultiverse.Models;

namespace MarvelMultiverse.FrontEnd.Services
{
    public class MarvelApiClient(HttpClient http)
    {
        private readonly HttpClient _http = http;

        public async Task<Character?> GetCharacterAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;
            try
            {
                return await _http.GetFromJsonAsync<Character>($"/api/v1/character/{Uri.EscapeDataString(name)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"MarvelApiClient error: {ex.Message}");
                return null;
            }
        }

        public async Task<List<string>?> GetCharacterNamesAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<string>>($"/api/v1/character/name");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"MarvelApiClient error: {ex.Message}");
                return null;
            }
        }
    }
}
