namespace B._Present_from_Lena
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/118/B

        static void PrintLeadingZeros(int n, int i)
        {
            for (int j = 0; j < (n - i) * 2; j++)
            {
                Console.Write(" ");
            }
        }

        static void PrintRowNumbers(int i)
        {
            // Print Incresing Numbers including middle element for each row
            for (int j = 0; j <= i; j++)
            {
                if (j == i)
                {
                    Console.Write(j);
                }

                else
                {
                    Console.Write(j + " ");
                }
            }

            // Print Decreasing Numbers without middle element for each row
            for (int j = i - 1; j >= 0; j--)
            {
                if (j == 0)
                {
                    Console.Write(" " + j);
                }

                else
                {
                    Console.Write(" " + j);
                }
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);

            // Upper Part of rhombus (including the middle row)
            for (int i = 0; i <= number; i++)
            {
                PrintLeadingZeros(number, i);

                PrintRowNumbers(i);
            }

            // Lower Part of rhombus (excluding the middle row)
            for (int i = number - 1; i >= 0; i--)
            {
                PrintLeadingZeros(number, i);

                PrintRowNumbers(i);
            }
        }
    }
}
