namespace A._Array_Divisibility
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1983/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                List<int> resultList = Enumerable.Range(1, number).ToList();

                Console.WriteLine(string.Join(" ", resultList));
            }
        }
    }
}
