namespace A._MEX_Table
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2057/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] tableDimensions =
                    Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int numberOfRows = tableDimensions[0]; /// n
                int numberOfColumns = tableDimensions[1]; /// m

                //Console.Write("********************* ");

                Console.WriteLine(numberOfColumns >= numberOfRows
                    ? numberOfColumns + 1
                    : numberOfRows + 1);
            }
        }
    }
}
