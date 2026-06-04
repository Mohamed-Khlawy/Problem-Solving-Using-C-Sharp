namespace A._Die_Roll
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/9/A
        static void Main(string[] args)
        {
            string yakko_wakko = Console.ReadLine()!;
            string[] yakko_wakkoArray = yakko_wakko.Split(' ');

            int yakko = int.Parse(yakko_wakkoArray[0]);
            int wakko = int.Parse(yakko_wakkoArray[1]);

            int dot = 6 - Math.Max(yakko, wakko) + 1;

            switch (dot)
            {
                //max=6
                case 1:
                    Console.WriteLine("1/6");
                    break;

                //max=5
                case 2:
                    Console.WriteLine("1/3");
                    break;

                //max=4
                case 3:
                    Console.WriteLine("1/2");
                    break;

                //max=3
                case 4:
                    Console.WriteLine("2/3");
                    break;

                //max=2
                case 5:
                    Console.WriteLine("5/6");
                    break;

                //max=1
                case 6:
                    Console.WriteLine("1/1");
                    break;
            }
        }
    }
}