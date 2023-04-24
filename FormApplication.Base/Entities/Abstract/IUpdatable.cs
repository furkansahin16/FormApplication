namespace FormApplication.Base.Entities.Abstract
{
    public interface IUpdatable : IEntity
    {
        string UpdatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
