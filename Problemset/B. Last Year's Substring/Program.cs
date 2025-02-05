namespace B._Last_Year_s_Substring
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1462/B
        public static void IsThis2020(List<int> year, ref bool weFoundIt)
        {
            string yearStr = string.Join("", year);

            weFoundIt = yearStr.CompareTo("2020") == 0;
        }

        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int strSize = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!
                                   .Select(number => int.Parse(number.ToString()))
                                   .ToList();

                int numbersToRemove = strSize - 4; /// Because (2020) has 4 numbers only

                bool weFoundIt = false;

                if (numbersToRemove != 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        List<int> tempNumbers = new List<int>(numbers);

                        tempNumbers.RemoveRange(i, numbersToRemove);

                        IsThis2020(tempNumbers, ref weFoundIt);

                        if (weFoundIt) break;
                    }
                }

                else /// the strSize equal to 4, so check for 2020 immediately
                {
                    IsThis2020(numbers, ref weFoundIt);
                }

                //Console.Write("*************************** ");

                Console.WriteLine(weFoundIt ? "YES" : "NO");
            }
        }
    }
}
