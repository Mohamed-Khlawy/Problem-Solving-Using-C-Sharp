namespace A._Compare_T_Shirt_Sizes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1741/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<string> input = Console.ReadLine()!.Split().ToList();

                List<char> T_shirt_a = input[0].Select(c => char.Parse(c.ToString())).ToList();
                List<char> T_shirt_b = input[1].Select(c => char.Parse(c.ToString())).ToList();

                if (T_shirt_a.SequenceEqual(T_shirt_b))
                {
                    Console.WriteLine("=");
                }

                else
                {
                    switch (T_shirt_a[T_shirt_a.Count - 1])
                    {
                        case 'S':
                            switch (T_shirt_b[T_shirt_b.Count - 1])
                            {
                                case 'S':
                                    if (T_shirt_a.Where(x => x == 'X').Count() >
                                        T_shirt_b.Where(x => x == 'X').Count())
                                    {
                                        Console.WriteLine("<");
                                    }

                                    else
                                    {
                                        Console.WriteLine(">");
                                    }
                                    break;

                                case 'M':
                                    Console.WriteLine("<");
                                    break;

                                case 'L':
                                    Console.WriteLine("<");
                                    break;
                            }
                            break;

                        case 'M':
                            switch (T_shirt_b[T_shirt_b.Count - 1])
                            {
                                case 'S':
                                    Console.WriteLine(">");
                                    break;

                                case 'L':
                                    Console.WriteLine("<");
                                    break;
                            }
                            break;

                        case 'L':
                            switch (T_shirt_b[T_shirt_b.Count - 1])
                            {
                                case 'S':
                                    Console.WriteLine(">");
                                    break;

                                case 'M':
                                    Console.WriteLine(">");
                                    break;

                                case 'L':
                                    if (T_shirt_a.Where(x => x == 'X').Count() >
                                        T_shirt_b.Where(x => x == 'X').Count())
                                    {
                                        Console.WriteLine(">");
                                    }

                                    else
                                    {
                                        Console.WriteLine("<");
                                    }
                                    break;
                            }
                            break;
                    }
                }
            }
        }
    }
}
