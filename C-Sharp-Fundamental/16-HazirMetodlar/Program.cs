namespace _16_HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Hazır Metodları

            #region Cümledeki Kelime Sayısı

            #endregion

            #region Replace Metodu

            #endregion

            #region Substring Metodu

            //Cümle içerisinde nokta atışı yaparak istediğimiz bir

            string str = "Bugün günlerden cuma";
            Console.WriteLine(str.Substring(6)); // 6.karakterden sonrası alınacak
            Console.WriteLine(str.Substring(6,9)); //
            string krediKartNo = "1234 5678 9123 4567"; //kredikarttno son 4 hanesi
            Console.WriteLine("Kredi Kartı son 4 hanesi: " + krediKartNo.Substring(krediKartNo.Length-4));
            string anneKizlikSoyadi = "Yilmaz"; //3. 5. harfi
            Console.WriteLine("Anne Kızlık Soyadı 3. ve 5. harfi: " + $"{anneKizlikSoyadi[2]},{anneKizlikSoyadi[5]}");
            #endregion

            #region ToLower() ToUpper()

            string str2 = "Can be the greatest romance of your life last one night only";
            Console.WriteLine("ToUpper Metodu: " + str2.ToUpper());
            Console.WriteLine("ToLower Metodu: "+str2.ToLower());


            #endregion

            #region Insert, Remove

            Console.WriteLine("Insert Metodu: " + str2.Insert(str2.Length , ",Before Sunrise"));
            Console.WriteLine("Remove Metodu: " + str2.Remove(60)); //60.karakterden sonrasını alma

            #endregion

            #region Sansur
            Console.WriteLine("Sansürlü: " + Sansur(str2));
            #endregion
            #endregion

            #region Matemaik Hazır Metodları

            Console.WriteLine("2'nin küpü : "+Math.Pow(2, 3)); //üslü sayı
            Console.WriteLine("16'nın Karekökü: " + Math.Sqrt(16));
            Console.WriteLine(Math.Pow(8,1/3.0)); // 2
            Console.WriteLine("Pi Sayısı : " + Math.PI);
            Console.WriteLine("Tau Sayısı (Pi'nin iki katı: " + Math.Tau);
            #endregion

            #region Yuvarlama Metodları

            //ceiling => verilen ondalıklı sayıyı bir üste yuvarlar.
            Console.WriteLine("Ceiling: " + Math.Ceiling(10.1));
            //floor => Verilen ondalıklı sayıyı bir alta yuvarlar.
            Console.WriteLine("Floor: " + Math.Floor(10.9));
            // Round verilen ondalıklı sayıyı yarısından fazla ise yukarı
            //Teklerde aşağıya çiftlerde yukarı yuvarlar .5'de geçerli
            Console.WriteLine("Round: " + Math.Round(10.4)); //10
            Console.WriteLine("Round: " + Math.Round(10.7));
            Console.WriteLine("Round: " + Math.Round(10.5));
            Console.WriteLine("Round: " + Math.Round(10.51));
            Console.WriteLine("Round: " + Math.Round(11.5));
            Console.WriteLine("Round: " + Math.Round(12.51));
            Console.WriteLine("Round: " + Math.Round(13.5));
            Console.WriteLine("Round: " + Math.Round(14.5));

            #endregion

            #region DateTime Hazır Metodları
            var tarih = DateTime.Now;
            Console.WriteLine("Yerel Saat: " + DateTime.Now); //Local
            Console.WriteLine("Utc Saat: (Greenwich)" + DateTime.UtcNow);//Greenwich
            Console.WriteLine("ToShortDateString sadece tarih : "+ tarih.ToShortDateString());
            Console.WriteLine("ToShortTimeString sadece saat: "+tarih.ToShortTimeString());


            #endregion
        }

        public static string Sansur(string str2)
        {
            List<string> yasakliKelimeler = new List<string>();
            yasakliKelimeler.Add("romance");
            yasakliKelimeler.Add("life");
            yasakliKelimeler.Add("night");

            foreach (var kelime in yasakliKelimeler)
            {

                if (str2.Contains(kelime))
                {
                    string yildiz = "";
                    for (int i=0; i<kelime.Length; i++)
                    {
                        yildiz += "*";
                    }
                    str2 = str2.Replace(kelime, yildiz);
                }   
            }
            return str2;
        }

    }
}
