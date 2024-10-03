namespace _10_MetotlarLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorular
            /*
                 1 - KdvHesapla(100,20,dahil) => 83.33
                     KdvHesapla(100,20,haric) => 120
                 
                 2 - HizHesapla(100km,30min)  => 200km hızla gitmen lazım

                 3 - DiziOlustur(elemansayisi) => int tipinden 1-100 rastgele sayıların olduğu bir dizi

                 4 - SehirGetir(0) = rastgele bir şehir getirsin
                     SehirGetir(35) = İstanbul getirsin.

            string[] sehirler ={"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};

                 
                 5 - SesliHarfSayisi(string) => 8 adet sesli harf vardır. a,e,,ı,i,o,ö,u,ü şeklinde çıktı versin.

                 6 - Sifrele(string) => Şifrelenmiş şekilde bastırsın.
                     SifreCoz(sifrelenmis) => Kelime

                 7 - BasamakBul(int) => Klavyeden Girilen Bir Tam Sayının Basamaklarını Ekrana Yazdıran Metod.
                         
             */
            #endregion
            string[] sehirler ={"Adana","Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
            "Aydın", "Balıkesir","Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
            "Çankırı", "Çorum","Denizli","Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum ", "Eskişehir",
            "Gaziantep", "Giresun","Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
            "Kars", "Kastamonu", "Kayseri","Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya ", "Malatya",
            "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon  ", "Tunceli", "Şanlıurfa", "Uşak",
            "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt ", "Karaman", "Kırıkkale", "Batman", "Şırnak",
            "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük ", "Kilis", "Osmaniye ", "Düzce"};
           /*
            KdvHesapla(100,18,true);
            KdvHesapla(100,18,false);
           */
            //HizHesapla(100, 30);

            /*
            var dizi = DiziOLustur(10);
            Console.WriteLine($"\nDizinin Elemanları :");
            foreach (var item in dizi) 
            {
                Console.WriteLine(item);
            } */

            SehirBul(sehirler,34);
        }

        #region KdvHesapla() Metodu

        public static void KdvHesapla(double tutar, double kdv,bool dahilmi)
        {
            if (dahilmi) 
            {
                double kdvtutari = tutar * kdv / 100;
                Console.WriteLine($"Tutar : {tutar} \nKdv Tutarı : {kdvtutari}");
                Console.WriteLine($"Toplam Tutar : {tutar+kdvtutari} \n");
            }
            else 
            {
                double kdvharictutar = tutar /((100+kdv)/100) ;
                Console.WriteLine($"Tutar : {tutar} \nKdv Hariç Tutarı : {kdvharictutar}");
                Console.WriteLine($"Kdv Tutar : {tutar - kdvharictutar} \n");
            }
        }

        #endregion

        #region HizHesapla() Metodu

        public static void HizHesapla(double km, double minute)
        {
            //hız nasıl hesaplanır. x = v.t yol formülüydü burda v yi çekelim. => v = x(yol)/t(zaman)
            Console.WriteLine($"{km} km yolu {minute} dakikada alabilmek için " +
                              $"{km/(minute/60)} km hızla gitmeniz gerekir.");
        }

        #endregion

        #region DiziOlustur() Metodu

        public static int[] DiziOLustur(int elemansayisi)
        {
            Random random = new Random();
            int[] dizi = new int[elemansayisi];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = random.Next(1,100);
            }
            return dizi;
        }

        #endregion

        #region SehirGetir() Metodu

        public static void SehirBul(string[] sehirler,byte plaka)
        {
            Random random = new Random();
            if (plaka == 0)
            {
                Console.WriteLine(sehirler[random.Next(1,sehirler.Length)]);
            }
            else
            {
                Console.WriteLine(sehirler[plaka-1]);
            }
        }

        #endregion

        #region SesliHarfSayisi() Metodu

        #endregion

        #region Sifrele() ve SifreCoz() Metodları

        #endregion

        #region BasamakBul() Metodu

        #endregion
    }
}
