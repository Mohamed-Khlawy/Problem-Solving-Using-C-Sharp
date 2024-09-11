namespace B._Decode_String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1729/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> code = Console.ReadLine()!.Select(x => int.Parse(x.ToString())).ToList();

                List<char> str = new List<char>();

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                for (int i = code.Count - 1; i >= 0; i--)
                {
                    if (code[i] == 0)
                    {
                        string sub = code[i - 2].ToString();
                        sub += code[i - 1].ToString();

                        int sub_code = int.Parse(sub);

                        str.Add(alphabet[sub_code - 1]);

                        i -= 2;
                    }

                    else
                    {
                        str.Add(alphabet[code[i] - 1]);
                    }
                }

                str.Reverse();

                //Console.Write("**************************************** ");

                for (int i = 0; i < str.Count; i++)
                {
                    Console.Write(str[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
