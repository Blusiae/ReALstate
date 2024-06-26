﻿using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Repositories
{
    // EstateRepository implements IEstateRepository interface and it is responsible for the CRUD operations of the Estate entity. EstateDbContext is injected in the constructor
    internal class EstateRepository(EstatesDbContext dbContext) : IEstateRepository
    {

        public async Task<int> Create(Estate estate)
        {
            dbContext.Estates.Add(estate);
            await dbContext.SaveChangesAsync();
            return estate.Id;
        }

        public async Task Delete(Estate estate)
        {
            dbContext.Estates.Remove(estate);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Estate>> GetAllAsync()
        {
            return await dbContext.Estates.ToListAsync();
        }

        public async Task<Estate?> GetByIdAsync(int id)
        {
            return await dbContext.Estates.FirstOrDefaultAsync(estate => estate.Id == id);
        }

    }
}
