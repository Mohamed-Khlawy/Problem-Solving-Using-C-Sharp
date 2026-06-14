namespace Climbing_Stairs
{
    internal class Program
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            int first = 1;
            int second = 2;

            for (int i = 3; i <= n; i++)
            {
                int current = first + second;
                first = second;
                second = current;
            }

            return second;

            #region Using DB Array

            //int[] dp = new int[n+ 1];

            //dp[1] = 1;
            //dp[2] = 2;

            //for (int i = 3; i <= n; i++)
            //{
            //    dp[i] = dp[i - 1] + dp[i - 2];
            //}

            //return dp[n];
            
            #endregion
        }
        static void Main(string[] args)
        {
            int numberOfStairs = int.Parse(Console.ReadLine()!);

            Program program = new Program();

            Console.WriteLine(program.ClimbStairs(numberOfStairs));
        }
    }
}
