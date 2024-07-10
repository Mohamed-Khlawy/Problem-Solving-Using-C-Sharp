namespace B._Arranging_Cats
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1921/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int num_boexes = int.Parse(Console.ReadLine()!);

                string curr_boxes = Console.ReadLine()!;
                string target_boxes = Console.ReadLine()!;

                int zero_one = 0;
                int one_zero = 0;

                for (int i = 0; i < num_boexes; i++)
                {
                    if (curr_boxes[i] != target_boxes[i])
                    {
                        if (curr_boxes[i] == '0')
                        {
                            zero_one++;
                        }

                        else
                        {
                            one_zero++;
                        }
                    }
                }

                //Console.Write("***");

                if (zero_one == one_zero)
                {
                    // Result is anyone of them, we will say (zero_one)

                    Console.WriteLine(zero_one);
                }

                else if (zero_one == 0 || one_zero == 0)
                {
                    // Result is the non-zero of them

                    if (zero_one == 0)
                    {
                        Console.WriteLine(one_zero);
                    }

                    else
                    {
                        Console.WriteLine(zero_one);
                    }
                }

                else // Both of them is greater than Zero
                {
                    // Result is the greatest of them

                    Console.WriteLine(Math.Max(zero_one, one_zero));
                }
            }
        }
    }
}
