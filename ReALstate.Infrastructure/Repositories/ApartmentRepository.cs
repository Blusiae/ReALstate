using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Repositories
{
    // ApartmentRepository implements IApartmentRepository interface and it is responsible for the CRUD operations of the Apartment entity. EstateDbContext is injected in the constructor
    internal class ApartmentRepository(EstatesDbContext dbContext) : IApartmentRepository
    {
        public async Task<int> Create(Apartment entity)
        {
            dbContext.Apartments.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(Apartment entity)
        {
            dbContext.Apartments.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Apartment>> GetAllAsync()
        {
            var apartments = await dbContext.Apartments.ToListAsync();
            return apartments;
        }

        public Task<Apartment?> GetByIdAsync(int id)
        {
            var apartment = dbContext.Apartments.FirstOrDefaultAsync(apartment => apartment.Id == id);
            return apartment;
        }

    }
}
