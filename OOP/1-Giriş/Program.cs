namespace _1_Giriş
{
    public struct Kisi
    {
        public string Ad;
        public string Soyad;
        string _TcNo;
        public string Gsm;

        public void SetTcNo(string value)
        {
            if(!string.IsNullOrEmpty(value) && value.Length == 11) 
            {
                _TcNo = value;
            }
        }
        public string GetTcNo()
        {
            if(!string.IsNullOrEmpty(_TcNo))
            {
                return _TcNo.Substring(7);
            }
            else 
            {
                return " ";
            }
        }
    }

    public class Personel
    {
        public string Ad {  get; set; } // Boş property
        public string Soyad { get; set;}
        public string TcNo{  //TcNo kapsullenmiş. Get ve set metodları koşula baglı ver girisi,cıkısı
            get
            {
                if(!string.IsNullOrEmpty(TcNo))
                {
                    return TcNo.Substring(7);
                }
                else return " ";
            }
            set
            {
                if (!string.IsNullOrEmpty(TcNo) && value.Length == 11)
                {  TcNo = value;}
            }
        
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct ile Calismak 
            Kisi kisi = new Kisi();
            kisi.Ad = "Şevval";
            kisi.Soyad = "Özdemir";
            kisi.SetTcNo("12345678901");
            Console.WriteLine(kisi.GetTcNo);
            #endregion

        }
    }
}
