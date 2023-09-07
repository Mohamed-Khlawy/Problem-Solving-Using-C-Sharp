namespace O._Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberIndex = int.Parse(Console.ReadLine()!);
            List<long> fibonacci = new List<long>(numberIndex);
            fibonacci.Add(0);
            fibonacci.Add(1);

            for (int i = 2; i < numberIndex; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }

            Console.WriteLine(fibonacci[numberIndex - 1]);
        }
    }
}