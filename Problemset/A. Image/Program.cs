namespace A._Image
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1721/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<char> firstRow = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();
                List<char> secondRow = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();

                HashSet<char> differentColors = new HashSet<char>();

                for (int i = 0; i < firstRow.Count; i++)
                {
                    differentColors.Add(firstRow[i]);
                }

                for (int i = 0; i < secondRow.Count; i++)
                {
                    differentColors.Add(secondRow[i]);
                }

                //Console.Write("********************* ");

                Console.WriteLine(differentColors.Count - 1);
            }
        }
    }
}
