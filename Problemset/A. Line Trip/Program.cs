namespace A._Line_Trip
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1901/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_x = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_gas_stations = n_x[0];
                int final_point = n_x[1];

                List<int> gas_stations = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                gas_stations.Insert(0, 0);

                int min_volume = 0;

                for (int i = 1; i < gas_stations.Count; i++)
                {
                    int volume = gas_stations[i] - gas_stations[i - 1];

                    if (volume > min_volume)
                    {
                        min_volume = volume;
                    }

                    if (i == gas_stations.Count - 1)
                    {
                        int last_index = final_point + (final_point - gas_stations[i]);

                        int last_volume = last_index - gas_stations[i];

                        if (last_volume > min_volume)
                        {
                            min_volume = last_volume;
                        }
                    }
                }

                //Console.Write("************************************* ");

                Console.WriteLine(min_volume);
            }
        }
    }
}
