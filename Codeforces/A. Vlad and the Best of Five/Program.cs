namespace A._Vlad_and_the_Best_of_Five
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1926/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string vlad = Console.ReadLine()!;

                int counter_A = vlad.Where(x => x == 'A').Count();
                int counter_B = vlad.Where(x => x == 'B').Count();

                if (counter_A > counter_B)
                {
                    Console.WriteLine('A');
                }

                else
                {
                    Console.WriteLine('B');
                }
            }
        }
    }
}
