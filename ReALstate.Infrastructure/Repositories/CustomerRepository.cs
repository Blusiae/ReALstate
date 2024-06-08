﻿using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Repositories
{
    internal class CustomerRepository(EstatesDbContext dbContext) : ICustomerRepository
    {
        public async Task<int> Create(Customer owner)
        {
            dbContext.Customers.Add(owner);
            await SaveChanges();
            return owner.Id;
        }

        public async Task Delete(Customer owner)
        {
            dbContext.Customers.Remove(owner);
            await SaveChanges();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await dbContext.Customers.Include(owner => owner.Estates).ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await dbContext.Customers.Include(owner => owner.Estates).FirstOrDefaultAsync(owner => owner.Id == id);
        }

        public async Task SaveChanges()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
