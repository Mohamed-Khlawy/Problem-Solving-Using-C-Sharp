namespace C._Not_Adjacent_Matrix
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1520/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int matrixDimension = int.Parse(Console.ReadLine()!);

                //Console.WriteLine("*****************************");

                if (matrixDimension == 2)
                    Console.WriteLine(-1);

                else
                {
                    int[] matrixRow = new int[matrixDimension];

                    int rowIndex = 1;

                    while (rowIndex <= matrixDimension)
                    {
                        for (int i = 0; i < matrixDimension; i++)
                        {
                            matrixRow[i] = rowIndex + i * matrixDimension;
                        }

                        if (rowIndex % 2 == 0)
                        {
                            Array.Reverse(matrixRow);

                            (matrixRow[matrixDimension / 2], matrixRow[^1]) =
                                (matrixRow[^1], matrixRow[matrixDimension / 2]);
                        }

                        Console.WriteLine(string.Join(" ", matrixRow));

                        rowIndex++;
                    }
                }

                //Console.WriteLine("*****************************");
            }
        }
    }
}
