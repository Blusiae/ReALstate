using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;

namespace ReALstate.Infrastructure.DbContext
{
    internal class EstatesDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        internal DbSet<Estate> Estates { get; set; }
        internal DbSet<EstateOwner> EstateOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estate>()
                .OwnsOne(estate => estate.Address);

            modelBuilder.Entity<EstateOwner>()
                .HasMany(owner => owner.Estates)
                .WithOne()
                .HasForeignKey(estate => estate.OwnerId);


        }
    }
}
