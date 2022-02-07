using Diploma.Domains;
using Microsoft.EntityFrameworkCore;

namespace Diploma
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<Meetup> Meetups { get; set; }
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
