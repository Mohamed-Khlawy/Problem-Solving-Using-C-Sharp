namespace A._Tricky_Sum
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/598/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long number = long.Parse(Console.ReadLine()!);

                long sum = number * (number + 1) / 2;

                long powersSum = 0;

                List<int> powers = Enumerable.Range(0, 31).ToList();

                int powersIndex = 0;

                long powerValue = (long)Math.Pow(2, powers[powersIndex]);

                while (powerValue <= number)
                {
                    sum -= powerValue;

                    powersSum += powerValue;

                    powersIndex++;

                    powerValue = (long)Math.Pow(2, powers[powersIndex]);
                }

                sum -= powersSum;

                //Console.Write("********************** ");

                Console.WriteLine(sum);
            }
        }
    }
}
