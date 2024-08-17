namespace A._Rudolf_and_the_Ticket
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1941/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int size_of_list1 = n_m_k[0];
                int size_of_list2 = n_m_k[1];
                int max_sum = n_m_k[2];

                List<int> list1 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> list2 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int number_of_ways = 0;

                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[i] < max_sum)
                    {
                        int diff = max_sum - list1[i];

                        number_of_ways += list2.Where(x => x <= diff).Count();
                    }
                }

                //Console.Write("*** ");
                Console.WriteLine(number_of_ways);
            }
        }
    }
}
