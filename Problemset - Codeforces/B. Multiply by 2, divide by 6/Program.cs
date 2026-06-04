namespace B._Multiply_by_2__divide_by_6
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1374/B
        //This was hard and i saw it's Tutorial
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);
                int copy_number = number;
                int counterOf2 = 0;
                int counterOf3 = 0;

                while (copy_number % 2 == 0)
                {
                    copy_number /= 2;
                    counterOf2++;
                }
                while (copy_number % 3 == 0)
                {
                    copy_number /= 3;
                    counterOf3++;
                }

                if (copy_number == 1 && counterOf2 <= counterOf3)
                {
                    Console.WriteLine(2 * counterOf3 - counterOf2);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}