namespace E._Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[n];

            string s = Console.ReadLine()!;
            string[] inputs = s.Split(' ');
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(inputs[i]);
            }
            Console.WriteLine(numbers.Max());
        }
    }
}