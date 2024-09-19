namespace B._Plus_Minus_Split
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1919/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string operators_string = Console.ReadLine()!;

                int plus_counter = 0;
                int minus_counter = 0;

                for (int i = 0; i < size; i++)
                {
                    if (operators_string[i] == '+')
                    {
                        if (minus_counter == 0)
                        {
                            plus_counter++;
                        }

                        else
                        {
                            minus_counter--;
                        }
                    }

                    else if (operators_string[i] == '-')
                    {
                        if (plus_counter == 0)
                        {
                            minus_counter++;
                        }

                        else
                        {
                            plus_counter--;
                        }
                    }
                }

                //Console.Write("********************************** ");

                if (plus_counter == 0 && minus_counter > 0)
                {
                    Console.WriteLine(minus_counter);
                }

                else if (plus_counter > 0 && minus_counter == 0)
                {
                    Console.WriteLine(plus_counter);
                }

                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
