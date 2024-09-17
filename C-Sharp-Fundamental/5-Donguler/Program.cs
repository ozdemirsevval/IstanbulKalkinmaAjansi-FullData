using System;
using System.Diagnostics.Tracing;
namespace _5_Donguler;

class Program
{
    static void Main(string[] args)
    {
        #region Konu Anlatımı
        /*
           3 adet döngümüz var : For,While,Do-While

           *** Foreach döngü değildir. İterasyondur, yani foreach çalışabilmesi 
           için mutlaka elimizde bir dataset olması gerekir. 
           Yani ya bir dizi olacak ya da bir liste v.b. bir dataset olacak 
         */
        #endregion

        #region ForDongusu
        /*
          For döngüsü için bir başlangıç değeri gerekir, 
          bir koşul olacak ve artım miktarı.
          
          Syntax of For : for (başlangıç ; koşul ; artım)
                          {
                          }  

         */
        /*
             i++ (Post-increment): İlk değer kullanılır, ardından artış yapılır.
             ++i (Pre-increment): Önce artış yapılır, ardından bu yeni değer kullanılır.
         */

        //1-10 arasındaki sayıları bastıralım.
        /*
        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine(i);
        } */
        //10-20 arasındaki sayıları bastıralım.
        /*
        for (int i = 10; i<=20 ; i++)
        { 
           Console.WriteLine(i);
        } */
        //50-20 arasındaki sayıları bastıralım.
        /*
        for(int i = 50;i>=20 ; i--)
        {
            Console.WriteLine(i);
        } */
        #endregion

        #region For Örnekleri - Örnek1 : ilk yüz sayının toplamı ve ortalaması nedir?
        /*
        int toplam = 0;
        for (int i = 0; i <=100; i++) 
        {
           toplam += i;
        }
        //iki integer sayının bölümü integer'dır, küsuratlı çıkması için değerlerden
        //birinin kesirli bir sayıya çevrilmesi gerekir.

        float ortalama = toplam / 100f;
        
        // float ortalama = (float)toplam / 100;
        // float ortalama = toplam / (float)100; 
        // float ortalama = Convert.ToSingle(toplam)/100;
        // double ortalama = (double)toplam /100;

        Console.WriteLine($"ilk yüz sayının toplamı: {toplam} ortalaması: { ortalama}");*/
        #endregion

        #region For Örnekleri - Örnek 2 - 2015'den 2025'e kadar seneleri yazdır fakat pandemi senesini atla.
        /* Tabii ki bu sorunun birden fazla çözüm şekli var */
        /* mesela bu şekilde 2020 haricinde seneleri yazdırabiliriz.

        for (int i = 2015 ;i <=2025;i++) 
        {
           if (i != 2020)
               Console.WriteLine(i);
        } */

        /* ya da continue key wordü kullan; eğer i değeri 2020'yi görürse bunu atla 
           ve koşulda ki üst değere kadar döngüyü devam ettir.
        for (int i = 2015; i < 2026; i++)
        {
            if (i == 2020)
                continue;
            Console.WriteLine(i);
        }*/
        /* Ya da okunması gereken bir dosya vardır aradğınızı bulduktan sonra gerisine
         ihtiyaç yoktur, döngü kırılır ve işlem biter.
        for (int i = 2015; i < 2026; i++)
        {
            if (i == 2020)
                break; //Döngüyü kırmak için break kullanılır.
            Console.WriteLine(i);
        } */
        /*
        for (int i = 2015; i < 2026; i++)
        {
            if (i == 2020)
                return; //Programdan çıkmak için return kullanılır.
            Console.WriteLine(i);
        } */
        // Console.WriteLine("Program Sonu");
        #endregion

        #region While Döngüsü (region için shortcut:ctrl+k+s)
        /* Konu Anlatımı
         while koşul doğru oluduğu sürece işlemleri gerçekleştiren bir döngüdür.
         genel syntax:
         while(koşul)
         { 
            //Koşul doğru olduğu sürece 
         }
         */
        #region 0 girilene kadar ekrandan okutulan sayıları toplayıp yazdıralım.
        /*
        int toplam2 = 0, sayi = 1,sayac = 0;
        while (sayi != 0) ;
        {
            Console.WriteLine("Sayı Giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            toplam2 += sayi; // toplam=toplam+sayi;
            sayac++;
            Console.WriteLine("Girilen sayıların adedi: "+sayac+" Toplamı: "+toplam2);
            Console.WriteLine("Girilen sayıların adedi: {0} Toplamı: {1}",sayac,toplam);
            Console.WriteLine($"Girilen sayıların adedi: {sayac} Topalamı :{toplam2}" );
        }*/
        #endregion
        #region Sayı Tahmin Oyunu 1-50 arası sayı tutulacak, kullanıcıya 5 tahmin hakkı verilecek.
        //Eğer Sayı tutulan sayıdan büyükse daha küçük sayı giriniz mesajı verilsin.
        //Eğer Sayı tutulan sayıdan küçükse daha büyük sayı giriniz mesajı verilsin.
        //Oyunu bildiyse eğer kaçıncı denemede bildiğini yazdırın.
        //En sonunda oyuna devam etmek istiyor musunuz sorusunu alın ve ona göre tekrarlatın.
        /*
        Random random = new Random();
        string inputCevap = "evet";

        Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz");
        //0 < tahminHakki & tahminHakki < 5
        while (inputCevap != "hayır")
        {
            Console.Clear();
            byte tutulanSayi = (byte)random.Next(1, 50);//Random sınıfından bir sayı türetmek için next metodu kullanılır.
            byte tahminHakki = 5;

            do
            {
                Console.WriteLine($"[1-50] arasında değer giriniz. ***{tutulanSayi}");
                int inputNum = int.Parse(Console.ReadLine());
                tahminHakki--;

                if (inputNum == tutulanSayi)
                {
                    Console.WriteLine($"Tebrikler bildiniz. {5-tahminHakki}. denemede bildiniz.");
                    break;
                }
                else if (inputNum < tutulanSayi)
                {
                    Console.WriteLine($"Daha büyük sayı giriniz. {tahminHakki} hakkınız kaldı.");
                }
                else
                {
                    Console.WriteLine($"Daha küçük sayı giriniz. {tahminHakki} hakkınız kaldı.");
                }
            } while (tahminHakki > 0);
            
            Console.WriteLine("Devam etmek istiyor musunuz? [evet/hayır]");
            inputCevap = Console.ReadLine().ToLower();
        } */


        #endregion

        #region Fibonacci sayıları 1,1,2,3,5,8,13,21,34... kendinden önceki iki sayının toplamı şeklindedir.
        // ilk 20 fibonacci sayısını ekrana bastırın.
        /*
        Console.WriteLine("İlk 20 Fibonacci sayısı");
        int sayi1 = 1,sayi2=0,toplam;
        for (int i = 0; i < 21; i++)
        {
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            sayi1 = sayi2;
            sayi2 = toplam;
        } */
        #endregion

        #region İlk 20 asal sayıyı yazdırın.
        
        Console.WriteLine("ilk 20 asal sayı");
        int sayac = 1; // kaç asal sayı bulduğunu sayıyor.
        int altSayac = 0; // altSayac bir sayının kaç böleni olduğunu tutuyor.

        for (int i = 2; i < 73; i++) //i başlanılan sayı değeridir. en küçük asal 2 olduğu için 2'den başlar.
        { // i<73 te sınırlama sebebi 21. asal sayı 73'tür.
            for (int  j = 2;  j <= Math.Sqrt(i);  j++)
            {
                 if (i % j == 0)
                 {
                    altSayac++;
                    //break; // sayı bölündüyse asal değil, döngüden çık.
                 }
            }
            if (altSayac == 0) // sadece 1'e ve kendisine bölünüyorsa asal
            {
                Console.WriteLine(i);
                sayac++;
            }
            altSayac = 0;
            if (sayac == 20) // bu şekilde yazınca 19 asal sayı getiriyor.
            {
                break;
            }
            

        }
        Console.WriteLine("ilk 20 asal sayı");
        int sayi = 2; // Asal sayıları 2'den başlayarak arayacağız.
        int sayac1 = 0; // Kaç adet asal sayı bulduğumuzu tutacak sayaç.

        while (sayac1 < 20) // İlk 20 asal sayıyı bulana kadar devam edecek döngü.
        {
            bool asalMi = true; // Asal olduğunu varsayarak başlıyoruz.

            // Asal olup olmadığını kontrol etmek için döngü.
            for (int i = 2; i <= Math.Sqrt(sayi); i++) // bir sayının çarpanları ya da bölenleri kareköküne kadardır.
            { // bu yüzden işlem kısaltmak adına sayinin kareköküne kadar döngü devam eder.
                if (sayi % i == 0) // Eğer herhangi bir sayıya bölünüyorsa asal değildir.
                {
                    asalMi = false;
                    break; // Asal olmadığını öğrendiğimizde döngüden çıkıyoruz.
                }
            } // eğer sayı 36 olsaydı bölenleri : 1,2,3,4,6 olacaktı 

            if (asalMi) // Eğer sayı asal ise
            {
                Console.WriteLine(sayi); // Asal sayıyı ekrana yazdır.
                sayac1++; // Asal sayıyı bulduğumuz için sayaç artırılıyor.
            }

            sayi++; // Bir sonraki sayıyı kontrol etmek için artırıyoruz.

            #endregion

            #endregion
        }

    }
}
