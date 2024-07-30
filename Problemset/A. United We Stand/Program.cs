namespace A._United_We_Stand
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1859/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int max_number = numbers.Max();

                int number_of_occurrences_for_max_number =
                    numbers.Where(x => x == max_number).Count();

                if (number_of_occurrences_for_max_number == size)
                {
                    //Console.WriteLine("********");
                    Console.WriteLine(-1);
                }

                else
                {
                    List<int> list_B = new List<int>();
                    List<int> list_C = new List<int>();

                    for (int i = 0; i < size; i++)
                    {
                        if (numbers[i] != max_number)
                        {
                            list_B.Add(numbers[i]);
                        }

                        else
                        {
                            list_C.Add(numbers[i]);
                        }
                    }

                    //Console.WriteLine("********");

                    Console.WriteLine(list_B.Count + " " + list_C.Count);

                    for (int i = 0; i < list_B.Count; i++)
                    {
                        if (i == list_B.Count - 1)
                        {
                            Console.Write(list_B[i]);
                        }
                        else
                        {
                            Console.Write(list_B[i] + " ");
                        }
                    }

                    Console.WriteLine();

                    for (int i = 0; i < list_C.Count; i++)
                    {
                        if (i == list_C.Count - 1)
                        {
                            Console.Write(list_C[i]);
                        }
                        else
                        {
                            Console.Write(list_C[i] + " ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
