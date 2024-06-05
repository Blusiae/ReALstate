using ReALstate.Domain.Entities;

namespace ReALstate.Domain.Interfaces.Repositories
{
    public interface IEstateRepository
    {
        Task<IEnumerable<Estate>> GetAllAsync();
        Task<Estate?> GetByIdAsync(int id);
        Task<int> Create(Estate estate);
        Task Delete(Estate estate);
        Task SaveChanges();
    }
}
