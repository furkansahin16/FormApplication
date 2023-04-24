namespace FormApplication.Base.Utilities.Results.Abstract
{
    public interface IDataResult<T> :IResult where T : BaseEntity
    {
        T Data { get; }
    }
}
