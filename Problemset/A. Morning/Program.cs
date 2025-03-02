namespace A._Morning
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1883/A
        public static int CalculateSecondsInThisMove(int currentPosition, int previousPosition)
        {
            return Math.Abs(currentPosition - previousPosition) + 1;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> pinCode =
                    Console.ReadLine()!.Select(digit => int.Parse(digit.ToString())).ToList();

                pinCode.Insert(0, 1); /// Because the cursor stand on 1 initially

                int minSeconds = 0;

                for (int i = 1; i < pinCode.Count; i++)
                {
                    if (pinCode[i] == 0) /// Zero here will act as (10)
                    {
                        pinCode[i] = 10;

                        minSeconds +=
                            CalculateSecondsInThisMove(pinCode[i], pinCode[i - 1]);
                    }

                    else
                    {
                        minSeconds +=
                            CalculateSecondsInThisMove(pinCode[i], pinCode[i - 1]);
                    }
                }

                //Console.Write("*************************** ");

                Console.WriteLine(minSeconds);
            }
        }
    }
}
