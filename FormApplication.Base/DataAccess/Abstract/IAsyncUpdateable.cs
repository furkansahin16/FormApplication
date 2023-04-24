namespace FormApplication.Base.DataAccess.Abstract
{
    public interface IAsyncUpdateable<TEntity> : IAsyncRepository where TEntity : BaseEntity
    {
        Task<TEntity> UpdateAsync(TEntity entity);
    }

}
