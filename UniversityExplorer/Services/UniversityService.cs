
using System.Net.Http.Json;
using UniversityExplorer.Models;

namespace UniversityExplorer.Services
{
    // Handles requests to the Universities API.
    public class UniversityService
    {
        // Stores the HttpClient used to communicate with the API.
        private readonly HttpClient _httpClient;

        // Receives HttpClient through dependency injection.
        public UniversityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Retrieves universities for the selected country.
        public async Task<List<University>> GetUniversitiesAsync(string country)
        {
            // Encodes the country name so it can be safely used in the URL.
            string url = "http://universities.hipolabs.com/search?country="
                + Uri.EscapeDataString(country);

            // Sends a GET request and converts the JSON response into University objects.
            var universities = await _httpClient.GetFromJsonAsync<List<University>>(url);

            // Returns the universities or an empty list if the response is null.
            return universities ?? new List<University>();
        }
    }
}
