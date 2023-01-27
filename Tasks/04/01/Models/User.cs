using _01.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace _01.Models
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
        public DateTime LastLoginTime { get; set; }
        public DateTime RegistrationTime { get; set; }
        public Status Status { get; set; }
    }
}
