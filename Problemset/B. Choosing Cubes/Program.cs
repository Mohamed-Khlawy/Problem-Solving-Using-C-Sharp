namespace B._Choosing_Cubes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1980/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_f_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_f_k[0];
                int f = n_f_k[1];
                int k = n_f_k[2];

                List<int> cubes = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int f_value = cubes[f - 1];

                cubes.Sort();

                cubes.Reverse();

                int total_f_in_cubes = cubes.Where(x => x == f_value).Count();

                int total_f_in_sub_cubes = 0;

                for (int i = 0; i < k; i++)
                {
                    if (cubes[i] == f_value)
                    {
                        total_f_in_sub_cubes++;
                    }
                }

                //Console.Write("***");

                if (total_f_in_sub_cubes < total_f_in_cubes && total_f_in_sub_cubes != 0)
                {
                    Console.WriteLine("MAYBE");
                }

                else if (total_f_in_sub_cubes == total_f_in_cubes)
                {
                    Console.WriteLine("YES");
                }

                else if (total_f_in_sub_cubes == 0)
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
