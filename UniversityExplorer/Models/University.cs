
using System.Text.Json.Serialization;

namespace UniversityExplorer.Models
{
    // Stores university information received from the API.
    public class University
    {
        public string Name { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public List<string> Domains { get; set; } = new List<string>();

        [JsonPropertyName("web_pages")]
        public List<string> WebPages { get; set; } = new List<string>();

        [JsonPropertyName("state-province")]
        public string? StateProvince { get; set; }

        [JsonPropertyName("alpha_two_code")]
        public string AlphaTwoCode { get; set; } = string.Empty;
    }
}
