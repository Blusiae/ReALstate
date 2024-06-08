using ReALstate.Domain.Entities;

namespace ReALstate.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task<int> Create(Customer owner);
        Task Delete(Customer owner);
        Task SaveChanges();
    }
}
