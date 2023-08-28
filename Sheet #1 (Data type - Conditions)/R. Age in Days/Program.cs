namespace R._Age_in_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()!);
            int years = 0, months = 0;
            while (days >= 365)
            {
                days -= 365;
                years++;
            }
            while (days >= 30)
            {
                days -= 30;
                months++;
            }
            Console.WriteLine($"{years} years");
            Console.WriteLine($"{months} months");
            Console.WriteLine($"{days} days");
        }
    }
}