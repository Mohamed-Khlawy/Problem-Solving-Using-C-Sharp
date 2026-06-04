namespace A._Number_Replacement
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1744/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<char> chars = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();

                Dictionary<int, char> MyDict = new Dictionary<int, char>();

                bool weCanDoIt = true;

                for (int i = 0; i < size; i++)
                {
                    if (MyDict.TryGetValue(numbers[i], out char value) && value != chars[i])
                    {
                        weCanDoIt = false;
                        break;
                    }

                    else if (!MyDict.ContainsKey(numbers[i]))
                    {
                        MyDict[numbers[i]] = chars[i];
                    }
                }

                //Console.Write("************************* ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
