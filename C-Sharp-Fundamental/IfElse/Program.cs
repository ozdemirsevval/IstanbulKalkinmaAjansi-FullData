using System.Runtime.InteropServices;

namespace IfElse;

class Program
{
    static void Main(string[] args)
    {
        #region Katı-Sıvı-Gaz
        // Kullanıcıdan alınan suyun sıcaklığına göre 0'dan küçükse "katı", 
        // 0 ile 100 arasında ise "sıvı",100'den büyükse "gaz" halindedir mesajı verecek algoritma yazınız.
        /*
        System.Console.WriteLine("Bir sıcaklık değeri giriniz.");
        int suSicakligi = int.Parse(Console.ReadLine());
        if(suSicakligi<=0)
        {
            System.Console.WriteLine("Katı");
        }
        else if(suSicakligi>=100)
        {
            System.Console.WriteLine("Gaz");
        }
        else{
            System.Console.WriteLine("Sıvı");
        } */
        #endregion
        #region Haftanın Günleri
        /*
        System.Console.WriteLine("Bulunduğunuz günün nümerik değerini giriniz.");
        int gun = int.Parse(Console.ReadLine());
        if (1>=gun && gun<=7)
        {
            if (gun == 1)
            {
                System.Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                System.Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                System.Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                System.Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                System.Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                System.Console.WriteLine("Cumartesi");
            }
            else if(gun==7)
            {
                System.Console.WriteLine("Pazar");
            }
        }
        else
        {
            System.Console.WriteLine("Uygun değer giriniz!");
            Console.ReadLine();
        } */
        #endregion
        #region Not Ortalama Hesaplama (benim çözümüm)
        /*2 vize 1 final alınacak vizenin %30u finalin %70'i alınacak.
        Eğer not aralığı 0-29 => D
                        30-49 => C
                        50-69 => B
                        70-100 => A  */
        //  && => ve , || => ya da anlamındadır.
        /*
        System.Console.WriteLine("Birinci vize notunuzu giriniz.");
        int vize1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("İkinci vize notunuzu giriniz.");
        int vize2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Final notunuzu Giriniz");
        int final = int.Parse(Console.ReadLine());
        int vizeOrt = (vize1+vize2)*30/100;
        int notOrt = vizeOrt + final*70/100;
        if (notOrt<0 && notOrt<=29)
        {
            System.Console.WriteLine("Ders Notunuz : D");
            Console.ReadLine();
        }
        else if (notOrt<30 && notOrt<=49)
        {
            System.Console.WriteLine("Ders Notunuz : C");
            Console.ReadLine();
        }
        else if (notOrt < 50 && notOrt <=69)
        {
            System.Console.WriteLine("Ders Notunuz : B");
            Console.ReadLine();
        }
        else if (notOrt < 70 && notOrt <=100)
        {
            System.Console.WriteLine("Ders Notunuz : A");
            Console.ReadLine();
        } */
        #endregion
        #region  Reyon Bulma
        /*
            Disaridan urun adi girilecek 
            program urunun hangi reyonda oldugunu soyleyecek
            Domates,biber,patlican icin Sebze Reyonu
            Diş mancunu ,Parfum,Krem icin Kozmetik reyonu
            Telefon,Bilgisayar ,Ses sistemleri icin Teknoloji reyonu 
            Bunlardan farkli  bir urun girer ise "Bu urun bizde yok " uyarisi verecek
        */
        /*
        System.Console.WriteLine("Bir ürün adı giriniz.");
        string urun = Console.ReadLine().ToLower();

        if (urun == "domates" || urun == "biber" || urun == "patlıcan")
        {
            System.Console.WriteLine("Sebze reyonunda");
        }
        else if(urun == "diş macunu" || urun == "parfüm" || urun == "krem")
        {
            System.Console.WriteLine("Kozmetik reyonunda");
        }
        else if (urun == "telefon" || urun == "bilgisayar" || urun == "ses sistemleri")
        {
            System.Console.WriteLine("Teknoloji reyonunda");
        }
        else
        {
            System.Console.WriteLine("Bu ürün bizde bulunmamakta.");
        } */
        #endregion
        #region Fiyat Tespit
        /* 
            Urun fiyati:5 Tl olsun
            Disaridan girilecek siparis sayisina gore
            20 de az ise toplam ucretten % 5 indirim yapilacak
            20 - 49 arasinda ise % 10 indirim
            50 - 99 arasinda ise % 15 indirim
            100 ve üzeri icin % 20 indirim yapilsin
            Ekrana Toplam tutar ,indirim miktari ve ödenecek tutar bilgilerini yazdirin
        */

        #endregion
        #region Ternary IF
        //Eğer tek satırda ufak bir karar mekzaniması ile yola devam etmek istiyorsak 
        // ? operatörü kullanmamız gerekecekt.r
        // Yazım Formatı : sonuc > 10 ? "True" : "False";
        /*
        int yas = 21;
        var sonuc = yas > 18 ? "Reşit" : "Reşit Değildir"; */
        #endregion

    }


}
