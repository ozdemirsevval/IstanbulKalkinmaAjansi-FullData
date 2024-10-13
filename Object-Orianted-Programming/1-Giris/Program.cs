namespace _1_Giris
{

    public struct Kisi
    {  //struct yapısını bir hatırlayalım.
        public string Ad;
        public string Soyad;
        //public string TcNo;
        string _TcNo;
        public string Gsm;
        //kontrollu veri girisi. TC numarası illa 11 karakter olacak.
        public void SetTcNo(string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length == 11) //Burda ne yapmak istedim? 
            {
              _TcNo = value;
            }
        }
        //TcNo'nun son 4 hanesini göstermek
        public string GetTcNo()
        {
            if (!string.IsNullOrEmpty(_TcNo))
            {
                return _TcNo.Substring(7); //7.Karakterden sonrasını al.
            }
            else
            {
                return " ";
            }
        }

    }

    public class Personel
    {
        public string _tcNo;
        public string Ad{ get; set; }
        public string Soyad { get; set;}
        public string TcNo {
            get
            {
                if (!string.IsNullOrEmpty(TcNo))
                {
                    return _tcNo.Substring(7);
                }
                else
                {
                    return " ";
                }
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                {
                    _tcNo = value;
                }
            }
        }
        public string Gsm { get; set;}
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct ile Çalışmak

            Kisi kisi = new Kisi();
            
            kisi.Ad = "Henry";
            kisi.Soyad = "Cavill";
            // kisi.TcNo = "12345678910";
            kisi.SetTcNo("12345678910");
            Console.WriteLine($"TcNo'nun son 4 hanesi : {kisi.GetTcNo()}");
            kisi.Gsm = "+90 555 555 55 55";

            Console.WriteLine($"{kisi.Ad} \n{kisi.Soyad} \n{kisi.Gsm}");
            #endregion

            #region Class ile Çalışmak

            Personel personel = new Personel();

            personel.Ad = "Theo";
            personel.Soyad = "James";
            personel.TcNo = "12345678900";
            personel.Gsm = "+90 555 444 33 22";

            Console.WriteLine(personel._tcNo);
            #endregion

        }
    }
}
