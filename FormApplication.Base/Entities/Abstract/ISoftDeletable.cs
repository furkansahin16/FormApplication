namespace FormApplication.Base.Entities.Abstract
{
    public interface ISoftDeletable : IEntity
    {
        string DeletedBy { get; set; }
        DateTime DeletedAt { get; set; }
    }
}
