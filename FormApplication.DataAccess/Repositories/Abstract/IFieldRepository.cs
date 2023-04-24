using FormApplication.Base.DataAccess.Abstract;

namespace FormApplication.DataAccess.Repositories.Abstract
{
    public interface IFieldRepository : IAsyncRepository, IAsyncFindable<Form>, IAsyncInsertable<Form>, IAsyncOrderable<Form>, IAsyncQueryable<Form>, IAsyncDeletable<Form>
    {

    }
}
