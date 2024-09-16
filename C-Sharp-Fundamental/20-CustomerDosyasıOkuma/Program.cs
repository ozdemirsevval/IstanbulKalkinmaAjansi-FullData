namespace _20_CustomerDosyasıOkuma
{
    public struct Customer
    {
        public int Id;
        public string CustomerId;
        public string FirstName;
        public string LastName;
        public string Company;
        public string City;
        public string Country;
        public string Phone1;
        public string Phone2;
        public string Email;
        public string SubscriptionDate;
        public string Website;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var liste = CustomerOku();
            liste.ForEach(item => Console.WriteLine($" Müşteri index no: {item.Id} || " +
                $"Müşteri ID: {item.CustomerId} || Müşteri İsim - Soyisim: {item.FirstName +" " + item.LastName} || " +
                $"\n Müşterinin Çalıştığı Şirket: {item.Company} || " +
                $"Yaşadığı Şehir: {item.City} || Yaşadığı Ülke: {item.Country} ||" +
                $" \n 1. Telefon Numarası: {item.Phone1} || 2. Telefon Numarası: {item.Phone2} || " +
                $"Email Adresi: {item.Email} \n Abonelik Başlangıç Zamanı: {item.SubscriptionDate} || " +
                $"Website: {item.Website} \n"));
        }

        public static List<Customer> CustomerOku()
        {
            List<Customer> customers = new List<Customer>();
            var satirlar = File.ReadAllLines(@"C:\Users\sevva\temp\customers-1000.csv");
            for (int i = 1; i < satirlar.Length; i++)
            {
                var sutunlar = satirlar[i].Split(',');

                Customer customer = new Customer();
                customer.Id = int.Parse(sutunlar[0]);
                customer.CustomerId = sutunlar[1];
                customer.FirstName = sutunlar[2];
                customer.LastName = sutunlar[3];

                if (sutunlar.Length ==12)
                {
                    customer.Company = sutunlar[4];
                    customer.City = sutunlar[5];
                    customer.Country = sutunlar[6];
                    customer.Phone1 = sutunlar[7];
                    customer.Phone2 = sutunlar[8];
                    customer.Email = sutunlar[9];
                    customer.SubscriptionDate = sutunlar[10];
                    customer.Website = sutunlar[11];
                }
                else
                {
                    customer.Company = sutunlar[4]+ " " + sutunlar[5];
                    customer.City = sutunlar[6];
                    customer.Country = sutunlar[7];
                    customer.Phone1 = sutunlar[8];
                    customer.Phone2 = sutunlar[9];
                    customer.Email = sutunlar[10];
                    customer.SubscriptionDate = sutunlar[11];
                    customer.Website = sutunlar[12];
                }
                customers.Add(customer);
            }

            return customers;
        }

    }
}
