namespace FormApplication.DataAccess.Repositories.Concrete
{
    public class FieldRepository : EfRepository<Form>, IFieldRepository
    {
        public FieldRepository(FormAppDb context) : base(context) { }
    }
}
