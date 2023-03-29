using System.ComponentModel.DataAnnotations;

namespace WebAPI_Test.Models
{
    public class UserInformation
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        public int? Age { get; set; }
    }
}
