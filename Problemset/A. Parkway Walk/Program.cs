namespace A._Parkway_Walk
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1697/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int betweenBenches = input[0];  /// n
                int myOwnEnergy = input[1];     /// m

                int[] metersBetweenBenches =
                    Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int metersSum = metersBetweenBenches.Sum();

                int minRestoredEnergy = Math.Max(metersSum - myOwnEnergy, 0);

                //Console.Write("************************** ");

                Console.WriteLine(minRestoredEnergy);
            }
        }
    }
}
