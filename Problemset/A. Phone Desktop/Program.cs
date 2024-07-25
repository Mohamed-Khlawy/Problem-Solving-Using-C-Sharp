namespace A._Phone_Desktop
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1974/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] x_y = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int x = x_y[0];
                int y = x_y[1];

                int max_screens_for_y = (int)Math.Ceiling((double)y / 2);

                int reminding_cells_for_x = (max_screens_for_y * 15) - (y * 4);

                //Console.Write("*** ");

                if (x <= reminding_cells_for_x)
                {
                    Console.WriteLine(max_screens_for_y);
                    continue;
                }

                else
                {
                    int reminding_x_apps = x - reminding_cells_for_x;

                    int final_result = max_screens_for_y +
                                    (int)Math.Ceiling((double)reminding_x_apps / 15);

                    Console.WriteLine(final_result);
                }
            }
        }
    }
}
