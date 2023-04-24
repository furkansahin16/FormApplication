namespace FormApplication.Base.Entities.Abstract
{
    public interface ISoftDeletable : IEntity
    {
        Guid DeletedBy { get; set; }
        DateTime DeletedAt { get; set; }
    }
}
