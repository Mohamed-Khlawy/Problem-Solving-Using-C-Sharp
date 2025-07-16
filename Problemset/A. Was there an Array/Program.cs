namespace A._Was_there_an_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2069/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int mainArraySize = int.Parse(Console.ReadLine()!);

                string equalityCharateristicArray = Console.ReadLine()!;

                bool isThereExist = equalityCharateristicArray.Contains("1 0 1");

                //Console.Write("***************************** ");

                Console.WriteLine(isThereExist ? "NO" : "YES");
            }
        }
    }
}
