
using System.Net.Http.Json;
using UniversityExplorer.Models;

namespace UniversityExplorer.Services
{
    // Handles requests to the Countries API.
    public class CountryService
    {
        // Stores the HttpClient used to communicate with the API.
        private readonly HttpClient _httpClient;

        // Receives HttpClient through dependency injection.
        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Sends a GET request and converts the JSON response into a list of Country objects.
        public async Task<List<Country>> GetCountriesAsync()
        {
            // Waits for the API response and converts the JSON data.
            var countries = await _httpClient.GetFromJsonAsync<List<Country>>(
                "https://countries.dev/countries");

            // Returns the countries or an empty list if the response is null.
            return countries ?? new List<Country>();
        }
    }
}
