namespace E._Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine()!;

            long summation = 0;

            for (int i = 0; i < number.Length; i++)
            {
                long num = long.Parse(number[i].ToString());
                summation += num;
            }

            Console.WriteLine(summation);
        }
    }
}