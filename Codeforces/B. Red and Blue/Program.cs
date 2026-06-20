namespace B._Red_and_Blue
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1469/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int list1Size = int.Parse(Console.ReadLine()!); /// n

                List<int> list1 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int list2Size = int.Parse(Console.ReadLine()!); /// m

                List<int> list2 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int maxValue1 = int.MinValue;
                int maxValue2 = int.MinValue;

                int totalMaxValue = 0;

                int tempValue1 = 0;
                int tempValue2 = 0;

                for (int i = 0; i < list1Size; i++)
                {
                    tempValue1 += list1[i];

                    maxValue1 = tempValue1 > maxValue1 ? tempValue1 : maxValue1;
                }

                for (int i = 0; i < list2Size; i++)
                {
                    tempValue2 += list2[i];

                    maxValue2 = tempValue2 > maxValue2 ? tempValue2 : maxValue2;
                }

                totalMaxValue = maxValue1 + maxValue2;

                //Console.Write("********************** ");

                Console.WriteLine(Math.Max(0,
                    Math.Max(totalMaxValue, Math.Max(maxValue1, maxValue2))));
            }
        }
    }
}
