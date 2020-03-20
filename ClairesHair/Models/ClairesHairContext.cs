using Microsoft.EntityFrameworkCore;

namespace ClairesHair.Models
{
    public class ClairesHairContext : DbContext
    {
        public DbSet<Stylist> Stylist { get; set; }
        public DbSet<Clients> Clients { get; set; }

        public ClairesHairContext(DbContextOptions options) : base(options) { }
    }
}