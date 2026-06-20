namespace A._Bad_Ugly_Numbers
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1326/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                if (number == 1)
                {
                    Console.WriteLine(-1);
                }

                else
                {
                    string new_number = "5";

                    for (int i = 1; i < number; i++)
                    {
                        new_number += "7";
                    }

                    Console.WriteLine(new_number);
                }
            }
        }
    }
}
