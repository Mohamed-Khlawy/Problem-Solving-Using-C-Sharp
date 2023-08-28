namespace E._Area_of_a_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine()!);
            double area = 3.141592653 * (r * r);
            Console.WriteLine(area.ToString());
        }
    }
}