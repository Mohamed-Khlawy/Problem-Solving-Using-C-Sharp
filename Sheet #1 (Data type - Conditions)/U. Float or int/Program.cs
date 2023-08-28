namespace U._Float_or_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine()!);
            float dec = (float)(num - (int)num);
            if (dec == 0)
            {
                Console.WriteLine($"int {(int)num}");
            }
            else
            {
                Console.WriteLine($"float {(int)num} {dec}");
            }
        }
    }
}