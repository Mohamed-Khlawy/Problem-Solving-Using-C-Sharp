namespace B._Expensive_Number
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2093/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] digits =
                    Console.ReadLine()!.Select(digit => int.Parse(digit.ToString())).ToArray();

                int zeroCounter = 0;
                bool foundDigit = false;
                int removedDigits = 0;

                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    if (digits[i] != 0)
                    {
                        foundDigit = true;
                    }

                    else if (foundDigit)
                    {
                        zeroCounter++;
                    }
                }

                removedDigits = digits.Length - (zeroCounter + 1);

                //Console.Write("***************************** ");

                Console.WriteLine(removedDigits);
            }
        }
    }
}
