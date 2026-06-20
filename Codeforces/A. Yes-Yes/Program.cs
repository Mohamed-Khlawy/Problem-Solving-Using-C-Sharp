namespace A._Yes_Yes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1759/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string yes_string = Console.ReadLine()!;

                bool is_sub_of_yes = true;

                if (yes_string.Length == 1)
                {
                    if (yes_string[0] != 'Y' &&
                        yes_string[0] != 'e' &&
                        yes_string[0] != 's')
                    {
                        is_sub_of_yes = false;
                    }
                }

                else
                {
                    for (int i = 0; i < yes_string.Length - 1; i++)
                    {
                        if ((yes_string[i] == 'Y' && yes_string[i + 1] != 'e') ||
                            (yes_string[i] == 'e' && yes_string[i + 1] != 's') ||
                            (yes_string[i] == 's' && yes_string[i + 1] != 'Y') ||
                            (yes_string[i] != 'Y' && yes_string[i] != 'e' && yes_string[i] != 's'))
                        {
                            is_sub_of_yes = false;
                            break;
                        }
                    }
                }

                //Console.Write("******************************* ");

                if (is_sub_of_yes)
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
