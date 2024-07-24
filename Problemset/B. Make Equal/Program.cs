namespace B._Make_Equal
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1931/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_containers = int.Parse(Console.ReadLine()!);

                List<int> containers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int all_amount_of_water = containers.Sum();

                int common_amount_of_water = all_amount_of_water / number_of_containers;

                int give_water = 0;

                bool possiblity_to_make_them_equal = true;

                foreach (int container in containers)
                {
                    if (container > common_amount_of_water)
                    {
                        give_water += container - common_amount_of_water;
                    }

                    else if (container < common_amount_of_water)
                    {
                        int my_needing = common_amount_of_water - container;

                        if (give_water < my_needing)
                        {
                            possiblity_to_make_them_equal = false;
                        }

                        else
                        {
                            give_water -= my_needing;
                        }
                    }
                }

                //Console.Write("*** ");

                if (possiblity_to_make_them_equal)
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
