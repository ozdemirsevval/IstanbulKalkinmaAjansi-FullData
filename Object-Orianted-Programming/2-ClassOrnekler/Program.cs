namespace _2_ClassOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Instance Alma
            //1.Yol

            Kitap kitap = new Kitap();
            kitap.KitapAdi = "İnce Memed I";
            kitap.Yazar = "Yasar Kemal";
            kitap.BaskiYili = new DateOnly(1955,10,20);
            kitap.YayinEvi = "Çağlayan Yayınevi";

            //2.Yol Object Initilation

            Kitap kitap2 = new Kitap()
            {
                KitapAdi = "Göğe Bakma Durağı",
                Yazar = "Turgut Uyar",
                BaskiYili = new DateOnly(2008, 03, 25),
                YayinEvi = "Yapı Kredi Yayınları",
                Barkod = "9789750813870"
                
            };


            #endregion
        }
    }
}
