namespace A._Square
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1921/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> x_cordinates = new List<int>();
                List<int> y_cordinates = new List<int>();

                for (int i = 0; i < 4; i++)
                {
                    List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                    x_cordinates.Add(input[0]);
                    y_cordinates.Add(input[1]);
                }

                int x1 = x_cordinates[0];
                int x2 = 0;

                for (int i = 1; i < 4; i++)
                {
                    if (x_cordinates[i] != x1)
                    {
                        x2 = x_cordinates[i];
                        break;
                    }
                }

                int side_of_square = Math.Abs(x2 - x1);

                int area_of_square = side_of_square * side_of_square;

                //Console.Write("*** ");
                Console.WriteLine(area_of_square);
            }
        }
    }
}
