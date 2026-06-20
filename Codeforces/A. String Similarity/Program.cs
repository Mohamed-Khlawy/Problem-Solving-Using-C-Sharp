namespace A._String_Similarity
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1400/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string binaryString = Console.ReadLine()!;

                /// Using LINQ
                List<char> similarList = binaryString.Where((ch, index) => index % 2 == 0).ToList();

                #region Normal Way to take a char and let char in a string

                //for (int i = 0; i < binaryString.Length; i += 2)
                //{
                //    similarList.Add(binaryString[i]);
                //}

                #endregion

                //Console.Write("***************** ");

                Console.WriteLine(string.Join("", similarList));
            }
        }
    }
}
