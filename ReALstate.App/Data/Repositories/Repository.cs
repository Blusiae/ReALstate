using SQLite;

namespace ReALstate.App.Data.Repositories
{
    internal abstract class Repository<TEntity>(string dbPath) : IRepository<TEntity> where TEntity : class, new()
    {
        private SQLiteAsyncConnection? _conn;

        private async Task InitAsync()
        {
            if (_conn != null)
                return;

            _conn = new SQLiteAsyncConnection(dbPath);
            await _conn.CreateTableAsync<TEntity>();
        }

        public async Task<bool> CreateAsync(TEntity entity)
        {
            await InitAsync();
            return await _conn!.InsertAsync(entity) > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await InitAsync();
            var entity = await _conn!.GetAsync<TEntity>(id);

            if (entity != null)
                return await _conn!.DeleteAsync(entity) > 0;

            return true;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            await InitAsync();

            return await _conn!.Table<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            await InitAsync();

            return await _conn!.GetAsync<TEntity>(id);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
