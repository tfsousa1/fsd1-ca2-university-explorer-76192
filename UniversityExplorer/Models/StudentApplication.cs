
using System.Text.Json.Serialization;

namespace UniversityExplorer.Models
{
    // Stores student application information received from the API.
    public class StudentApplication
    {
        public int Id { get; set; }

        public string StudentName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string University { get; set; } = string.Empty;

        public string Course { get; set; } = string.Empty;

        public string PersonalStatement { get; set; } = string.Empty;
    }
}
