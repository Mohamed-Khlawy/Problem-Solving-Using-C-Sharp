namespace C._Rudolf_and_the_Ugly_String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1941/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string word = Console.ReadLine()!;

                int min_delets = 0;

                while (word.Contains("mapie") == true)
                {
                    int index = word.IndexOf("mapie");
                    word = word.Remove(index + 5 / 2, 1);
                    min_delets++;
                }

                while (word.Contains("pie") == true)
                {
                    int index = word.IndexOf("pie");
                    word = word.Remove(index + 3 / 2, 1);
                    min_delets++;
                }

                while (word.Contains("map") == true)
                {
                    int index = word.IndexOf("map");
                    word = word.Remove(index + 3 / 2, 1);
                    min_delets++;
                }

                //Console.Write("*** ");
                Console.WriteLine(min_delets);
            }
        }
    }
}
