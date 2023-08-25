namespace F._Break_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine()!);

            string input = Console.ReadLine()!;
            string[] inputArray = input.Split(' ');

            long[] divideCounter = new long[cases];

            for (int i = 0; i < cases; i++)
            {
                long number = long.Parse(inputArray[i]);
                long counter = 0; //To calculate number of divides for each number
                while (number % 2 == 0) //We devide until we get first odd number not divisible, then we stop
                {
                    number /= 2;
                    counter++;
                }
                divideCounter[i] = counter;
            }

            Console.WriteLine(divideCounter.Max());
        }
    }
}