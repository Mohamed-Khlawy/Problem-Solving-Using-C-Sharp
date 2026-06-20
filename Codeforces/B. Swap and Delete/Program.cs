namespace B._Swap_and_Delete
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1913/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string intial_str = Console.ReadLine()!;

                //List<char> resulting_str = new List<char>();

                int zero_counter = intial_str.Where(c => c == '0').Count();

                int one_counter = intial_str.Where(c => c == '1').Count();

                int resulting_str_size = 0;

                //Console.Write("*********************************** ");

                while (zero_counter > 0 || one_counter > 0)
                {
                    if (intial_str[resulting_str_size] == '1' && zero_counter > 0)
                    {
                        //resulting_str.Add('0');
                        resulting_str_size++;
                        zero_counter--;
                    }

                    else if (intial_str[resulting_str_size] == '0' && one_counter > 0)
                    {
                        //resulting_str.Add('1');
                        resulting_str_size++;
                        one_counter--;
                    }

                    else
                    {
                        break;
                    }
                }

                //Console.WriteLine(intial_str.Length - resulting_str.Count);

                // For Space Complexity we won't make List of chars
                // and solve it with counter of chars in resulting string
                Console.WriteLine(intial_str.Length - resulting_str_size);
            }
        }
    }
}
