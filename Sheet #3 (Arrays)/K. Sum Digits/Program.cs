namespace K._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            string numbers = Console.ReadLine()!;

            long sumOfNumbers = 0;

            for (int i = 0; i < size; i++)
            {
                sumOfNumbers += long.Parse(numbers[i].ToString());
            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}