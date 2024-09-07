namespace A._Shortest_Path_with_Obstacle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1547/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                Console.ReadLine();

                List<int> coordinates_of_A = Console.ReadLine()!.Split().Select(int.Parse).ToList();
                List<int> coordinates_of_B = Console.ReadLine()!.Split().Select(int.Parse).ToList();
                List<int> coordinates_of_F = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int result = Math.Abs(coordinates_of_A[0] - coordinates_of_B[0]) +
                             Math.Abs(coordinates_of_A[1] - coordinates_of_B[1]);

                if (coordinates_of_A[0] == coordinates_of_B[0] &&
                    coordinates_of_A[0] == coordinates_of_F[0] &&
                    coordinates_of_F[1] > Math.Min(coordinates_of_A[1], coordinates_of_B[1]) &&
                    coordinates_of_F[1] < Math.Max(coordinates_of_A[1], coordinates_of_B[1]) ||

                    coordinates_of_A[1] == coordinates_of_B[1] &&
                    coordinates_of_A[1] == coordinates_of_F[1] &&
                    coordinates_of_F[0] > Math.Min(coordinates_of_A[0], coordinates_of_B[0]) &&
                    coordinates_of_F[0] < Math.Max(coordinates_of_A[0], coordinates_of_B[0]))
                {
                    result += 2;
                }

                //Console.Write("**************************************** ");

                Console.WriteLine(result);
            }
        }
    }
}
