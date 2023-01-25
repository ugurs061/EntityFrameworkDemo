using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)  // params ile birden fazla IResult verilebilme imkanı sağlıyor. 
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) // başarısız iş kuralını geri döndürme işlemi
                {
                    return logic;
                } 
            }

            return null;
        }
             
    }
}
