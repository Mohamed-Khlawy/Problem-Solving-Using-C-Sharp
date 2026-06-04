namespace C._Assembly_via_Remainders
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1968/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] modArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                /// Can be 10000 instead of modArray.Max() + 1
                List<int> baseList = new List<int>() { modArray.Max() + 1 };

                for (int i = 0; i < arraySize - 1; i++)
                {
                    baseList.Add(modArray[i] + baseList[i]);
                }

                //Console.Write("************************ ");

                Console.WriteLine(string.Join(" ", baseList));
            }
        }
    }
}
