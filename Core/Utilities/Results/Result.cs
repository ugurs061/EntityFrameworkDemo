namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)// this ile; iki ctor da çalıştırıldı.
        {
            Message = message;
        }
        public Result(bool success)// mesaj döndürmesini istemiyor olabiliriz diye overloading yapıldı.
        {
            Success = success;
        }
        // result değerlerini ctor ile setlenebilir yaptık
        public bool Success { get; }

        public string Message { get; }
    }
}
