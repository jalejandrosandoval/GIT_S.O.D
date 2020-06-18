using Microsoft.AspNetCore.Identity;

namespace API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Username { get; set; }

        public string UserPassword { get; set; }

    }
}
