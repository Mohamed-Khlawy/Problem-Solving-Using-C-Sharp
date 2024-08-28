namespace A._Desorting
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1853/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<long> list1 = Console.ReadLine()!.Split().Select(long.Parse).ToList();

                long number_of_operations = 0;

                //Console.Write("*** ");

                int min_difference = int.MaxValue;

                for (int i = 1; i < list1.Count; i++)
                {
                    if (list1[i] >= list1[i - 1] &&
                        list1[i] - list1[i - 1] < min_difference)
                    {
                        min_difference = (int)(list1[i] - list1[i - 1]);

                        number_of_operations =
                            (long)Math.Floor(((double)list1[i] - (double)list1[i - 1]) / 2) + 1;
                    }

                    else if (list1[i] < list1[i - 1])
                    {
                        number_of_operations = 0;
                        break;
                    }
                }

                Console.WriteLine(number_of_operations);
            }
        }
    }
}
