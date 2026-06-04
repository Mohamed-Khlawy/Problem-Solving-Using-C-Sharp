namespace B._Square_or_Not
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2008/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int string_size = int.Parse(Console.ReadLine()!);

                string matrix = Console.ReadLine()!;

                double sqrt_of_size = Math.Sqrt(string_size);

                //Console.Write("*********************************** ");

                if (sqrt_of_size == Math.Floor(Math.Sqrt(string_size)) ||
                    sqrt_of_size == Math.Ceiling(Math.Sqrt(string_size)))
                {
                    bool is_Matrix_Beautiful = true;

                    for (int i = (int)sqrt_of_size;
                        i < string_size - sqrt_of_size;
                        i += (int)sqrt_of_size)
                    {
                        string sub_str = matrix.Substring(i, (int)sqrt_of_size);

                        if (sub_str.Where(x => x == '1').Count() != 2 ||
                            !sub_str.StartsWith('1') ||
                            sub_str[^1] != '1')
                        {
                            is_Matrix_Beautiful = false;
                            break;
                        }
                    }

                    if (is_Matrix_Beautiful)
                    {
                        Console.WriteLine("Yes");
                    }

                    else
                    {
                        Console.WriteLine("No");
                    }
                }

                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
