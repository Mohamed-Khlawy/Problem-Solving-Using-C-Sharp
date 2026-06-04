namespace A._Rewards
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/448/A
        static void Main(string[] args)
        {
            int[] BizonCups = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] BizonMedals = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int cupBoardShelves = int.Parse(Console.ReadLine()!);

            int shelvesForCups = (int)Math.Ceiling((decimal)BizonCups.Sum() / 5);
            int shelvesForMedals = (int)Math.Ceiling((decimal)BizonMedals.Sum() / 10);

            bool weCanPutRewards = (shelvesForCups + shelvesForMedals) <= cupBoardShelves;

            //Console.Write("***************************** ");

            Console.WriteLine(weCanPutRewards ? "YES" : "NO");
        }
    }
}
