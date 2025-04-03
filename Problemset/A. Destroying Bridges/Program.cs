namespace A._Destroying_Bridges
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1944/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] problemDescription = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                int numberOfIslands = problemDescription[0]; /// n
                int destroyedBridges = problemDescription[1]; /// k

                //Console.Write("******************** ");

                #region Problem Idea

                /// We can visit all islands if and only if the number of destroyed bridges
                /// is less than number of islands minus one.
                /// Else we will be stay in the first island and won't visit any other islands.

                #endregion

                Console.WriteLine(destroyedBridges >= numberOfIslands - 1
                    ? 1
                    : numberOfIslands);
            }
        }
    }
}
