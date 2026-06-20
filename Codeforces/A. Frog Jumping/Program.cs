namespace A._Frog_Jumping
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1077/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                double[] a_b_k = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

                double right_units = a_b_k[0];
                double left_units = a_b_k[1];
                double number_of_jumps = a_b_k[2];

                long diff_between_units = (long)(right_units - left_units);

                long half_of_jumps = (long)Math.Floor(number_of_jumps / 2);

                long final_position = 0;


                if (number_of_jumps % 2 != 0) // Jumps is ODD
                {
                    final_position = (diff_between_units * half_of_jumps) + (long)right_units;
                }

                else // Jumps is EVEN
                {
                    final_position = diff_between_units * half_of_jumps;
                }

                //Console.Write("****************************************** ");

                Console.WriteLine(final_position);
            }
        }
    }
}
