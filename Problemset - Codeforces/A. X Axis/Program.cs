namespace A._X_Axis
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1986/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> cords = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int smallest_f_a = int.MaxValue;
                int a = 0;

                for (int i = 10; i >= 1; i--)
                {
                    int f_a = Math.Abs(cords[0] - i) +
                              Math.Abs(cords[1] - i) + Math.Abs(cords[2] - i);

                    if (f_a < smallest_f_a)
                    {
                        smallest_f_a = f_a;
                        a = i;
                    }
                }

                Console.WriteLine(smallest_f_a);
            }
        }
    }
}
