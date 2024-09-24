namespace B._Comparison_String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1837/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string str = Console.ReadLine()!;

                int max_substr = 0;

                for (int i = 0; i < size; i++)
                {
                    char i_char = str[i];

                    int sub = 1;

                    for (int j = i + 1; j < size; j++)
                    {
                        if (str[j] == i_char)
                        {
                            sub++;
                        }

                        else
                        {
                            i = j - 1;
                            break;
                        }
                    }

                    if (sub > max_substr)
                    {
                        max_substr = sub;
                    }
                }

                Console.WriteLine(max_substr + 1);
            }
        }
    }
}
