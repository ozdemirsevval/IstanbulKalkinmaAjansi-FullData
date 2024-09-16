using System.Collections;
using System.Threading.Channels;

namespace _15_Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı

            /*
               Listeler ArrayList'lerin tipi belli olan generic halidir.
               ArrayList gibi dinamik olarak artan bir yapısı vardır.
               Dizilerdeki gibi baştan eleman sayısını belirtmeye gerek yoktur.
               ArrayList'lerdeli gibi de object almadığından tipi bellidir.
             */

            #endregion

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(DateTime.Now);

            //Liste Tanımlama Örnekelri
            List<int> sayilar = new List<int>();
            List<DateTime> dateList = new List<DateTime>();

            //Listeye eleman ekleme Add metodu ile yapılır.
            sayilar.Add(7);
            sayilar.Add(11);
            sayilar.Add(13);
            sayilar.Add(15);
            sayilar.Add(17);
            sayilar.Add(19);

            dateList.Add(DateTime.Now);
            dateList.Add(DateTime.Now.AddYears(-10));
            dateList.Add(DateTime.Now.AddMonths(0));
            dateList.Add(DateTime.Now.AddDays(+5));

            //Listeden eleman çıkarma remove metodu ile yapılır.
            //Bulduğu ilk elemanı çıkaartır.
            sayilar.Remove(7);

            //Değer ataması
            List<string> sehirler = new List<string>() {"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu","İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri"};


            #region En Çok Kullanılan Metodlar
            //Contains
            sehirler.Contains("Balıkesir"); // Listedeki index numarasını vermez.
                                            // Sadece listede var mı yok mu bakar.

            Console.WriteLine(sehirler.IndexOf("İzmir"));
            Console.WriteLine(sehirler.LastIndexOf("İzmir"));

            //Foreach => Lambda expression uygulanır.

            sehirler.ForEach(s => Console.WriteLine(s));

            //Max,Min,Avg,Sum Metodları

            #region Sayısal Listelerde Min Max
            Console.WriteLine("Sayısal Max: " + sayilar.Max());
            Console.WriteLine("Sayısal Min: " + sayilar.Min());
            Console.WriteLine("Sayısal Avg: " + sayilar.Average());
            #endregion

            #region String Listelerde Min Max 

            Console.WriteLine("String List Max: "+ sehirler.Max());
            Console.WriteLine("Strin List Min: "+ sehirler.Min());

            #endregion

            #region DateTime Listelerde Min Max

            Console.WriteLine("DateTime Max :" +dateList.Max());
            Console.WriteLine("DateTime Min: "+ dateList.Min());

            #endregion

            #region Sıralama Metodları

            sayilar.Sort(); //ascanding sıralayacak
            sayilar.ForEach(s=> Console.WriteLine(s));
            Console.WriteLine("******************************");
            sayilar.Reverse();
            sayilar.ForEach(s => Console.WriteLine(s));

            #endregion

            #endregion
        }
    }
}
