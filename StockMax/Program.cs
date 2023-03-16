using System.Reflection;

namespace StockMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.ReadLine();
        }

        public static long StockMax(List<int> prices)
        {

            long res = 0;

            long cap = 0;

            for (int i = prices.Count - 1; i >= 0; i--)
            {
                cap = Math.Max(cap, (long)prices[i]);
                res = res + cap - prices[i];
            }

            return res;
        }
    }
}