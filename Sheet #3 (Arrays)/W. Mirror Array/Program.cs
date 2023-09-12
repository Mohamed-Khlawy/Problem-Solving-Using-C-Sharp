namespace W._Mirror_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] N_M = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int rows = N_M[0];
            int cols = N_M[1];
            int[,] mirrorArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowElements = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    mirrorArray[i, j] = rowElements[cols - j - 1];
                }
            }

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < cols; ++j)
                {
                    Console.Write(mirrorArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}