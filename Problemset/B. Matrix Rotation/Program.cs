namespace B._Matrix_Rotation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1772/B

        static bool isMatrixBeautiful(List<int> matrix)
        {
            if (matrix[0] < matrix[1] &&
                matrix[3] < matrix[2] &&
                matrix[0] < matrix[3] &&
                matrix[1] < matrix[2])
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> matrix = new List<int>();

                for (int i = 0; i < 2; i++)
                {
                    List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                    if (i == 0)
                    {
                        matrix.Add(input[0]);
                        matrix.Add(input[1]);
                    }

                    else
                    {
                        matrix.Add(input[1]);
                        matrix.Add(input[0]);
                    }
                }

                int number_of_rotations = 0;

                while (!isMatrixBeautiful(matrix) && number_of_rotations < 4)
                {
                    int last_item = matrix[matrix.Count - 1];

                    matrix.RemoveAt(matrix.Count - 1);

                    matrix.Insert(0, last_item);

                    number_of_rotations++;
                }

                if (number_of_rotations == 4)
                {
                    Console.WriteLine("NO");
                }

                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
