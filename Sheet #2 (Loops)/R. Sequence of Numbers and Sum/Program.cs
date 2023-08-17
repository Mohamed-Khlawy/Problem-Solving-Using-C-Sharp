namespace R._Sequence_of_Numbers_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string numbers = Console.ReadLine()!;
                string[] inputs = numbers.Split(' ');

                int number1 = int.Parse(inputs[0]);
                int number2 = int.Parse(inputs[1]);
                if(number1 <= 0 || number2 <= 0)
                {
                    break;
                }

                int sum = 0;

                for (int i = Math.Min(number1, number2); i <= Math.Max(number1, number2); i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.Write($"sum ={sum}");
                Console.WriteLine();
            }
        }
    }
}