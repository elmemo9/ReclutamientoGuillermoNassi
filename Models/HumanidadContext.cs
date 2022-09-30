using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ReclutamientoGuillermoNassi.Models
{
    public class HumanidadContext : DbContext
    {
        public HumanidadContext(DbContextOptions<HumanidadContext> options)
            : base(options)
        {

        }
        public DbSet<Humano> Humanos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Humano>().ToTable("Humano");
        }
    }
}
