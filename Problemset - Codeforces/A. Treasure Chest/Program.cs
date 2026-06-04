namespace A._Treasure_Chest
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1895/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int chestIntialPoint = input[0]; // x
                int keyIntialPoint = input[1];   // y
                int maxCarryingTime = input[2];  // k

                int minTime = 0;

                if (chestIntialPoint > keyIntialPoint)
                {
                    minTime = chestIntialPoint;
                }

                else
                {
                    if (chestIntialPoint + maxCarryingTime >= keyIntialPoint)
                    {
                        minTime = keyIntialPoint;
                    }

                    else
                    {
                        minTime = keyIntialPoint +
                            (keyIntialPoint - (chestIntialPoint + maxCarryingTime));
                    }
                }

                //Console.Write("**************************** ");

                Console.WriteLine(minTime);
            }
        }
    }
}
