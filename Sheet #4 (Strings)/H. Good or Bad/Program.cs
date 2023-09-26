namespace H._Good_or_Bad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                string word = Console.ReadLine()!;

                if (word.Contains("010") || word.Contains("101"))
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("Bad");
                }
            }
        }
    }
}