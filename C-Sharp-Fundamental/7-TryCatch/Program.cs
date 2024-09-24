namespace _7_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı

            /*
                Try Catch hata yakalamakta kullanılan bir yapıdır.
                
                Hata => Hatalar 3 ana başlıkta toplanabilir.
                1 - Syntax Hataları (Genelde IDE yakalıyor ve daha derlemeden hatanın altını çiziyor.)
                2 - Runtime Sırasında Çıkacak Hatalar (Sıfıra bölme hataları, tip dönüşüm hataları, input output hataları vb.)
                3 - Mantık Hataları Programcılar tarafından yapılan hatalardır. Bulunması ve çözülmesi biraz daha zordur.
                Bu yüzden debug yapılarak çözümlenir.

                Kullanımı (Syntax'ı)
                
                      try
                      {
                         //Çalıştırılacak kodlar burada yer alır.
                      }
                      catch (Expection ex)
                      {
                         //Hata yakalandıktan sonra yapılacak işlemler burada yer alır.
                      }
                      finally
                      {
                         //Hata olsun olmasın mutlaka çalıştırılacak kod bloğu
                      }
             
             */

            #endregion

            #region Ornek - İki Sayıyı Bölme  Durumu
            /*
            try
            {
                int sayi1, sayi2;
                Console.WriteLine("Birinci sayıyı giriniz.");
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz.");
                sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Bölümü: {sayi1/sayi2}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölme hatası" + ex.Message);
                //Attempted to divide by zero. Sıfıra bölme hatası
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Düzgün formatta sayı girin" + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Veri tipinin alabileceği değerin altında veya üstünde girdiniz."+ex.Message);
            }
            catch (Exception ex) //Burada exception ile hata yakalanacaksa mutlaka en sona koyun
            {
                Console.WriteLine("Bilinmeyen Hata");
            } */
            #endregion

            #region Ornek - Kontrollü Sayı Çevirilmesi

            int sayi1, sayi2;
            float fsayi;
            double dsayi;
            DateTime trh;

            bool sonuc1, sonuc2;

            Console.WriteLine("Birinci sayıyı giriniz.");
            sonuc1 = int.TryParse(Console.ReadLine(), out sayi1);

            Console.WriteLine("İkinci sayıyı giriniz.");
            sonuc2 = int.TryParse(Console.ReadLine(), out sayi2);

            if (sonuc1 == true && sonuc2 == true)
            { Console.WriteLine($"Toplam: {sayi1 + sayi2}"); }

            sonuc1 = float.TryParse(Console.ReadLine(), out fsayi);
            Console.WriteLine($"Float: {fsayi.ToString("0.00")}");

            sonuc1 = double.TryParse(Console.ReadLine(), out dsayi);
            Console.WriteLine($"Deciamal: {dsayi.ToString("0.00")}");

            sonuc1 = DateTime.TryParse("01.01.2000", out trh);
            Console.WriteLine($"DateTime: {trh}");

            #endregion

        }
    }
}
