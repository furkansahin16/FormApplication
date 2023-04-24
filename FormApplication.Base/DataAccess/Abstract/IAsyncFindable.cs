
using System.Linq.Expressions;

namespace FormApplication.Base.DataAccess.Abstract
{
    public interface IAsyncFindable<TEntity> : IAsyncQueryable<TEntity>, IAsyncRepository where TEntity : BaseEntity
    {
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter, bool tracking = false);
        Task<TEntity?> GetByIdAsync(Guid id, bool tracking = false);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? filter = null);
    }

}
