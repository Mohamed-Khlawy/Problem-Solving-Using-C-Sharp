namespace T._Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine()!);
            int cols = rows;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowElements = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            long sumOfPrimaryDiagonal = 0;
            long sumOfSecondaryDiagonal = 0;

            for (int i = 0; i < rows; i++)
            {
                sumOfPrimaryDiagonal += matrix[i, i];
            }

            int colIndex = cols - 1;
            for (int i = 0; i < rows; i++)
            {
                sumOfSecondaryDiagonal += matrix[i, colIndex];
                colIndex--;
            }

            Console.WriteLine(Math.Abs(sumOfPrimaryDiagonal - sumOfSecondaryDiagonal));
        }
    }
}