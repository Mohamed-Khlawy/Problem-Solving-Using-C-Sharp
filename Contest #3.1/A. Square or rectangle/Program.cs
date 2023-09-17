namespace A._Square_or_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[] width_height = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                if (width_height[0] == width_height[1])
                {
                    Console.WriteLine("Square");
                }
                else
                {
                    Console.WriteLine("Rectangle");
                }
            }
        }
    }
}