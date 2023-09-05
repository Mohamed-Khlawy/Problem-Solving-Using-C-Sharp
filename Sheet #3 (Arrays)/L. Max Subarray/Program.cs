namespace L._Max_Subarray
{
    internal class Program
    {
        // It was hard and i used ChatGpt
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                // Loop for each starting index
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    int maxInSubarray = int.MinValue; // Initialize max to a very small value

                    // Loop for each ending index
                    for (int j = i; j < numbersArray.Length; j++)
                    {
                        // Calculate the maximum element in the subarray A[i-j]
                        maxInSubarray = Math.Max(maxInSubarray, numbersArray[j]);

                        //// Print the subarray A[i-j] and its maximum element
                        //Console.Write("Subarray [");
                        //for (int k = i; k <= j; k++)
                        //{
                        //    Console.Write(numbersArray[k]);
                        //    if (k < j)
                        //    {
                        //        Console.Write(", ");
                        //    }
                        //}
                        Console.Write(maxInSubarray + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}