namespace D._Fixed_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pass = int.Parse(Console.ReadLine()!);
            while (pass != 1999)
            {
                Console.WriteLine("Wrong");
                pass = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Correct");
        }
    }
}