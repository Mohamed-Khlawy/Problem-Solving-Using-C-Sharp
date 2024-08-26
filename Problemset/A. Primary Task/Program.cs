namespace A._Primary_Task
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2000/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<char> integer = Console.ReadLine()!.Select(s => char.Parse(s.ToString())).ToList();

                if (integer.Count >= 3)
                {
                    if (integer[0] == '1' && integer[1] == '0')
                    {
                        if (integer[2] == '0')
                        {
                            Console.WriteLine("NO");
                        }

                        else if (integer[2] == '1')
                        {
                            if (integer.Count > 3)
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
                            Console.WriteLine("YES");
                        }
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
