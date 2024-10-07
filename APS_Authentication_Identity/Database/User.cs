using Microsoft.AspNetCore.Identity;

namespace APS_Authentication_Identity.Database
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
