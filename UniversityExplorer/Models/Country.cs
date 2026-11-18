using System.Text.Json.Serialization;

namespace UniversityExplorer.Models
{
    // Stores the country information received from the API.
    public class Country
    {
        public string Name { get; set; } = string.Empty;

        public string? Capital { get; set; }

        public string Region { get; set; } = string.Empty;

        public long Population { get; set; }

        // Stores the country's flag information.
        public CountryFlags Flags { get; set; } = new CountryFlags();
    }

    public class CountryFlags
    {
        // Maps the API's "png" property to the Png property.
        [JsonPropertyName("png")]
        public string Png { get; set; } = string.Empty;
    }
}