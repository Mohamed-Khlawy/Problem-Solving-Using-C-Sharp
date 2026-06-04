namespace A._Little_Artem
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1333/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] gridDimensions =
                    Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int rows = gridDimensions[0];    // n
                int columns = gridDimensions[1]; // m

                List<char> rowCharsList = Enumerable.Repeat('B', columns - 1).ToList();

                string rowCharsString = string.Join("", rowCharsList);

                //Console.WriteLine("********************************");

                Console.WriteLine(rowCharsString + "W");

                for (int i = 1; i < rows; i++)
                {
                    Console.WriteLine(rowCharsString + "B");
                }

                //Console.WriteLine("********************************");
            }
        }
    }
}
