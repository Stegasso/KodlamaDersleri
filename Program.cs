namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kredi kredi1 = new kredi();
            kredi1.Name = "Genel Kredi";
            kredi1.Ammount = 10000;

            kredi kredi2 = new kredi();
            kredi2.Name = "Özel Kredi";
            kredi2.Ammount = 40000;

            kredi kredi3 = new kredi();
            kredi3.Name = "Emkeklilere Özel Kredi";
            kredi3.Ammount = 35000;

            kredi[] krediler = new kredi[] { kredi1, kredi2, kredi3 };

            foreach (var kredi in krediler)
            {
                Console.WriteLine(kredi.Name + " : " + Convert.ToString(kredi.Ammount));
            }

            Console.WriteLine("Changed");
            Console.WriteLine("Changed again");

        }
    }

    public class kredi
    {
        public int Ammount { get; set; }
        public string Name { get; set; }
    }
}