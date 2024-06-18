namespace ReALstate.Domain.Interfaces.Repositories.Base
{
    // Base Repository Interface for all Repositories. Contains basic actions for all entities. Its inherited by all other repositories.
    public interface IBaseRepository <T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task<int> Create(T entity);
        Task Delete(T entity);
    }
}
