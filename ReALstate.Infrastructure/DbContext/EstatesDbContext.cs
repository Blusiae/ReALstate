using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;

namespace ReALstate.Infrastructure.DbContext
{
    // DbContext class for the application database 
    internal class EstatesDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        // DbSet properties for the entities determining the tables in the database
        internal DbSet<Estate> Estates { get; set; }
        internal DbSet<House> Houses { get; set; }
        internal DbSet<Apartment> Apartments { get; set; }
        internal DbSet<Customer> Customers { get; set; }
        internal DbSet<Offer> Offers { get; set; }

        // Overriding the OnModelCreating method to configure the relationships between the entities
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estate>()
                .OwnsOne(estate => estate.Address);

            modelBuilder.Entity<Customer>()
                .HasMany(owner => owner.Estates)
                .WithOne()
                .HasForeignKey(estate => estate.OwnerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Customer>()
                .HasMany(customer => customer.Offers)
                .WithOne()
                .HasForeignKey(offer => offer.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Offer>()
                .HasOne(offer => offer.Estate)
                .WithMany()
                .HasForeignKey(offer => offer.EstateId)
                .OnDelete(DeleteBehavior.NoAction);



        }
    }
}
