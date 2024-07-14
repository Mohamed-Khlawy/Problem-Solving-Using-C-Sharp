namespace A._Polycarp_and_Sums_of_Subsequences
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1618/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                List<int> result = new List<int>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        for (int k = j + 1; k < numbers.Length; k++)
                        {
                            if (numbers[i] + numbers[j] + numbers[k] == numbers[numbers.Length - 1])
                            {
                                result.Add(numbers[i]);
                                result.Add(numbers[j]);
                                result.Add(numbers[k]);

                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write(result[i]);

                    if (i != result.Count - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
