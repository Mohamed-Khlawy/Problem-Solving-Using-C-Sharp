namespace A._Jagged_Swaps
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1896/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutaionSize = int.Parse(Console.ReadLine()!);

                List<int> permutaionList = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                //Console.Write("********************************** ");

                #region Problem Note
                /// If the first element in the Permutation List is (1), 
                /// so you can make it sorted always and in any case, 
                /// because we can't swap the first element so we need it always to be 1.
                #endregion

                Console.WriteLine(permutaionList[0] == 1 ? "YES" : "NO");
            }
        }
    }
}
