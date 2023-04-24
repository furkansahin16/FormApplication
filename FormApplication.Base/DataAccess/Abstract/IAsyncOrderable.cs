
using System.Linq.Expressions;

namespace FormApplication.Base.DataAccess.Abstract
{
    public interface IAsyncOrderable<TEntity> : IAsyncQueryable<TEntity>, IAsyncRepository where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, TKey>> orderBy, bool orderDesc = false, bool tracking = false);
        Task<IEnumerable<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> orderBy, bool orderDesc = false, bool tracking = false);
    }

}
