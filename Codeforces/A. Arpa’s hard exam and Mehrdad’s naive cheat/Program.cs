namespace A._Arpa_s_hard_exam_and_Mehrdad_s_naive_cheat
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/742/A
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine()!);

            if (power == 0)
            {
                Console.WriteLine(1);
                return;
            }

            long power_mod_4 = power % 4;

            switch (power_mod_4)
            {
                case 0:
                    Console.WriteLine(6);
                    break;
                case 1:
                    Console.WriteLine(8);
                    break;
                case 2:
                    Console.WriteLine(4);
                    break;
                case 3:
                    Console.WriteLine(2);
                    break;
            }
        }
    }
}
