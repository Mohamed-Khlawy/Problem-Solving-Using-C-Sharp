namespace A._Special_Characters
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1948/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                //Console.Write("**************************************** ");

                if (size % 2 == 0)
                {
                    List<char> chars = new List<char>();

                    for (int i = 0; i < size / 2; i++)
                    {
                        chars.Add(alphabet[i]);
                        chars.Add(alphabet[i]);
                    }

                    string final_str = new string(chars.ToArray());

                    Console.WriteLine("YES");
                    Console.WriteLine(final_str);
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
