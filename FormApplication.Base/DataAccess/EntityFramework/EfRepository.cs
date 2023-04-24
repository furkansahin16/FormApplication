using System.Linq.Expressions;

namespace FormApplication.Base.DataAccess.EntityFramework
{
    public class EfRepository<TEntity> : IAsyncDeletable<TEntity>, IAsyncFindable<TEntity>, IAsyncInsertable<TEntity>, IAsyncOrderable<TEntity>, IAsyncQueryable<TEntity>, IAsyncRepository
        where TEntity : BaseEntity
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _table;

        public EfRepository(DbContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var entry = await _table.AddAsync(entity);
            return entry.Entity;
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            return filter is null ? _table.AnyAsync() : _table.AnyAsync(filter);
        }

        public Task DeleteAsync(TEntity entity)
        {
            return Task.FromResult(_table.Remove(entity));
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = false)
        {
            return await GetAll(tracking).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter, bool tracking = false)
        {
            return await GetAll(tracking).Where(filter).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool orderDesc = false, bool tracking = false)
        {
            var values = GetAll(tracking);
            return orderDesc ? await values.OrderByDescending(orderBy).ToListAsync() : await values.OrderBy(orderBy).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> orderBy, bool orderDesc = false, bool tracking = false)
        {
            var values = GetAll(tracking).Where(filter);
            return orderDesc ? await values.OrderByDescending(orderBy).ToListAsync() : await values.OrderBy(orderBy).ToListAsync();
        }

        public Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter, bool tracking = false)
        {
            return GetAll(tracking).FirstOrDefaultAsync(filter);
        }

        public Task<TEntity?> GetByIdAsync(Guid id, bool tracking = false)
        {
            return GetAll(tracking).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
        protected IQueryable<TEntity> GetAll(bool tracking = false)
        {
            return tracking ? _table : _table.AsNoTracking();
        }
    }
}
