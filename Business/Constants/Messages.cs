using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages // newlemeden kullanabilmek için static olarak kullanıldı
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün bulunmaktadır.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklenmiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarıyla giriş yapıldı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated= "Token oluşturuldu.";
        public static string ProductUpdated = "Ürün güncellendi.";
    }
}
