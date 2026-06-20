namespace A._Array_Coloring
{
    internal class Program
    {

        //problem Link: https://codeforces.com/problemset/problem/1857/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int counterForOddNumbers = 0;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    if (numbersArray[i] % 2 != 0)
                    {
                        counterForOddNumbers++;
                    }
                }

                if (counterForOddNumbers % 2 != 0)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}