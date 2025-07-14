namespace A._Find_K_Distinct_Points_with_Fixed_Center
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1998/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int Xc = input[0]; // X-coordinate of the center
                int Yc = input[1]; // Y-coordinate of the center
                int k = input[2];  // Number of required points

                //Console.WriteLine("*************************************");

                for (int i = 1; i <= k / 2; i++)
                {
                    Console.WriteLine($"{Xc + i} {Yc}");
                    Console.WriteLine($"{Xc - i} {Yc}");
                }

                if (k % 2 == 1) // If k is odd, print the center point as well
                {
                    Console.WriteLine($"{Xc} {Yc}");
                }

                //Console.WriteLine("*************************************");
            }
        }
    }
}
