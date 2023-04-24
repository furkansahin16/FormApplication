namespace FormApplication.Base.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T> where T : BaseEntity
    {
        public SuccessDataResult(T data) : base(data, true) { }
        public SuccessDataResult(T data, string message) : base(data,true,message) { }
    }
}
