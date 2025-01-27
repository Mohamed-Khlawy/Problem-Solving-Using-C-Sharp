namespace B._Vlad_and_Candies
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1660/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int typesOfCadies = int.Parse(Console.ReadLine()!);

                List<int> candies = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                //Console.Write("************************************** ");

                if (candies.Count == 1)
                {
                    if (candies[0] == 1)
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    candies.Sort();

                    if (candies[^1] - candies[^2] >= 2)
                    {
                        Console.WriteLine("NO");
                    }

                    else
                    {
                        Console.WriteLine("YES");
                    }
                }
            }
        }
    }
}
