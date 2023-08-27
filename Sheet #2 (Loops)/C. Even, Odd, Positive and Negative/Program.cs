namespace C._Even__Odd__Positive_and_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!), even = 0, odd = 0, positive = 0, negative = 0;
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(elements[i]);
                if (number % 2 == 0 || number == 0)
                {
                    even++;
                    if (number > 0)
                        positive++;
                    else if (number < 0)
                        negative++;
                }
                else
                {
                    odd++;
                    if (number > 0)
                        positive++;
                    else
                        negative++;
                }
            }
            Console.WriteLine($"Even: {even}");
            Console.WriteLine($"Odd: {odd}");
            Console.WriteLine($"Positive: {positive}");
            Console.WriteLine($"Negative: {negative}");
        }
    }
}