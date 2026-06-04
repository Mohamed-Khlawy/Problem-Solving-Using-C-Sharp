namespace A._Goals_of_Victory
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1877/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfTeams = int.Parse(Console.ReadLine()!);

                int[] efficiencyOfTeams = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                //Console.Write("******************** ");

                Console.WriteLine(efficiencyOfTeams.Sum() * -1);
            }
        }
    }
}
