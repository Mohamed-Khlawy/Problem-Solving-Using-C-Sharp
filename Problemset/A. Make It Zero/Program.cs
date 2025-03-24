namespace A._Make_It_Zero
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1869/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

                //Console.WriteLine("********************** ");

                if (arraySize % 2 == 0) /// Even Size
                {
                    Console.WriteLine(2);

                    Console.WriteLine($"1 {arraySize}\n1 {arraySize}");
                }

                else /// Odd Size
                {
                    Console.WriteLine(4);
                    Console.WriteLine
                        ($"1 {arraySize - 1}\n1 {arraySize - 1}\n" +
                        $"{arraySize - 1} {arraySize}\n{arraySize - 1} {arraySize}");
                }

                //Console.WriteLine("********************** ");
            }
        }
    }
}
