namespace A._Filling_Shapes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1182/A
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);

            if (number % 2 == 0)
            {
                Console.WriteLine(Math.Pow(2, number / 2));
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
