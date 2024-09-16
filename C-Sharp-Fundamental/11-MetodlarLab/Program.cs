using System.Net.WebSockets;

namespace _11_MetodlarLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorular

            #region 1 - KDV Hesaplama
            /* 
                KdvHesapla(100,20,dahil) => 83.33
                KdvHesapla(100,20,haric) => 120
             */

            Console.WriteLine("KDV Hesaplaması \n Ürünün fiyatı:");
            int urunFiyat = int.Parse(Console.ReadLine());
            

            #endregion

            #region 2 - Hız Hesaplama
            /*
                HizHesapla(100km,30dk) => 200 km hizla gitmen lazim
             */


            #endregion

            #region 3 - İlk Yüz Sayıyı rastgele Dönen Metod
            /*
               DiziOlustur(elemansayisi) => int tipinden içerisinde 1-100 rastgele sayıların olduğu bir dizi dönecek.
             */
            #endregion

            #region 4 - Plakayı Yazınca İlgili Şehiri Yazdırsın.
            /*
               SehirGetir(0) => Rastgele bir şehir getirsin.
               SehirGetir(34) => İstanbul'u getirsin.
             */

            string[] sehirler ={"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};

            #endregion

            #region 5 - Girilen Kelimeyi Şifreleyen Metod

            /*
               Sifrele(string) => girilen kelimeyi şifrelenmiş şekilde bastırsın.
               SifreCoz(sifrelenmis) => kelime
             */

            #endregion

            #region 6- Girilen kelimedeki sesli harf sayısını versin.

            /*
               SesliHarfSayisi(string) => 5 adet sesli harf vardır. a,e,i şeklinde bir çıktı versin.
             */

            #endregion

            #region 7 - Klavyeden Girilen bir Tamsayının Basamaklarını Ekrana Yazdıran Metod
            /*
               BasamakBul(int)
             */
            #endregion

            #endregion
        }

        public static void KdvHesapla(double tutar, double kdv, bool dahilmi)
        {
            if (dahilmi)
            {
                double kdvTutari = tutar * kdv / 100;
                Console.WriteLine($"KDV Tutarı: {kdvTutari}");
                Console.WriteLine($"Toplam Tutar : {tutar + kdvTutari}");
            }
            else 
            { 
                double kdvharictutar = tutar / (100+kdv) /100 ;
                Console.WriteLine($"Fiyat: {tutar}");
                Console.WriteLine($"KDV hariç Tutar: {kdvharictutar}");
                Console.WriteLine($"KDV Tutar : {tutar - kdv}");
            }
        }

    }
}
