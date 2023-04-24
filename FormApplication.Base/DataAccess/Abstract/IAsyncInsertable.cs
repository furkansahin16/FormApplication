namespace FormApplication.Base.DataAccess.Abstract
{
    public interface IAsyncInsertable<TEntity> : IAsyncRepository where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);
    }

}
