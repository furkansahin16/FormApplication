namespace FormApplication.Base.DataAccess.Abstract
{
    public interface IAsyncRepository
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

}
