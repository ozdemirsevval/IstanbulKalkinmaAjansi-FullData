namespace _19_DosyaOkuma
{
    public struct Sehir //Kendi Veri Tepimiz
    {
        public string plakaKodu;
        public string il;
        public DateTime CreateDate;
        public bool isActive;
    }
    public struct Ilce
    {
        public int ilceKodu;
        public int ilKodu;
        public string ilceAdi;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dosya Okuma İşlemleri

            #region Konu Anlatımı

            /*
             Dosya nedir? İçerisinde çeşitli bilgiler saklyan yapılara dosya denir.
            Bilgi türleri ; metinsel veriler, ses dosyaları, fotoğraf ve resim dosyaları
            database dosyaları,html,dosyaları, office dosyaları v.b.

            Bunlar arasında bizim en çok üzerinde duracağımız .csv dosyaları olacaktır.
            csv (comman seperated values) veriler arasında bir ayraç ile 
            (genelde ',' ya da ';' olur.) ayrılmış dosyalara csv denir.
             
            C#'da dosya okumanın bir çok yolu vardır. En hızlı ve kolay olanı file sınıfıdır.
             */

            #endregion

            #region Customer-1000.csv dosyasının okunması ve listeye atanması
            /*
            string path = "C:\\Users\\sevva\\temp\\customers-1000.csv"; // çift backslash
            
            // '@' işareti, verbatim string literal olarak adlandırılır ve bu sayede string içerisindeki
            // ters eğik çizgi '\' gibi kaçış karakterleri olduğu gibi alınır.
            string path2 = @"C:\Users\sevva\temp\customers-1000.csv"; */



            #endregion

            var sehirler = SehirleriOku();

            sehirler.OrderBy(p => p.il).ToList();

            var ilceler = IlceleriOku(); // => Geriye ilçeler listesi dönsün.

            foreach (var item in ilceler) 
            {
                Console.WriteLine($"{item.ilceKodu} {item.ilKodu} {item.ilceAdi}");
            }

            #endregion

            #region İlçeler üzerinde İstanbul'un ilçelerini bulalım.

            foreach (var ilce in ilceler)
            {
                if (ilce.ilKodu == 34)
                {
                    Console.WriteLine(ilce.ilceAdi);
                }
            }

            #endregion
        }

        private static List<Ilce> IlceleriOku()
        {
            string path4 = @"C:\Users\sevva\temp\ilce.csv";
            List<Ilce> ilceler = new List<Ilce>();

            try
            {
                string[] satirlar = File.ReadAllLines(path4);

                foreach (var satir in satirlar)
                {
                    Ilce ilce = new Ilce();
                    var sonuc = satir.Split(',');
                    #region Eğer tırnaklar görünmek istenmiyorsa 1.Yol replace etmektir.

                    //ilce.ilceKodu = sonuc[0].Replace('"', ' ').Trim();
                    //ilce.ilKodu = sonuc[1].Replace('"', ' ').Trim(); 

                    #endregion

                    #region Eğer Tırnaklar görünmek istenmiyorsa ikinci yol int'e çevirmektir.

                    /*
                      ilce.ilKodu = int.Parse(sonuc[0]); şeklindeki kodumuz çalışmadı neden?
                      tırnaklardan arınması gerektiği için kod çalışmadı bu nedenle biz de replace metodunu ekledik
                      tırnağı boşluk ile yer değiştirdikten sonra bu boşluğu kaldırabilmek için trim yazdık.

                      ilce.ilceKodu =int.Parse(sonuc[0].Replace('"',' ').Trim());
                      Peki kod içi bu kadar uzunken derlemede ne yapacak?

                      Derleme sırasında parentez içinde en soldan başlayarak sıfırıncı indexteki değerde
                      yer alan tırnağı boşluk ile değiştirecek ardından bu boşluğu trim() metodu ile kaldıracak.
                      içindeki son hali ise int parse ile veri tipini int'e çevirecek.
                     */

                    ilce.ilceKodu =int.Parse(sonuc[0].Replace('"',' ').Trim());
                    ilce.ilKodu = int.Parse(sonuc[1].Replace('"',' ').Trim());
                    ilce.ilceAdi = sonuc[2];
                    #endregion
                    ilceler.Add(ilce);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Hata : Aradığınız dosyaya şu an ulaşılamadı." + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hata: Aradığınız Klasöre ulaşlılamadı." + ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Hata: Dosya yolu çok uzun." + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message);
            }

            return ilceler;
        }

        private static List<Sehir> SehirleriOku()
        {
            string path3 = @"C:\Users\sevva\temp\il.csv";

            List<string> plakalar = new List<string>();
            List<string> iller = new List<string>();

            List<Sehir> sehirler = new List<Sehir>();

            try
            {
                string[] satirlar = File.ReadAllLines(path3);
                foreach (var satir in satirlar)
                {
                    Sehir sehir = new Sehir(); // Şehir struct'tan örnek alınması
                    var sonuc = satir.Split(','); // Gelen satırı ',' göre ayırır.

                    sehir.plakaKodu = sonuc[0];
                    sehir.il = sonuc[1];
                    sehir.CreateDate = DateTime.Now;
                    sehir.isActive = true;

                    #region Uzun Yol
                    //plakalar.Add(sonuc[0]); //Ayrılan parçanın 0. elemanı plaka kodu
                    //iller.Add(sonuc[1]); // Ayrılan parçanın 1. elemanı iller 
                    #endregion

                    #region Modern Yöntem

                    sehirler.Add(sehir);

                    #endregion

                }
                for (int i = 1; i < plakalar.Count; i++)
                {
                    #region Uzun Yol Klasik Yöntem
                    //Console.WriteLine($"{plakalar[i]} => {iller[i]} "); 
                    #endregion

                    #region Modern Yöntem

                    foreach (Sehir sehir in sehirler)
                    {
                        Console.WriteLine($"{sehir.plakaKodu} => {sehir.il} \t Kayıt Zamanı: {sehir.CreateDate} \t Aktif mi: {sehir.isActive} ");
                    }

                    #endregion
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Hata : Aradığınız dosyaya şu an ulaşılamadı." + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Hata: Aradığınız Klasöre ulaşlılamadı." + ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine("Hata: Dosya yolu çok uzun." + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message);
            }

            return sehirler;
        }
    }


}
