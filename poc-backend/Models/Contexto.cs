using Microsoft.EntityFrameworkCore;

namespace poc_backend.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(p => p.Address);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
    }

}