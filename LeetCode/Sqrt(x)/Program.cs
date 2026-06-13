namespace Sqrt_x_
{
    internal class Program
    {
        public int MySqrt(int x)
        {
            if (x < 2) return x;

            int left = 1;
            int right = x;
            int answer = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                long square = (long)mid * mid;

                if (square == x) return mid;

                else if (square < x)
                {
                    left = mid + 1;
                    answer = mid;
                }

                else if (square > x) right = mid - 1;
            }

            return answer;
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()!);

            Program program = new Program();

            int result = program.MySqrt(input);

            Console.WriteLine(result);
        }
    }
}
