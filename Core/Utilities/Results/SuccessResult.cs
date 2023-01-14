namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) // başarılı mesajı tanımladık. base(Result 'ı ifade eder.)
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
