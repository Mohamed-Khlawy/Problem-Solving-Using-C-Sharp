namespace A._Forbidden_Integer
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1845/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = input[0];
                int k = input[1];
                int x = input[2];

                //Console.WriteLine("******************************** ");

                if (x != 1)
                {
                    Console.WriteLine("YES");

                    Console.WriteLine(n);

                    for (int i = 0; i < n; i++)
                    {
                        if (i == n - 1)
                            Console.WriteLine(1);

                        else
                        {
                            Console.Write(1 + " ");
                        }
                    }
                }

                else if (k == 1 || (k == 2 && n % 2 == 1))
                {
                    Console.WriteLine("NO");
                }

                else
                {
                    Console.WriteLine("YES");

                    Console.WriteLine(n / 2);

                    int firstElement = (n % 2 == 1) ? 3 : 2;

                    var result = new int[] { firstElement }
                        .Concat(Enumerable.Repeat(2, n / 2 - 1))
                        .ToArray();

                    Console.WriteLine(string.Join(" ", result));
                }
            }
        }
    }
}
