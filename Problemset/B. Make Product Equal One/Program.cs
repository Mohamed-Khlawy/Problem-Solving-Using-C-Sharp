namespace B._Make_Product_Equal_One
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1206/B
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);

            List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int minusOneCounter = 0;
            int zeroCounter = 0;

            long minCoins = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                {
                    zeroCounter++;

                    minCoins++;
                }

                else if (numbers[i] > 0) minCoins += numbers[i] - 1;

                else if (numbers[i] == -1) minusOneCounter++;

                else /// numbers[i] < 0 && != -1
                {
                    minusOneCounter++;

                    minCoins += Math.Abs(numbers[i] + 1);
                }
            }

            if (minusOneCounter % 2 != 0 && zeroCounter == 0)
            {
                minCoins += 2;
            }

            //Console.Write("************************ ");

            Console.WriteLine(minCoins);
        }
    }
}
