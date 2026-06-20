namespace C._Combination_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutationSize = int.Parse(Console.ReadLine()!);

                // If the size of the permutation is even, then we cannot create a valid permutation.
                if (permutationSize % 2 == 0)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                bool first = true;

                // We can always create a valid permutation,
                // by placing odd numbers first and then even numbers.
                // First loop for adding odd numbers to the permutation.
                for (int i = 1; i <= permutationSize; i += 2)
                {
                    if (!first) Console.Write(' ');
                    Console.Write(i);
                    first = false;
                }

                // Second loop for adding even numbers to the permutation.
                for (int i = 2; i <= permutationSize; i += 2)
                {
                    Console.Write(' ');
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}
