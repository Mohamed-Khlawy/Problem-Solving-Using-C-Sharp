namespace A._Don_t_Try_to_Count
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1881/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input_sizes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int string1_size = input_sizes[0];
                int string2_size = input_sizes[1];

                string string1 = Console.ReadLine()!;
                string string2 = Console.ReadLine()!;

                //Console.Write("*** ");

                int number_of_operations = 0;

                while (!string1.Contains(string2) && number_of_operations < 5)
                {
                    string1 += string1;

                    number_of_operations++;
                }

                if (string1.Contains(string2))
                {
                    Console.WriteLine(number_of_operations);
                }

                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
