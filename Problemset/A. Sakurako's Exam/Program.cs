namespace A._Sakurako_s_Exam
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2008/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] a_b = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_ones = a_b[0]; // a
                int number_of_twos = a_b[1]; // b

                if (number_of_ones == 0 && number_of_twos == 0)
                {
                    Console.WriteLine("YES");
                }

                else if (number_of_ones == 0 && number_of_twos != 0)
                {
                    if (number_of_twos % 2 == 0) // Even
                    {
                        Console.WriteLine("YES");
                    }

                    else // Odd
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    // Step 1: Convert the twos to ones
                    int twos_to_ones = number_of_twos * 2;

                    // Step 2: Add new ones after coverting to the current existing ones
                    number_of_ones += twos_to_ones;

                    // Step 3: Check number of ones, 
                    // If is Even ==> so we can get zero by subtracting all ones from each other.
                    // If is Odd ==> so we can't get zero by subtracting.

                    if (number_of_ones % 2 == 0) // Even
                    {
                        Console.WriteLine("YES");
                    }

                    else // Odd 
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}
