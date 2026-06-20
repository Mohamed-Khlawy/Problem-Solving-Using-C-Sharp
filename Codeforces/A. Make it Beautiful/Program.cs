namespace A._Make_it_Beautiful
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1783/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                //Console.WriteLine("*************************************** ");

                if (numbers[0] != numbers[numbers.Count - 1])
                {
                    Console.WriteLine("YES");

                    Console.Write(numbers[numbers.Count - 1] + " ");

                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        if (i == numbers.Count - 2)
                        {
                            Console.WriteLine(numbers[i]);
                        }

                        else
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }

                //Console.WriteLine("*************************************** ");
            }
        }
    }
}
