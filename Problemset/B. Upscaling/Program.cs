using System.Text;

namespace B._Upscaling
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1950/B

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!.Trim());
            int[] testCases = new int[t];

            for (int i = 0; i < t; i++)
            {
                testCases[i] = int.Parse(Console.ReadLine()!.Trim());
            }

            StringBuilder result = new StringBuilder();

            foreach (int n in testCases)
            {
                var checkerboard = GenerateCheckerboard(n);
                foreach (var row in checkerboard)
                {
                    result.AppendLine(row);
                }
            }

            Console.Write(result.ToString());
        }

        static string[] GenerateCheckerboard(int n)
        {
            string[] checkerboard = new string[2 * n];

            for (int i = 0; i < 2 * n; i++)
            {
                StringBuilder row = new StringBuilder(2 * n);
                for (int j = 0; j < 2 * n; j++)
                {
                    if ((i / 2 + j / 2) % 2 == 0)
                    {
                        row.Append('#');
                    }
                    else
                    {
                        row.Append('.');
                    }
                }
                checkerboard[i] = row.ToString();
            }

            return checkerboard;
        }
    }
}
