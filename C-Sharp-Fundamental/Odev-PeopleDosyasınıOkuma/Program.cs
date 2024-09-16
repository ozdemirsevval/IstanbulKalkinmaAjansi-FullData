
namespace Odev_PeopleDosyasınıOkuma
{
    public struct People
    {
        public int Index;
        public string UserId;
        public string FirstName;
        public string LastName;
        public string Sex;
        public string Email;
        public string Phone;
        public DateTime DateofBirth;
        public string JobTitle;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            PeopleOku();
        }

        public static List<People> PeopleOku()
        {
            List<People> people = new List<People>();

            var satirlar = File.ReadAllLines(@"C:\Users\sevva\temp\people-1000.csv");
            

            for (int i = 1;i< satirlar.Length; i++)
            {
                var sutunlar = satirlar[i].Split(',');

                People person = new People();
                person.Index = int.Parse(sutunlar[0]);
                person.UserId = sutunlar[1];
                person.FirstName = sutunlar[2];
                person.LastName = sutunlar[3];  
                person.Sex = sutunlar[4];
                person.Email = sutunlar[5];
                person.Phone = sutunlar[6];
                person.DateofBirth = DateTime.Parse(sutunlar[7]);

                if (sutunlar.Length == 9)
                {
                    person.JobTitle = sutunlar[8].Replace(',', ' ').Trim();
                }
                else if (sutunlar.Length == 10)
                {
                    person.JobTitle = sutunlar[8].Replace(',', ' ').Trim()+","+sutunlar[9].Replace('"', ' ').Trim();
                }
                people.Add(person);
            }

            return people;
        }
    }
}
