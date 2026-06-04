namespace A._PizzaForces
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1555/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long numberOfFriends = long.Parse(Console.ReadLine()!);

                // Check if it's less than 6
                numberOfFriends = numberOfFriends < 6 ? 6 : numberOfFriends;

                // Check if it's even or odd, to make it always even
                numberOfFriends = numberOfFriends % 2 == 1 ? numberOfFriends + 1 : numberOfFriends;

                long minTime = numberOfFriends * 5 / 2;

                //Console.Write("************************************* ");

                Console.WriteLine(minTime);
            }
        }
    }
}
