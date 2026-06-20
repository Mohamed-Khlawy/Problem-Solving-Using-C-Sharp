namespace B._DIV___MOD
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1650/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int firstElement = input[0]; /// l
                int lastElement = input[1];  /// r
                int fixedValue = input[2];   /// a

                int minValue = (lastElement / fixedValue) +
                               (lastElement % fixedValue);

                int anotherElement = (lastElement / fixedValue * fixedValue) - 1;

                if (anotherElement >= firstElement)
                {
                    int tempMinValue = (anotherElement / fixedValue) +
                                       (anotherElement % fixedValue);

                    minValue = Math.Max(minValue, tempMinValue);
                }

                //Console.Write("************************************ ");

                Console.WriteLine(minValue);
            }
        }
    }
}
