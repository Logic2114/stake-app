using Microsoft.AspNetCore.Identity;

namespace StakeApp.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set;}
    }
}