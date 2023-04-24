namespace FormApplication.Base.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T> where T : BaseEntity
    {
        public ErrorDataResult(T data) : base(data, false) { }
        public ErrorDataResult(T data, string message) : base(data,false,message) { }
    }
}
