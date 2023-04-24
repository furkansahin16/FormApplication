namespace FormApplication.Base.DataAccess.Abstract
{
    public interface IAsyncDeletable<TEntity> : IAsyncRepository where TEntity : BaseEntity
    {
        Task DeleteAsync(TEntity entity);
    }

}
