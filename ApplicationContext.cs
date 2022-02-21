using Diploma.Domains;
using Microsoft.EntityFrameworkCore;

namespace Diploma
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Client> Clients { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=diploma;Username=poscan;Password=ad221100");
        }
    }
}
