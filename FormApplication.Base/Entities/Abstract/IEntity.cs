namespace FormApplication.Base.Entities.Abstract
{
    public interface IEntity
    {
        Guid Id { get; set; }
        Status Status { get; set; }
    }
}
