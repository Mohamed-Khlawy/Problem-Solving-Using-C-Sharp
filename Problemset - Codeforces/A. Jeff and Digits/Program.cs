namespace A._Jeff_and_Digits
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/352/A
        static void Main(string[] args)
        {
            int numberOfCards = int.Parse(Console.ReadLine()!);

            int[] cards = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int counterFor5 = cards.Where(card => card == 5).Count();
            int counterFor0 = numberOfCards - counterFor5;

            List<int> divisibleBy90 = new List<int>();

            int[] nineFives = Enumerable.Repeat(5, 9).ToArray();
            int[] onlyZeros = Enumerable.Repeat(0, counterFor0).ToArray();

            if (counterFor0 > 0)
            {
                for (int i = 0; i < counterFor5 / 9; i++)
                {
                    divisibleBy90.AddRange(nineFives);
                }

                if (divisibleBy90.Count >= 9)
                {
                    divisibleBy90.AddRange(onlyZeros);
                }

                else
                {
                    divisibleBy90.Add(0);
                }
            }

            //Console.Write("*************************** ");

            Console.WriteLine(divisibleBy90.Count > 0
                ? string.Join("", divisibleBy90)
                : -1);
        }
    }
}
