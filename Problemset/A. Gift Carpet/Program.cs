namespace A._Gift_Carpet
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1862/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_m[0];
                int m = n_m[1];

                string vika = "vika";

                List<string> carpet = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    carpet.Add(Console.ReadLine()!);
                }

                int vika_index = 0;
                int found_chars_counter = 0;

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (carpet[j][i] == vika[vika_index])
                        {
                            vika_index++;
                            found_chars_counter++;
                            break;
                        }
                    }

                    if (found_chars_counter == 4)
                    {
                        break;
                    }
                }

                if (found_chars_counter == 4)
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
