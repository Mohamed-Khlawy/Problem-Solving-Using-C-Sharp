namespace B._Startup
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2036/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfShelves = input[0]; /// n
                int numberOfBottles = input[1]; /// k

                int[] vendingMachine = new int[numberOfBottles + 1];

                long maxMoney = 0;

                for (int i = 0; i < numberOfBottles; i++)
                {
                    int[] bottleDescription =
                        Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                    int brand = bottleDescription[0]; /// Bi
                    int cost = bottleDescription[1];  /// Ci

                    vendingMachine[brand] += cost;
                }

                Array.Sort(vendingMachine);

                int shelfIndex = vendingMachine.Length - 1;

                for (int i = 0; i < numberOfShelves && shelfIndex >= 0; i++)
                {
                    maxMoney += vendingMachine[shelfIndex];

                    shelfIndex--;
                }

                //Console.Write("************************ ");

                Console.WriteLine(maxMoney);
            }
        }
    }
}
