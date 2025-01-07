namespace A._Doremy_s_Paint_3
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1890/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int counter_for_different_numbers = 0;

                int first_number = 0;

                int counter_for_first_number = 0;

                int second_number = 0;

                int counter_for_second_number = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0) // This is first different number
                    {
                        first_number = numbers[i];
                        counter_for_first_number++;

                        counter_for_different_numbers++;
                    }

                    else
                    {
                        if (numbers[i] == first_number) // Anothr occurence for first
                        {
                            counter_for_first_number++;
                        }

                        else if (second_number == 0) // This is second differnt number
                        {
                            second_number = numbers[i];
                            counter_for_second_number++;

                            counter_for_different_numbers++;
                        }

                        else if (numbers[i] == second_number) // Another occurence for second
                        {
                            counter_for_second_number++;
                        }

                        else // We found third different number
                        {
                            counter_for_different_numbers++;
                            break;
                        }
                    }
                }

                //Console.Write("**************************************** ");

                if (counter_for_different_numbers <= 2 &&
                    (counter_for_first_number == counter_for_second_number ||
                    Math.Abs(counter_for_first_number - counter_for_second_number) == 1 ||
                    Math.Abs(counter_for_first_number - counter_for_second_number) == size))
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
