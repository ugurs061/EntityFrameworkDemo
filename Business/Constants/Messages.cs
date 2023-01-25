using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages // newlemeden kullanabilmek için static olarak kullanıldı
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed= "Ürünler listelendi";
        public static string ProductCountOfCategoryError= "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists= "Aynı isimde ürün bulunmaktadır.";
    }
}
