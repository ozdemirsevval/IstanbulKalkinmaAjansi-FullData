using System;
namespace SwitchCase;

class Program
{
    static void Main(string[] args)
    {
        #region Haftanın Günleri 
        /*
        Console.WriteLine("Bulunduğunuz günün nümerik değerini giriniz.");
        int gun = Convert.ToInt32(Console.ReadLine());
        
        switch (gun)
        {
            case 1: Console.WriteLine("Pazartesi");
                break;
            case 2: Console.WriteLine("Salı");
                break;
            case 3: Console.WriteLine("Çarşamba");
                break;
            case 4: Console.WriteLine("Perşembe");  
                break;
            case 5: Console.WriteLine("Cuma");
                break;
            case 6: Console.WriteLine("Cumartesi");
                break;
            case 7: Console.WriteLine("Pazar");
                break;
            default: 
                Console.WriteLine("[1-7] arasında değer giriniz.");
                break;
        } */
        #endregion
        #region Örnek: Kullanıcıdan Mevsim değeri alınız ve aylarını ekrana yazdırın.
        /*
        Console.WriteLine("Mevsim giriniz.");
        string mevsim = Console.ReadLine().ToLower();

        switch (mevsim) 
        {
            case "Kış": Console.WriteLine("Aralık,Ocak,Şubat");
                break;
            case "İlkbahar":
                Console.WriteLine("Mart,Nisan,Mayıs");
                break;
            case "Yaz":
                Console.WriteLine("Haziran,Temmuz,Ağustos");
                break;
            case "Sonbahar":
                Console.WriteLine("Eylül,Ekim,Kasım");
                break;
            default: 
                Console.WriteLine("Uygun mevsim değeri giriniz.");
                break;
        } */
        #endregion
        #region Örnek: Ekrandan Rol okutun Eğer admin girildiyse admin sayfasına yönlendiriliyorsunuz.
        // satış girildiyse satış sayfasına yönlendiriliyorsunuz
        // üye girildiyse üye sayfasına yönlendiriliyorsunuz mesajını verecek switch case yapısı kurunuz.
        /*
        Console.WriteLine("giriş rol tipinizi giriniz.");
        string rol = Console.ReadLine().ToLower();

        switch (rol) 
        {
            case "admin":
                Console.WriteLine("Admin sayfasına yönlendiriliyorsunuz.");
                break;
            case "satış":
                Console.WriteLine("Satış sayfasına yönlendiriliyorsunuz.");
                break;
            case "üye":
                Console.WriteLine("Üye sayfasına yönlendiriliyorsunuz.");
                break;
            default:
                Console.WriteLine("Geçersiz değer girdiniz, tekrar deneyiniz.");
                break;
        } */
        #endregion
        #region Kullanıcı adı ve şifre okutun. Her ikisi de doğru ise "Hoşgeldin admin" mesajı
        //girilen bilgilerden hangisi yanlış ise onu açıkça yazdırsın.
        
        Console.WriteLine("Username giriniz:");
        string username = Console.ReadLine().ToLower();
        Console.WriteLine("Password giriniz:");
        string password = Console.ReadLine().ToLower();

        switch (username)
        {
            case "admin":
                switch (password) 
                {
                    case "admin":
                        Console.WriteLine("Giriş başarılı,Hoşgeldin Admin");
                    break;
                    default:
                        Console.WriteLine("username doğru, şifre yanlış");
                    break;
                }
            break;
            default: 
                switch (password) 
                {
                    case "admin":
                        Console.WriteLine("Şifre doğru, kullanıcı adı yanlış");
                    break;
                    default:
                        Console.WriteLine("girilen değerlerin ikisi de yanlış");
                    break;
                }
            break;
        }
        #endregion



    }

}
