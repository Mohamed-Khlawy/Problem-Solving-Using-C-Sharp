namespace C._Longest_Good_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2008/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] l_r = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int left = l_r[0];
                int right = l_r[1];

                int current_number = left;
                int max_arrary_size = 1;

                while (current_number + max_arrary_size <= right)
                {
                    current_number += max_arrary_size;
                    max_arrary_size++;
                }

                //Console.Write("******************************************* ");

                Console.WriteLine(max_arrary_size);
            }
        }
    }
}
