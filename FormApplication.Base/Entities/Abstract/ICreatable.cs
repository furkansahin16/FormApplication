namespace FormApplication.Base.Entities.Abstract
{
    public interface ICreatable : IEntity
    {
        Guid CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
