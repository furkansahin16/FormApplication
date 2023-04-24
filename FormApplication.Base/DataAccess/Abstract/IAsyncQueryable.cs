
using System.Linq.Expressions;

namespace FormApplication.Base.DataAccess.Abstract
{
    public interface IAsyncQueryable<TEntity> : IAsyncRepository where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = false);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter, bool tracking = false);
    }

}
