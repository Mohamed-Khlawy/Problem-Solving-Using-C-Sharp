namespace S._Search_In_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] row_col = Console.ReadLine()!.Split().Select(int.Parse).ToArray();// User input
            int row = row_col[0];
            int col = row_col[1];
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                int[] rowElements = Console.ReadLine()!.Split().Select(int.Parse).ToArray();//User input

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            int numberForSearch = int.Parse(Console.ReadLine()!);//User input
            bool foundTheNumber = false;

            foreach (int rowElement in matrix) // New way for searching with (foreach) loop 
            {
                if (rowElement == numberForSearch)
                {
                    foundTheNumber = true;
                    break;
                }
            }

            //for (int i = 0; i < row; i++) // Simble way with nested loop searching
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        if (matrix[i, j] == numberForSearch)
            //        {
            //            foundTheNumber = true;
            //            break;
            //        }
            //    }
            //}

            if (foundTheNumber)
            {
                Console.WriteLine("will not take number");
            }
            else
            {
                Console.WriteLine("will take number");
            }
        }
    }
}