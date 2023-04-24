namespace FormApplication.Base.Entities.Abstract
{
    public interface IUpdatable : IEntity
    {
        Guid UpdatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
