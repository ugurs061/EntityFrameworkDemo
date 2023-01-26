namespace Core.Utilities.Security.JWT
{
    public class AccessToken // erişim anahtarı
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } // token bitiş süresi
    }
}
