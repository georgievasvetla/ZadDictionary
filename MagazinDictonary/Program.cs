namespace MagazinDictonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var magazin = new Dictionary<string, double>();
                Console.Write("count=");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write("stoka->");
                    string stoka = Console.ReadLine();
                    Console.Write("cena->");
                    double price = double.Parse(Console.ReadLine());
                    magazin[stoka] = price;
                }
                foreach (var etam in magazin)
                {
                    Console.WriteLine($"{etam.Key}->{etam.Value}");
                }
                using (StreamWriter steam = new StreamWriter("magazin.txt", true))
                {
                    foreach (var iteam in magazin)
                    {
                        Console.WriteLine($"Stoka:{iteam.Key}->Price:{iteam.Value}");
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}