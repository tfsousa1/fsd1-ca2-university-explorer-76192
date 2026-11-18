
using System.Net.Http.Json;
using UniversityExplorer.Models;

namespace UniversityExplorer.Services
{
    // Handles requests to the Student Application API.
    public class StudentApplicationService
    {
        // Stores the HttpClient used to communicate with the API.
        private readonly HttpClient _httpClient;

        // Stores the base URL of the Student Application API.
        private readonly string _apiUrl =
            "https://edutots.net/api/studentapplication";

        // Receives HttpClient through dependency injection.
        public StudentApplicationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Retrieves all student applications from the API.
        public async Task<List<StudentApplication>> GetApplicationsAsync()
        {
            // Sends a GET request and converts the JSON response into application objects.
            var applications = await _httpClient.GetFromJsonAsync<List<StudentApplication>>(
                _apiUrl);

            // Returns the applications or an empty list if the response is null.
            return applications ?? new List<StudentApplication>();
        }

        // Creates a new student application using a POST request.
        public async Task<HttpResponseMessage> CreateApplicationAsync(
            StudentApplication application)
        {
            // Sends the application data as JSON to the API.
            var response = await _httpClient.PostAsJsonAsync(
                _apiUrl, application);

            // Returns the API response so the calling page can check the result.
            return response;
        }

        // Updates an existing student application using a PUT request.
        public async Task<HttpResponseMessage> UpdateApplicationAsync(
            int id, StudentApplication application)
        {
            // Builds the URL using the application ID.
            string url = _apiUrl + "/" + id;

            // Sends the updated application data as JSON to the API.
            var response = await _httpClient.PutAsJsonAsync(
                url, application);

            // Returns the API response so the calling page can check the result.
            return response;
        }
    }
}
