using ReALstate.App.Data.Repositories.Interfaces;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;

namespace ReALstate.App.Data.Repositories
{
    internal abstract class Repository<TEntity>() : IRepository<TEntity> where TEntity : class, new()
    {
        protected SQLiteAsyncConnection? _conn;
        protected readonly string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "realstate.db");

        public async Task InitAsync()
        {
            if (_conn != null)
                return;

            _conn = new SQLiteAsyncConnection(_dbPath);
            await _conn.CreateTableAsync<TEntity>();
        }

        public virtual async Task CreateAsync(TEntity entity)
        {
            await InitAsync();
            await _conn!.InsertWithChildrenAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await InitAsync();
            var entity = await _conn!.GetAsync<TEntity>(id);

            if (entity != null)
                await _conn!.DeleteAsync(entity, true);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            await InitAsync();

            return await _conn!.Table<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            await InitAsync();

            return await _conn!.GetWithChildrenAsync<TEntity>(id);
        }
    }
}
