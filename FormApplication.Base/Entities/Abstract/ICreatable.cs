namespace FormApplication.Base.Entities.Abstract
{
    public interface ICreatable : IEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
