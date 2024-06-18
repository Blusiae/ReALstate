using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Repositories
{
    // OfferRepository implements IOfferRepository interface and it is responsible for the CRUD operations of the Offer entity. EstateDbContext is injected in the constructor
    internal class OfferRepository(EstatesDbContext dbContext) : IOfferRepository
    {
        public async Task<int> Create(Offer entity)
        {
            dbContext.Offers.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(Offer entity)
        {
            dbContext.Offers.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Offer>> GetAllAsync()
        {
            return await dbContext.Offers.ToListAsync();
        }

        public async Task<Offer?> GetByIdAsync(int id)
        {
            var offer = await dbContext.Offers.FirstOrDefaultAsync(o => o.Id == id);
            return offer;
        }
    }
}
