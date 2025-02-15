namespace B._Buttons
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/268/B
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);

            int worstCaseScenario = number;

            for (int i = 1; i < number; i++)
            {
                worstCaseScenario += i * (number - i);
            }

            //Console.Write("********************** ");

            Console.WriteLine(worstCaseScenario);
        }
    }
}
