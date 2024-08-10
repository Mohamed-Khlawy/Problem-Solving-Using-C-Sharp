namespace C._Minimum_Varied_Number
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1714/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                List<int> digts = new List<int>();

                for (int i = 9; i >= 1; i--)
                {
                    if (number - i > 0)
                    {
                        digts.Add(i);
                        number -= i;
                    }

                    else
                    {
                        digts.Add(number);
                        break;
                    }
                }

                digts.Reverse();

                string result = string.Join(string.Empty, digts);

                Console.WriteLine(result);
            }
        }
    }
}
