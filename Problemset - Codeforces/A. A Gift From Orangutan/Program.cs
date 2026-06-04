namespace A._A_Gift_From_Orangutan
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2030/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                int maxScore = (numbers.Max() - numbers.Min()) * (arraySize - 1);

                //Console.Write("********************** ");

                Console.WriteLine(maxScore);
            }
        }
    }
}
