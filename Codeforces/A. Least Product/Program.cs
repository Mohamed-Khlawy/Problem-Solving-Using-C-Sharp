namespace A._Least_Product
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1917/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int LessThanZero = 0;
                int zero = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0) zero++;

                    else if (numbers[i] < 0) LessThanZero++;
                }

                //Console.WriteLine("************************ ");

                /// There is at least one zero, or odd number of minus,
                /// so no change.
                if (zero > 0 || LessThanZero % 2 == 1)
                {
                    Console.WriteLine(0);
                }

                else
                {
                    /// No minus elements,
                    /// so will change one positive element to zero.
                    if (LessThanZero == 0)
                    {
                        Console.WriteLine("1\n1 0");
                    }

                    /// Even number of minus,
                    /// so will change one of them to zero.
                    else if (LessThanZero % 2 == 0)
                    {
                        Console.WriteLine
                            ($"1\n{Array.FindIndex(numbers, number => number < 0) + 1} 0");
                    }
                }

                //Console.WriteLine("************************ ");
            }
        }
    }
}
