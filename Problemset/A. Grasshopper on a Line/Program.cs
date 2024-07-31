namespace A._Grasshopper_on_a_Line
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1837/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] x_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int end_point = x_k[0];
                int constraint_of_jumps = x_k[1];

                List<int> jumps = new List<int>();

                if (end_point % constraint_of_jumps == 0)
                {
                    while (end_point % constraint_of_jumps == 0)
                    {
                        jumps.Add(1);
                        end_point--;
                    }

                    jumps.Add(end_point);
                }

                else
                {
                    jumps.Add(end_point);
                }

                //Console.WriteLine("*** ");

                Console.WriteLine(jumps.Count);

                for (int i = 0; i < jumps.Count; i++)
                {
                    if (i == jumps.Count - 1)
                    {
                        Console.WriteLine(jumps[i]);
                        break;
                    }

                    Console.Write(jumps[i] + " ");
                }
            }
        }
    }
}
