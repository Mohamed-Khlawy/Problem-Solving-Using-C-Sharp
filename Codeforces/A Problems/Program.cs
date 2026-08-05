using System.Text;

namespace A_Problems
{
    internal class Program
    {
        public static int ReadInt() => int.Parse(Console.ReadLine()!);
        public static string LineOfStars() => "************************** ";
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                //Console.Write(LineOfStars());
            }
        }
    }
}