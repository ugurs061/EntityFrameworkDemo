namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success,message)// base'e Success ve Message ı yollar
        {
            Data= data;
        }
        public DataResult(T data, bool success):base(success) // base'e sadece success gönderir
        {
            Data= data;
        }

        public T Data { get; }
    }
}
