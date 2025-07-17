namespace A._Prime_Deletion
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1861/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] stringDigits = Console.ReadLine()!.ToCharArray();

                char[] resultingPrimeNumber = new char[2];

                #region Problem Idea
                /// We will search for either 19 or 91,
                /// because these 2 numbers are primes
                /// and one of them must be there in the stringl
                #endregion

                for (int i = 0; i < stringDigits.Length; i++)
                {
                    if (stringDigits[i] == '1')
                    {
                        resultingPrimeNumber[0] = '1';
                        resultingPrimeNumber[1] = '9';
                        break;
                    }

                    else if (stringDigits[i] == '9')
                    {
                        resultingPrimeNumber[0] = '9';
                        resultingPrimeNumber[1] = '1';
                        break;
                    }
                }

                //Console.Write("************************** ");

                Console.WriteLine(string.Join("", resultingPrimeNumber));
            }
        }
    }
}
