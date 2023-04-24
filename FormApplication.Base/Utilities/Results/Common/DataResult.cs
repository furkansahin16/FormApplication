namespace FormApplication.Base.Utilities.Results.Common
{
    public abstract class DataResult<T> : Result , IDataResult<T> where T : BaseEntity
    {
        public T Data { get; }
        public DataResult(T data, bool isSuccess) : base(isSuccess) => Data = data;
        public DataResult(T data, bool isSuccess, string message) : base(isSuccess, message) => Data = data;
    } 
}
