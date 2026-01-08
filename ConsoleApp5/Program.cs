namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price_of_small = 25;
            int price_of_large = 35;
            double tax_rate = 0.06;
            Console.WriteLine("Number of small carpets:");
            int small_carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            int large_carpet = Convert.ToInt32(Console.ReadLine());
            int Cost = (price_of_small * small_carpet) + (price_of_large * large_carpet);
            double tax = tax_rate * Cost;
            double total_estimate = tax + Cost;
            Console.WriteLine("price of small carpets: $25");
            Console.WriteLine("price of large carpets: $35");
            Console.WriteLine($"Cost:${Cost}");
            Console.WriteLine($"tax:${tax}");
            Console.WriteLine($"total_estimate: {total_estimate}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
