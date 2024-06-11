using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Repositories
{
    internal class HouseRepository
        (EstatesDbContext dbContext): IHouseRepository
    {
        public async Task<int> Create(House entity)
        {
           dbContext.Houses.Add(entity);
           await dbContext.SaveChangesAsync();
           return entity.Id;
        }

        public async Task Delete(House entity)
        {
            dbContext.Houses.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<House>> GetAllAsync()
        {
            return await dbContext.Houses.ToListAsync();
        }

        public async Task<House?> GetByIdAsync(int id)
        {
            var house = await dbContext.Houses.FirstOrDefaultAsync(house => house.Id == id);
            return house;
        }
    }
}
