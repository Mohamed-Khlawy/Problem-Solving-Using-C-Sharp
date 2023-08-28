namespace H._Two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            double first = double.Parse(elements[0]);
            double second = double.Parse(elements[1]);

            double divide = (double)first / second;
            int div = (int)divide;
            double floor = Math.Floor(divide);
            double ceil = Math.Ceiling(divide);
            double round;
            if (Math.Abs(divide - div) >= .5)
            {
                round = ++div;
            }
            else
            {
                round = div;
            }


            Console.WriteLine($"floor {first} / {second} = {floor}");
            Console.WriteLine($"ceil {first} / {second} = {ceil}");
            Console.WriteLine($"round {first} / {second} = {round}");
        }
    }
}