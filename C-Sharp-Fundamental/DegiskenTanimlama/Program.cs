using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello World");
       
        #region Değişkenlerin Değer Aralıkları
        System.Console.WriteLine("Min / Max değerleri");
        System.Console.WriteLine("byte: " +byte.MinValue + "/" + byte.MaxValue);
        System.Console.WriteLine("short: " + short.MinValue+ "/" + short.MaxValue);
        System.Console.WriteLine("ushort: " + ushort.MinValue+ "/"+ ushort.MaxValue);
        System.Console.WriteLine("int: "+ int.MinValue+ "/" + int.MaxValue);
        System.Console.WriteLine("uint "+ uint.MinValue+"/" + uint.MaxValue);
        System.Console.WriteLine("long: " + long.MinValue+"/"+long.MaxValue);
        System.Console.WriteLine("ulong: " + ulong.MinValue + "/" + ulong.MaxValue);

        // Küsuratlı değerler, float(4 byte),double(8 byte),decimal(16 byte)
        System.Console.WriteLine("float: " + float.MinValue + "/" + float.MaxValue);
        System.Console.WriteLine("double: " + double.MinValue + "/" + double.MaxValue);
        System.Console.WriteLine("decimal: " + decimal.MinValue + "/" + decimal.MaxValue);
        #endregion
        #region  Değişken Tanımlama Kuralları
        /*
            1- Değişken isimleri sayı ile başlayamaz.
            2- Reserve kelime kullanılamaz => static,void,public v.b.
            3- Özel karakterlerden sadece _ kullanılır.
            4- En fazla 255 karakter olabilir.
            5- <Veri Tipi> <degiskenAdi> => int sayi,string isim..
        */

        //Birleşik kelimelerden oluan değişen isimlerindeki prensipler
        // int StokMiktari => Pascal Case
        //stokMiktari => Camel Case
        //stok_miktari => Snake Case
        //stok-mikyari => Kebab Case
        #endregion
        #region Örnek
        // Bir öğrencinin ad, soyad, doğumtarihi, ayakkabı numarası, tcno, gsm bilgilerini temsil edecek değişkenleri tanımlayalım.
        string ad ="Şevo",soyad;
        DateTime dogumTarihi ;
        DateTime Bugun = DateTime.Now; //ilk değer ataması
        byte ayakkabıNumarasi = 36;
        string tcNo = "12345678910";
        string gsm = "+90 505 000 00 00";
        System.Console.WriteLine(ad + ", " + Bugun +", "+ ayakkabıNumarasi + ", " + tcNo + ", " + gsm);

        // Runtime - Derleme sırasında tipi belirleme
        var temp = 12;
        Console.WriteLine(temp);
        #endregion
        #region Küsurlu Sayılar
        var sayi = 12.3; // default olarak double olur. 
        //float için 12,3f şeklinde decimal için 12.3m şeklinde yazılmalıdır.
        System.Console.WriteLine(sayi);
        #endregion
        #region Sabitler
        const float pi = 3.14f;
        // pi=4.56f; const değikenlere sonradan değer ataması yapılmaz.
        System.Console.WriteLine(pi); 
        #endregion
        #region Değişkenlerin Yaşam Ömrü
        int yas = 21;
        {
            string email = "john.doe@gmail.com";
            System.Console.WriteLine(email); //scope içindeki deşikenlere dışardan erişilemez.
            System.Console.WriteLine(yas); //globaldeki değişkenlere scope içinde erişilebilir.
            {
                int sayi1=10;
                System.Console.WriteLine(yas);
                System.Console.WriteLine(email);
                System.Console.WriteLine(sayi1);
            }
            //System.Console.WriteLine(sayi1); - Hata vercektir.
        }

        #endregion
    }
}