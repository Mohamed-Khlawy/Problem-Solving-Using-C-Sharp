namespace H._One_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            if (n == 0 || n == 1)
            {
                Console.WriteLine("NO");
                return;
            }
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}