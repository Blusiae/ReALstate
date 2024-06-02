using ReALstate.Domain.Entities;

namespace ReALstate.Domain.Interfaces.Repositories
{
    public interface IEstateOwnerRepository
    {
        Task<IEnumerable<EstateOwner>> GetAllAsync();
        Task<EstateOwner?> GetByIdAsync(int id);
        Task<int> Create(EstateOwner owner);
        Task Delete(EstateOwner owner);
        Task SaveChanges();
    }
}
