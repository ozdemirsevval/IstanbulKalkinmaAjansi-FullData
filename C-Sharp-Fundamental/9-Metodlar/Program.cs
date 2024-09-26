using System.Net.Http.Headers;
using System.Threading.Channels;

namespace _9_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Konu Anlatımı

            /*
               Metod Nedir?
               - Belirli bir işlevi yerine getimek için kullanılan kod bloklarıdır.
               Metodların tipleri => Geriye Değer Dönen ya da Dönmeyen Metodlar olarak ayırabiliriz.
                                  Eğer Metodlar geriye değer döndürmeyecekse void olarak işaretlenmek zorundadır.
                                  Eğer değer döndürecek ise tipi belirtmek zorundadir (int,string..)
               Bütün metodlar parametrik şekilde olabilir.
               Yani bir metoda tipini belirtmek şartı ile istedğiniz kadar parametre verebilirsiniz.

               Faydaları : 
               Kodun tekrarını engeller, tekrar tekrar kullanılabilir.
               Kodun okunaklılığını arttırır. Programı daha modüler hale getirir.

               Tanımlama Şekli (Sözdizimi)
               
                   [erişim belirteci] [geri dönüş tipi] [metod adı] (aldığı parametreler)
                   {
                        // Kodlar buraya
                   }
               
              [erişim belirteci] => metoda kimlerin erişebileceğini belirler
                                   public,private, internal, protected şeklinde değerler alabilir.
                                   public => genel kullanıma açık demek, şimdilik bunu kullanacağız.
              
              [geri dönüş tipi] => geriye değer döndürmeyecekse void olarak işaretlenir.
                        dönüş tipi => int,float,string,datetime v.b. değerler dönebilir.
                        eğer geri dönüş tipi tanımlıysa metod sonunda mutlaka return ifadesi olmak zorundadır.

              (aldığı parametreler) => metoda göndermek istediğimiz verilerdir. Ayraç olarak , ile ayrılırlar.
                                    metoda gelecel olan parametrelerin mutlaka tiplerinin de yazılması zorunludur. 
            
              Metodların tanımlandığı yerler genelde class içerisindedir.
              
             */

            #endregion

            #region Metod İmzası

            /*
                Aldığı parametreler farklı olduğu sürece aynı isimde metod yazılabilir.
                Buna metod overload yani aşırı yüklenmesi denir. 
                Buna en güzel örnek Console.WriteLine() 18 tane overload edilmiş metodu var.

                Metodun geri dönüş tipi imzaya dahil değildir.
                public static void topla(int sayi1,int sayi2) == Metod bu
                 topla(int sayi1,int sayi2) == Metod imzası bu
             */

            #endregion

            #region İki sayıyı toplayacak metod

            //public static void topla(int sayi1,sayi2)
            //public static long topla(int sayi1,sayi2)

            //overload örneği verebilmek için farklı farklı veri tipleri ile parametre vererek topla metodunu yazdık.

            #endregion

            #region Metod Çağrımı
            /*
            topla(3, 5);
            float toplam = topla(3.5f, 5.3f);
            Console.WriteLine($"Float Toplam : {toplam.ToString("0.00")}");
            decimal toplam1 = topla(3.5m, 5.3m);
            Console.WriteLine($"Decimal Toplam : {toplam1.ToString("0.00")}"); 
            */

            #endregion

            #region Sorular 
            /*
                1 - Kendisine gelen mesajı ekrana yazan metod EkranaYaz()
                2 - Ekrandan sayı okutup int dönen sayioku metodunu yazınız.
                3 - İki adet integer değer alıp bir adet string operatörü alsın, 
                    gelen operatöre göre 4 işlem sonucunu ekrana yazdırsın.
                4 - Faktöriyel alan metod yazınız.
                5 - Verilen sayının verilen üssünü alacak metod >> long UssunuAl(2,4) gibi 
            
            Sayi Oku Metodu Genel Çalışma Mantığı:
            Metot, kullanıcıdan geçerli bir tam sayı girmesini bekler.
            Eğer kullanıcı yanlış bir şey girerse, tekrar sayı girmesi istenir.
            Kullanıcı doğru bir tam sayı girince bu sayı döndürülür.
             */
            #endregion

            //int sayi = SayiOku("Bir sayi giriniz.");

            //double a = (double)SayiOku("double bir sayı giriniz");
            //double b = (double)SayiOku("double bir sayı giriniz.");
            //Console.WriteLine(DortIslem2(a, b, '*')); //Ercan hocanın çözümündeki metodu çağırdık.

            var faktoriyel = Faktoriyel(5);
            Console.WriteLine(faktoriyel);

            int a = SayiOku("Faktöriyelini hesaplamak istediğiniz sayıyı giriniz.");
            var faktoryel = FaktoriyelRecursive(a);
            Console.WriteLine($"Recursive Faktöriyel: {faktoryel}");

            int sayi = SayiOku("Üssünü almak istediğiniz sayıyı giriniz.");
            int us = SayiOku("Üs değerini giriniz.");
            var uslusayi = UssunuAl(sayi, us);
            Console.WriteLine($"{sayi}'nın {us}. üssü = {uslusayi}");
        }

        #region Metod Yazma ve Overload Örneği

        public static void topla(int sayi1, int sayi2)
        {
            Console.WriteLine($"Toplam: {sayi1 + sayi2}");
        }
        public static long topla(long sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int topla(byte sayi1, byte sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int topla(short sayi1, short sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long topla(long sayi1, long sayi2)
        {
            return sayi1 + sayi2;
        }
        public static float topla(float sayi1, float sayi2)
        {
            return sayi1 + sayi2;
        }
        public static double topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        /// <summary>
        /// Gelen iki decimal sayıyı toplar ve sonucu geri döner.
        /// </summary>
        /// <param name="sayi1">Decimal tipinde olmalıdır. </param>
        /// <param name="sayi2">Decimal tipinde olmalıdır. </param>
        /// <returns>Geriye decimal döner.</returns>
        public static decimal topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }

        #endregion

        #region EkranaYaz() metodu 

        public static void EkranaYaz(string mesaj)
        {
            Console.WriteLine($"Mesajınız : {mesaj}");
        }
        #endregion

        #region SayiOku() Metodu
        public static int SayiOku(string mesaj)
        {
            int sayi;
            bool sonuc = true;
            do
            {
                Console.WriteLine(mesaj);
                sonuc = int.TryParse(Console.ReadLine(), out sayi);

            } while (!sonuc);
            return sayi;
        }
        #endregion

        #region DortIslem() Metodu

        public static void Dortİslem(int sayi1, int sayi2, string islem)
        {

            switch (islem)
            {
                case "+":
                    Console.WriteLine($"Toplam: {sayi1 + sayi2}");
                    break;
                case "-":
                    Console.WriteLine($"Fark: {sayi1 - sayi2}");
                    break;
                case "*":
                    Console.WriteLine($"Çarpım: {sayi1 * sayi2}");
                    break;
                case "/":
                    if (sayi2 != 0)
                    {
                        Console.WriteLine($"Bölüm: {sayi1 / sayi2}");
                    }
                    else
                    {
                        Console.WriteLine("Hata : Sayı Sıfıra Bölünemez.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz İşlem.");
                    break;
            }
        }

        #endregion

        #region DortIslem() Metodu İkinci Yol TryCatch -> Hesaplama()
        public static void Hesaplama(int sayi1, int sayi2, string islem)
        {
            int sonuc = 0;
            bool gecerliIslem = true;

            switch (islem)
            {
                case "+":
                    Console.WriteLine($"Toplam: {sayi1 + sayi2}");
                    break;
                case "-":
                    Console.WriteLine($"Fark: {sayi1 - sayi2}");
                    break;
                case "*":
                    Console.WriteLine($"Çarpım: {sayi1 * sayi2}");
                    break;
                case "/":
                    try
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Bölme işleminde bölen 0 olamaz.");
                        gecerliIslem=false;
                    }
                    break;
                default:
                    Console.WriteLine("Geçerli değer giriniz.");
                    break;
                    
            }
        }
        #endregion

        #region DortIslem() Ercan Hoca Çözümü

        public static double? DortIslem2(double say1, double say2, char islem)
        { 
           double sonuc = 0;
           
            switch (islem)
            {
                case '+':
                    return say1 + say2;
                case '-':
                    return say1 - say2;
                case '*':
                    return say1 * say2;
                case '/':
                    try
                    {
                        return say1 / say2;
                    }
                    catch ( Exception ex)
                    {
                        Console.WriteLine("Sıfıra bölme hatası");
                        return 0;
                    }
                default:
                    Console.WriteLine("Beklenmedik bir durum oluştu.");
                    return 0;
            }
        }

        #endregion

        #region Faktoriyel() metodu

        public static long Faktoriyel(int sayi)
        {
           long sonuc = 1;

           for (int i = 1; i <= sayi; i++) 
           {
                sonuc *= i;
           }
           return sonuc;
        }

        #endregion

        #region Recursive Metod ile Faktoriyel() Çözümü

        public static long FaktoriyelRecursive(int sayi)
        {
            if (sayi == 1 || sayi == 0)
            {
                return 1; // 0 ve 1'in faktöriyeli her zaman 1 döner.
            }
            else
            {
                return sayi * FaktoriyelRecursive(sayi - 1);
            }
        }

        #endregion

        #region UssunuAl() metodu ile recursive Üslü Sayı Hesaplama

        public static long UssunuAl(int sayi, int us)
        {
            if (us == 0)
            {
                return 1;
            }
            else
            {
                return sayi * UssunuAl(sayi, us - 1);
            }
        }

        #endregion
    }
}