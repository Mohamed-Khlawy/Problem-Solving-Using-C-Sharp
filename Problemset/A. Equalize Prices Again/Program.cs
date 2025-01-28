namespace A._Equalize_Prices_Again
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1234/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfGoods = int.Parse(Console.ReadLine()!);

                List<int> goods = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                long totalPrice = goods.Sum();

                long averagePrice = (long)Math.Ceiling((double)totalPrice / numberOfGoods);

                //Console.Write("********************** ");

                Console.WriteLine(averagePrice);
            }
        }
    }
}
