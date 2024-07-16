namespace C._Unique_Number
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1462/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> digits = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                int number = int.Parse(Console.ReadLine()!);

                List<int> unique = new List<int>();

                while (number > 0 && digits.Count > 0)
                {
                    if (number < 9 && unique.Where(x => x == number).Count() == 0)
                    {
                        unique.Add(number);

                        number -= number;
                    }

                    else
                    {
                        number -= digits[0];

                        unique.Add(digits[0]);

                        digits.RemoveAt(0);
                    }
                }

                if (number != 0)
                {
                    Console.WriteLine(-1);
                }

                else
                {
                    unique.Sort();

                    for (int i = 0; i < unique.Count; i++)
                    {
                        Console.Write(unique[i]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
