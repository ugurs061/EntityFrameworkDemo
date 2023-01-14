namespace Core.Utilities.Results
{// hem data hem de mesaj döndürmeye yarar.
    public interface IDataResult<T> : IResult// T: hangi tipi döndüreceğini belirtir. IResult: Mesaj ve sonucu IResult zaten içeriyor tekrar yazmamak adına eklendi.
    {
        T Data { get; }
    }
}
