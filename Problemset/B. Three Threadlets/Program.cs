namespace B._Three_Threadlets
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1881/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] threadlets = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(threadlets);

                int threadletsIndex = 2;
                long cutsOperations = 0;
                bool weCutAllThreadlets = true;

                #region Problem Idea

                /// Cuts Operations mustn't exceed 3 cuts, 
                /// and the index mustn't reach zero,
                /// because the first threadlet is the reference for the other 2 threadlets,
                /// so we won't cut it for sure.

                #endregion

                while (threadletsIndex > 0)
                {
                    if (threadlets[threadletsIndex] % threadlets[0] == 0)
                    {
                        cutsOperations += (threadlets[threadletsIndex] / threadlets[0]) - 1;
                        threadletsIndex--;
                    }

                    else
                    {
                        weCutAllThreadlets = false;
                        break;
                    }
                }

                //Console.Write("*********************** ");

                Console.WriteLine(
                    (weCutAllThreadlets && cutsOperations <= 3 && threadletsIndex == 0)
                    ? "YES"
                    : "NO");
            }
        }
    }
}
