namespace A._Construct_a_Rectangle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1622/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> stiks = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                stiks.Sort();

                //Console.Write("************************************ ");

                if ((stiks[0] == stiks[1] && stiks[2] % 2 == 0) ||
                    (stiks[1] == stiks[2] && stiks[0] % 2 == 0) ||
                    (stiks[0] == stiks[2] && stiks[1] % 2 == 0))
                {
                    Console.WriteLine("YES");
                }

                else if (stiks[2] == stiks[0] + stiks[1])
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
