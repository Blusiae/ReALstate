using ReALstate.Domain.Entities;

namespace ReALstate.Domain.Interfaces.Repositories
{
    public interface IUserRepository 
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User?> GetByIdAsync(Guid id);
        Task<Guid> Create(User entity);
        Task Delete(User entity);
    }
}
