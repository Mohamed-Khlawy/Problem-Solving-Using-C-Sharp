namespace J._Primes_from_1_to_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);
            bool prime;
            for (int i = 2; i <= number; i++)
            {
                prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}