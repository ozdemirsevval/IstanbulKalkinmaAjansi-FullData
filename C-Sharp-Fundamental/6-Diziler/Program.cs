namespace _6_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı
            /*
             Birden fazla aynı tipten veriyi bir arada tutmamızı sağlayan nesnelerdir. 
             Dizilerin eleman sayısı sabittir, sonradan değiştirilemezler.
             
             index her zaman 0'dan başlar.
             
             Çok karşılaşılan hata : Index was outside the bound of the array 
             Bu hatada dizinin eleman sayısının dışında bir işlem yapılıyor demektir.

             Tanımlma kuralı : <veri Tipi>[] diziAdi;
                                     int[] sayilar;
                                     DateTime[] tarihler;
                                     bool[] test;
             */
            #endregion

            #region Dizi Tanımlama ve Deger Atama

            int[] notlar; // Burda dizi tanımlanmış olsa bile eleman sayısı belli değildir.
            int[] sayilar = new int[10]; // Bu 10 elemanlı bir dizidir. Default değerleri sıfırdır.
            int[] sayilar2 = {0,1,2,3,4,5,6,7,8,9}; // değerleri atanmış 10 elemanlı bir dizidir.


            // Tek tek değer atamak için dizi indexi kullanılır.

            sayilar2[3] = 20; //index değeri 0'dan başlar ilk sayının index değeri 0 olduğu için 
                              // aslında index değeri 3 olan sayı dizi içinde dördüncü sayıya tekabül etmektedir.

            /* 
               int[] notlar = {5,15,20,25,30,35,40,45,50}
               
               Dizi :  5 ,10 ,15, 20, 25, 30, 35, 40, 45, 50
              İndex : [0],[1],[2],[3],[4],[5],[6],[7],[8],[9]
             
            */

            // Dizilerin ekrana bastırılması için bildiğimiz döngülerin hepsi geçerlidir.
            // Genelde for döngüsü kullanılır.
            // Ancak sıklıkla foreach de kullanılır.
            // Foreach döngü değil iterasyondur.
            // Aradaki fark 1-10 arasindaki sayilari foreach'le ekrana yazdiramayiz.
            // foreach icin mutlaka bir veri seti gereklidir.Bu ister dizi ister liste olabilir.

            #region Var Keyword'u

            /*
                 var javascriptteki var benzeridir.
               * fakat javascriptteki gibi aynı var değişkenine tekrar tekrar değer atayamam.
               * c# ta bu veri tipi bir kez atanır ve değiştirilmez.
                 runtime sırasında veri tipi belli olur.
             */

            var temp = DateTime.Now;
            Console.WriteLine(temp); //13.08.2024 10:47:28

            #endregion

            // Foreach ile kullanımı
            Console.WriteLine("Foreach ile dizi bastırma");
            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }

            // For ile kullanımı
            Console.WriteLine("For döngüsü ile dizi bastırma");
            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(sayilar2[i]);
            }

            #endregion

            #region  20 kişilik bir sınıfın notlarına rastgele atama yapalım.
            /*
            Console.WriteLine("20 kişilik bir sınıfın notları");
            int[] notlar2 = new int[20]; // 20 kişilik sınıf ise 20 elemanlı dizi tanımlıyorum.
            Random rastgele = new Random();
            for (int i = 0;i < notlar2.Length; i++) // i = indis numarası
            {
                notlar2[i] = rastgele.Next(20,100); // 20 ile 100 arasında değer ata.
                Console.WriteLine((i+1)+". Öğrencinin Notu: " + notlar2[i]);
            }
            */
            #endregion

            #region String'e farklı bakış
            /*
            // Stringin kendisi bir dizidir.Ne dizisidir? Karakter dizisi(char)
            string str = "Beşiktaş";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            //aynı string dizisini foreach ile nasıl bastırırız?           
            foreach (char ch in str)
            {
                Console.WriteLine(ch);
            } */
            #endregion

            #region Çok Boyutlu Diziler
            /*
             iki boyutlu bir dizi için int[,] matris = new int[2,3];
             üç botutlu bir dizi için int[,,] kup = new int[3,3,3];
             */
            #region Matriste Değer Ataması
            /*
            Random random = new Random();
            int[,] matris = new int[3, 3];
            Console.WriteLine($" Matrisin 1.Boyutu: {matris.GetLength(0)} \n Matrisin 2. Boyutu: {matris.GetLength(1)}");
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = random.Next(100);
                }
            }
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.WriteLine(matris[i,j]);
                }
            } */
            #endregion

            #region 20 Kişilik Bir Sınıfın 2 Vize ve 1 Final Notunu Tutacak Diziyi Tanımlayınız.
            //notlarMatris.GetLength(0) ifadesi, iki boyutlu notlarMatris dizisinin
            //birinci boyutunun uzunluğunu (satır sayısını) verir.
            //Bu durumda notlarMatris dizisi 20 satır (öğrenci) içerdiği için bu değer 20 olacaktır.
            Random random1 = new Random();
            int[,] notlarMatris = new int[20,3]; // 
            //Öğrenci notlarını atama
            for (int i = 0; i < notlarMatris.GetLength(0); i++) //i öğrencileri döndürüyor.
            { 
                for (int j = 0; j < notlarMatris.GetLength(1); j++) // j ise notları
                {
                    notlarMatris[i, j] = random1.Next(27, 100);
                }
            }
            // Öğrencilerin notlarını ve ortalamasını ekrana bastırma
            for (int i = 0; i < notlarMatris.GetLength(0); i++)
            {
                for (int j = 0; j < notlarMatris.GetLength(1); j++)
                {
                   
                }
                
                Console.WriteLine($"\n Öğrenci {i + 1} : \n Vize 1 : {notlarMatris[i, 0]}, " +
                                      $"Vize 2 :{notlarMatris[i, 1]}, Final :{notlarMatris[i, 2]}");
                
                float toplam = (notlarMatris[i, 0] * 0.3f + notlarMatris[i, 1] * 0.3f) / 2 + notlarMatris[i, 2] * 0.7f;
                int ortalama = (int)toplam;
                if (ortalama < 50)
                {
                    Console.WriteLine($" {ortalama} ile Kaldı.");
                }
                else
                {
                    Console.WriteLine($" {ortalama} ile Geçti.");
                }
                Console.WriteLine("-----------------------------------------------");
            }
            #endregion

            #region 20 Kişilik Bir Sınıfın 2 Vize ve 1 Final Notunu Tutacak Diziyi Tanımlayınız.(2.çözüm sadece ufak bir farkla)

            //burda sadece not yazdırmayı yeniden düzenleyeceğim.
            Console.WriteLine("2.yol farklı notlar atanmış matris ile\n");
            int[,] notlarMatris2 = new int[20, 3];

            //Öğrenci notlarını atama
            for (int i = 0; i < notlarMatris2.GetLength(0); i++) //i öğrencileri döndürüyor.
            {
                for (int j = 0; j < notlarMatris2.GetLength(1); j++) // j ise notları
                {
                    notlarMatris2[i, j] = random1.Next(27, 100);
                }
            }
            //ortalama yazdırma
            for (int i = 0; i < notlarMatris2.GetLength(0); i++)
            {
                int vize1 = notlarMatris2[i, 0];
                int vize2 = notlarMatris2[i, 1];
                int final = notlarMatris2[i, 2];

                double ortalama1 = (int)(((vize1 + vize2) * 0.3) / 2 + final * 0.7);

                Console.WriteLine($"Öğrenci {i + 1} : \nVize 1: {vize1}, Vize 2 : {vize2}, Final : {final}" +
                                  $"\nSonuç: {ortalama1} ile" + (ortalama1 >= 50 ? " Geçtiniz" : " Kaldınız"));
                /*
                if (ortalama1 >= 50)
                {
                    Console.WriteLine($"{ortalama1} ile Geçtiniz.");
                }
                else 
                {
                    Console.WriteLine($"{ortalama1} ile Kaldınız.");
                } */
                Console.WriteLine("-----------------------------");
               
            }
            #endregion

            #endregion


            #region Dizideki en küçük ve en büyük elemanı bulma
                          int[] numbers   = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random1.Next();
            }

            #endregion

        }
    }
}
