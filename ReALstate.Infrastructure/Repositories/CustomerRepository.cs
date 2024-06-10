using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Repositories
{
    internal class CustomerRepository(EstatesDbContext dbContext) : ICustomerRepository
    {
        public async Task<int> Create(Customer customer)
        {
            dbContext.Customers.Add(customer);
            await dbContext.SaveChangesAsync();
            return customer.Id;
        }

        public async Task Delete(Customer customer)
        {
            dbContext.Customers.Remove(customer);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await dbContext.Customers
                .Include(customer => customer.Estates)
                .Include(customer => customer.Offers)
                .ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await dbContext.Customers.Include(customer => customer.Estates).FirstOrDefaultAsync(customer => customer.Id == id);
        }

    }
}
