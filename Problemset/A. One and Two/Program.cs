namespace A._One_and_Two
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1788/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int counter_of_2 = numbers.Where(x => x == 2).Count();

                //Console.Write("************************************ ");

                if (counter_of_2 % 2 == 0 && counter_of_2 != 0)
                {
                    int half_counter = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == 2)
                        {
                            half_counter++;

                            if (half_counter == counter_of_2 / 2)
                            {
                                Console.WriteLine(i + 1);
                                break;
                            }
                        }
                    }
                }

                else if (counter_of_2 == 0)
                {
                    Console.WriteLine(1);
                }

                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
