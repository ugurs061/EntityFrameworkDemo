using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity) 
        {
            var context = new ValidationContext<object>(entity); // doğrulama yapılacak tipin belirtilmesi 
            var result = validator.Validate(context); // doğrulama işlemi
            if (!result.IsValid) // sonuç geçerli değilse hata verir
            {
                throw new ValidationException(result.Errors);
            }
        }
        
    }
}
