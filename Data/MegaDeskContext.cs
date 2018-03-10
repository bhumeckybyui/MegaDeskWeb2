using MegaDeskWeb.Models;
using Microsoft.EntityFrameworkCore; 

namespace MegaDeskWeb.Data 
{
    
    public class MegaDeskContext : DbContext

    {
        public MegaDeskContext(DbContextOptions<MegaDeskContext> options) : base(options)
        {
            
        }


        public DbSet<Material> Material { get; set; }
        public DbSet<Desk> Desk { get; set; }
        public DbSet<ShippingTime> ShippingTime { get; set; }
        public DbSet<Quote> Quote { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Material>().ToTable("Material");
            modelBuilder.Entity<Desk>().ToTable("Desk");
            modelBuilder.Entity<ShippingTime>().ToTable("ShippingTime");
            modelBuilder.Entity<Quote>().ToTable("Quote");

        }

    }   
}

