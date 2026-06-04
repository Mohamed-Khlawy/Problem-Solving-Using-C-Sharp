namespace A._Ezzat_and_Two_Subsequences
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1557/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<double> numbers = Console.ReadLine()!.Split().Select(double.Parse).ToList();

                numbers.Sort();

                /// Last Element is the Maximum one
                double maxElement = numbers[^1];

                /// Now remove maxElement, as we split the numbers to 2 lists
                /// The last element (Maximum) is List1
                /// The rest of numbers is List2
                numbers.RemoveAt(size - 1);

                /// No need to do this step, because func1 Equal to maxElement
                /// double func1 = maxElement;

                double func2 = numbers.Sum() / numbers.Count;

                double result = maxElement + func2;

                //Console.Write("***************************** ");

                Console.WriteLine(result);
            }
        }
    }
}
