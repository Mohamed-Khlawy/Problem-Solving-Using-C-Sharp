namespace C._Find_and_Replace
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1807/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string str = Console.ReadLine()!;

                Dictionary<char, int> dict = new Dictionary<char, int>();

                bool can_make_str_binary = true;

                for (int i = 0; i < size; i++)
                {
                    if (dict.TryGetValue(str[i], out int value))
                    {
                        if (i % 2 != value)
                        {
                            can_make_str_binary = false;
                            break;
                        }
                    }

                    else
                    {
                        dict.Add(str[i], i % 2);
                    }
                }

                if (can_make_str_binary)
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
