namespace A._Multiplication_Table
{
    internal class Program
    {
        // Proplem Link: https://codeforces.com/problemset/problem/577/A
        static void Main(string[] args)
        {
            double[] arraySize_numberForSearch = Console.ReadLine()!.Split().Select(double.Parse).ToArray();
            double arraySize = arraySize_numberForSearch[0];
            double numberForSearch = arraySize_numberForSearch[1];

            int counterFornumberOccurences = 0;

            for (int i = 1; i <= arraySize; i++)
            {
                if (numberForSearch % i == 0)
                {
                    if (numberForSearch / i <= arraySize)
                    {
                        counterFornumberOccurences += 1;
                    }
                }
            }

            Console.WriteLine(counterFornumberOccurences);
        }
    }
}