using Microsoft.EntityFrameworkCore;
using StakeApp.Data.Entities;

namespace StakeApp.Data.DatabaseContexts.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Property> Properties { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}