namespace A._Eshag_Loves_Big_Arrays
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1529/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                numbers.Sort();

                // Any number not equal the first number,
                // will be removed when they are added and get the average of their summation.

                int deleted_numbers = numbers
                                     .Where(number => number != numbers[0])
                                     .Count();

                //Console.Write("*********************************** ");

                Console.WriteLine(deleted_numbers);
            }
        }
    }
}
