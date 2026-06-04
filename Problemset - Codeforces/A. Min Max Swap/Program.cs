namespace A._Min_Max_Swap
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1631/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> list1 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> list2 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int max1 = 0;
                int max2 = 0;

                for (int i = 0; i < size; i++)
                {
                    if (list1[i] < list2[i])
                    {
                        (list1[i], list2[i]) = (list2[i], list1[i]);
                    }

                    if (list1[i] > max1)
                    {
                        max1 = list1[i];
                    }

                    if (list2[i] > max2)
                    {
                        max2 = list2[i];
                    }
                }

                //Console.Write("******************************************* ");

                Console.WriteLine(max1 * max2);
            }
        }
    }
}
