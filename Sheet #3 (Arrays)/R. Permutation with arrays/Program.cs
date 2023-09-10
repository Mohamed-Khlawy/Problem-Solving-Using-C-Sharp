namespace R._Permutation_with_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] firstArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Array.Sort(firstArray);
            Array.Sort(secondArray);
            bool notPermutation = false;

            for (int i = 0; i < size; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    notPermutation = true;
                    break;
                }
            }

            if (!notPermutation)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}