namespace B._Vlad_and_Shapes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1926/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int grid_size = int.Parse(Console.ReadLine()!);

                List<string> grid = new List<string>(grid_size);

                for (int i = 0; i < grid_size; i++)
                {
                    grid.Add(Console.ReadLine()!);
                }

                // True ==> SQUARE, False ==> TRIANGLE 
                bool triangle_or_square = true;

                for (int i = 0; i < grid_size; i++)
                {
                    int is_there_a_triangle_head = grid[i].Where(x => x == '1').Count();

                    // This means we found the head of the triangle,
                    // so we have a triangle not square
                    if (is_there_a_triangle_head == 1)
                    {
                        triangle_or_square = false;
                        break;
                    }

                    // If zero or more than one, no matter, there is no head
                }

                //Console.Write("*** ");

                if (triangle_or_square)
                {
                    Console.WriteLine("SQUARE");
                }

                else
                {
                    Console.WriteLine("TRIANGLE");
                }
            }
        }
    }
}
