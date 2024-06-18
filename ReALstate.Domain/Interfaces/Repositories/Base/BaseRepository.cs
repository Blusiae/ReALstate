using ReALstate.Domain.Entities;

namespace ReALstate.Domain.Interfaces.Repositories.Base
{
    public interface IBaseRepository <T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<int> Create(T entity);
        Task Delete(T entity);
    }
}
