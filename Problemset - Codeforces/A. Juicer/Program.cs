namespace A._Juicer
{
    internal class Program
    {
        // Probelm Link : https://codeforces.com/problemset/problem/709/A
        static void Main(string[] args)
        {
            int[] n_b_d = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int number_of_oranges = n_b_d[0];
            int max_orange_size = n_b_d[1];
            int max_waste_seciton = n_b_d[2];

            int counter_for_waste_section = 0;
            int counter_for_empiting_times = 0;

            List<int> oranges = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            for (int i = 0; i < number_of_oranges; i++)
            {
                if (oranges[i] <= max_orange_size)
                {
                    counter_for_waste_section += oranges[i];
                }

                if (counter_for_waste_section > max_waste_seciton)
                {
                    counter_for_waste_section = 0;
                    counter_for_empiting_times++;
                }
            }

            Console.WriteLine(counter_for_empiting_times);
        }
    }
}
