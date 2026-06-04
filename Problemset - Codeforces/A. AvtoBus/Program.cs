namespace A._AvtoBus
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1679/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long numberOfWheels = long.Parse(Console.ReadLine()!);

                //Console.Write("************************ ");

                if (numberOfWheels % 2 == 0 && numberOfWheels != 2)
                {
                    long minBuses = (long)Math.Ceiling((decimal)numberOfWheels / 6);
                    long maxBuses = (long)Math.Floor((decimal)numberOfWheels / 4);

                    Console.WriteLine(minBuses + " " + maxBuses);
                }

                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
