using FormApplication.Base.DataAccess.Abstract;

namespace FormApplication.DataAccess.Repositories.Abstract
{
    public interface IFormRepository : IAsyncRepository, IAsyncFindable<Form>, IAsyncInsertable<Form>, IAsyncOrderable<Form>, IAsyncQueryable<Form>, IAsyncDeletable<Form>
    {

    }
}
