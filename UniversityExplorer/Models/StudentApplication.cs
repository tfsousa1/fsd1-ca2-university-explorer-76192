
using System.ComponentModel.DataAnnotations;

namespace UniversityExplorer.Models
{
    // Stores student application information and validates form data.
    public class StudentApplication
    {
        // Stores the application ID returned by the API.
        public int Id { get; set; }

        // Stores and validates the student's name.
        [Required(ErrorMessage = "Student name is required.")]
        public string StudentName { get; set; } = string.Empty;

        // Stores and validates the student's email address.
        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        // Stores and validates the selected country.
        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = string.Empty;

        // Stores and validates the selected university.
        [Required(ErrorMessage = "University name is required.")]
        public string University { get; set; } = string.Empty;

        // Stores and validates the selected course.
        [Required(ErrorMessage = "Course name is required.")]
        public string Course { get; set; } = string.Empty;

        // Stores the personal statement returned by the API.
        public string PersonalStatement { get; set; } = string.Empty;
    }
}
