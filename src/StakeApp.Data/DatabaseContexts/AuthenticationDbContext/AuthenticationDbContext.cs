using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StakeApp.Data.Entities;

namespace StakeApp.Data.DatabaseContexts.AuthenticationDbContext
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
            : base(options)
        {

        }    
    }
}