namespace A._Sum_of_Three
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1886/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                //Console.WriteLine("****************************");

                if (number < 7)
                {
                    Console.WriteLine("NO");
                }

                else
                {
                    int[] lowestSumOfThree = new int[] { 1, 2, 4 };

                    int subFrom7 = number - 7;

                    bool weCanDoIt = true;

                    /// Number isn't 7
                    if (subFrom7 != 0)
                    {
                        weCanDoIt = false;

                        for (int i = 0; i < 3; i++)
                        {
                            int newItem = subFrom7 + lowestSumOfThree[i];

                            if (!lowestSumOfThree.Contains(newItem) && newItem % 3 != 0)
                            {
                                lowestSumOfThree[i] = newItem;
                                weCanDoIt = true;
                                break;
                            }
                        }
                    }

                    Console.WriteLine(weCanDoIt
                        ? $"YES\n{string.Join(" ", lowestSumOfThree)}"
                        : "NO");
                }

                //Console.WriteLine("****************************");
            }
        }
    }
}
