namespace L._GCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] inputs = s.Split(' ');
            int number1 = int.Parse(inputs[0]);
            int number2 = int.Parse(inputs[1]);

            int minNumber = Math.Min(number1, number2);
            int maxNumber = Math.Max(number1, number2);
            List<int> minNumberDivisors = new List<int>();
            int index = 0;
            for (int i = 1; i <= minNumber; i++)
            {
                if (minNumber % i == 0)
                {
                    minNumberDivisors.Add(i);
                    index++;
                }
            }
            for (int i = minNumberDivisors.Count - 1; i >= 0; i--)
            {
                if (maxNumber % minNumberDivisors[i] == 0)
                {
                    Console.WriteLine(minNumberDivisors[i]);
                    return;
                }
            }
        }
    }
}