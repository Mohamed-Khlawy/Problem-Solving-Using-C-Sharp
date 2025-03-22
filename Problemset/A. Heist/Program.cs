namespace A._Heist
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1041/A
        static void Main(string[] args)
        {
            int existingKeyboards = int.Parse(Console.ReadLine()!);

            int[] keyboards = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Array.Sort(keyboards);

            int stolenKeyboards = 0;

            for (int i = 1; i < keyboards.Length; i++)
            {
                stolenKeyboards += keyboards[i] - keyboards[i - 1] - 1;
            }

            //Console.Write("******************** ");

            Console.WriteLine(stolenKeyboards);
        }
    }
}
