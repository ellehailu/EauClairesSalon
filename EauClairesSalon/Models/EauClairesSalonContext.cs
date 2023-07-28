using Microsoft.EntityFrameworkCore;

namespace EauClairesSalon.Models
{
    public class EauClairesSalonContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Stylist> Stylists { get; set; }

        public EauClairesSalonContext(DbContextOptions options) : base(options) { }
    }
}