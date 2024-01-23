namespace B._01_Game
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1373/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests > 0)
            {
                tests--;

                string number = Console.ReadLine()!;

                int zero_one_counter = 0;

                for (int i = 0; i < number.Length - 1; i++)
                {
                    if (number[i] != number[i + 1])
                    {
                        zero_one_counter++;

                        number = number.Remove(i, 2);

                        i = -1;
                    }
                }

                if (zero_one_counter % 2 == 0)
                {
                    Console.WriteLine("NET");
                }

                else
                {
                    Console.WriteLine("DA");
                }
            }
        }
    }
}
