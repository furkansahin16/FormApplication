namespace FormApplication.DataAccess.Repositories.Concrete
{
    public class FormRepository : EfRepository<Form>, IFormRepository
    {
        public FormRepository(FormAppDb context) : base(context) { }
    }
}
