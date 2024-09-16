namespace _8_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı
            /*
             try catch hata yakalamakta kullanılan bir yapıdır.

             Hata => Hatalar 3 ana başılkta toplanabilir.
               1- Syntax hataları (Genelde IDE yakalıyor ve daha derlemeden hatanın altını çiziyor.)
               2- Runtime sırasında çıkacak hatalar => Çalışma zamanı hataları, sıfıra bölme hataları, tip dönüşüm hataları olabilir.
               Inout Output hataları v.b.
               3- Mantık Hataları => Programcılar tarafından yapılan hatalardır. Bulunması ve çözülmesi biraz daha zordur.
               Debug yapılarak çözümlenir.

             Kullanımı :
             try
             {
               //Çalıştıralacak kodlar buraya
             }
             catch
             {
                // Hata yakalandıktan sonra yapılacak işlemler.
             }
             finally
             {
               // Hata olsun olmasın mutlaka buraya girecek
             }
             */
            #endregion
            #region Örnek - İki sayıyı bölme durumu
            try
            {
                int sayi1, sayi2;
                Console.WriteLine("Birinci sayıyı giriniz.");
                sayi1= int.Parse(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz.");
                sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Bolum:{sayi1/sayi2}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra Bölme Hatası Oluştu.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Uygun Sayı Değeri Giriniz.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Taşma Hatası, Çok Büyük Sayı Girdiniz.");
            }
            #endregion
        }
    }
}
