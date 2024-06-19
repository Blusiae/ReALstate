using Microsoft.EntityFrameworkCore;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Domain.Interfaces.Repositories.Base;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Repositories
{
    // UserRepository class that implements IUserRepository interface. Contains CRUD operations for the User entity.
    // EstatesDbContext is injected in the constructor
    internal class UserRepository(EstatesDbContext dbContext) : IUserRepository
    {
        public async Task<Guid> Create(User entity)
        {
            dbContext.Users.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task Delete(User entity)
        {
            dbContext.Users.Remove(entity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var user = await dbContext.Users.FirstOrDefaultAsync(o => o.Id == id);
            return user;
        }

    }
}
