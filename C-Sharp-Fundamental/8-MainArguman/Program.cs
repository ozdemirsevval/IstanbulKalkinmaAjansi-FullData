namespace _8_MainArguman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] args nedir? aldığı parametre
            // Burda bir metot var bu metot diyor ki
            // Main => Metodun ismi 
            // void => Geri Dönüş Tipi = Geriye değer döndürmez.
            // static => Metodun static bir bölgede tutulduğunu gösteriyor. Hafızada özel bir bölge
            // Bu zamana kadar hafızayı stack ve heap olarak gördük aslında bir de static bölgesi var
            // static hafıza bölgesi program boyunca erişilebilir alanlardır.
            // stack ve heapte değişkenlerin ve metotların yaşam ömürleri vardır.
            // staticte ise bütün program boyunca ulaşabileceğiniz yaşam ömrü vardır.

            foreach (var item in args) 
            {
                Console.WriteLine(item); //cmd ekranından dotnet run config user.name yazdık.
            }

            #region Komut satırından 2 adet sayı alalım bir adet +,-,/,* gibi bir ifade girsin.
            //Bizde girilen ifadeye göre dört işlemden birini uygulayalım.
            if (args.Length == 0) 
            {
                Console.WriteLine("Program Kullanımı \n <sayi1> <sayi2> <operator> \n Kullanılabilir Operatörler : +,-,/,*");
                return;
            }

            if (args[2] == "+" || args[2] == "-" || args[2] == "/" || args[2] == "*")
            {
                Console.WriteLine("Kullanılabileceğiniz Operatörler : +,-,/,*");
            }

            int sayi1, sayi2;
            bool sonuc = int.TryParse(args[0], out sayi1);
            bool sonuc2 = int.TryParse(args[1], out sayi2);

            if (sonuc == true && sonuc2 == true) //(sonuc && sonuc2) şeklinde de yazılabilir.
            {
                switch (args[2]) 
                {
                    case "+":
                    
                        Console.WriteLine($"Toplam : {sayi1+sayi2}");
                            break;
                    case "-":

                        Console.WriteLine($"Fark : {sayi1 - sayi2}");
                        break;
                    case "*":

                        Console.WriteLine($"Çarpma : {sayi1 * sayi2}");
                        break;
                    case "/":

                        Console.WriteLine($"Bölme : {sayi1 / sayi2}");
                        break;

                }
            }

            #endregion

        }
    }
}
