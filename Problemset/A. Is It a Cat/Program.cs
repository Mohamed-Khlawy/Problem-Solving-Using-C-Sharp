namespace A._Is_It_a_Cat
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1800/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size_of_sound = int.Parse(Console.ReadLine()!);

                string sound = Console.ReadLine()!;

                sound = string.Concat(sound.ToLower());

                int first_m = sound.IndexOf('m');
                int first_e = sound.IndexOf('e');
                int first_o = sound.IndexOf('o');
                int first_w = sound.IndexOf('w');

                bool found_wrong_char = false;

                if (first_m == 0 &&
                    first_e != -1 &&
                    first_o != -1 &&
                    first_w != -1)
                {
                    for (int i = first_m; i < first_e; i++)
                    {
                        if (sound[i] != 'm')
                        {
                            found_wrong_char = true;
                        }
                    }

                    for (int i = first_e; i < first_o; i++)
                    {
                        if (sound[i] != 'e')
                        {
                            found_wrong_char = true;
                        }
                    }

                    for (int i = first_o; i < first_w; i++)
                    {
                        if (sound[i] != 'o')
                        {
                            found_wrong_char = true;
                        }
                    }

                    for (int i = first_w; i < sound.Count(); i++)
                    {
                        if (sound[i] != 'w')
                        {
                            found_wrong_char = true;
                        }
                    }

                    if (!found_wrong_char)
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
