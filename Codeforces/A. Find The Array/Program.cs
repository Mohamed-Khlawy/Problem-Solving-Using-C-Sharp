namespace A._Find_The_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1550/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int requiredSum = int.Parse(Console.ReadLine()!);

                int minNuumberOfElements = 1;

                while (Math.Pow(minNuumberOfElements, 2) < requiredSum)
                {
                    minNuumberOfElements++;
                }

                #region Problem Note
                /// This is the solution of the problem maker on codeforces, 
                /// so to understand the solution go to the tutorial of the problem
                #endregion

                //Console.Write("************************************** ");

                Console.WriteLine(minNuumberOfElements);
            }
        }
    }
}
