namespace L._String_Functions
{
    internal class Program
    {
        //This code got Run Time Error and i can't do more in it
        static void Main(string[] args)
        {
            // Read input values
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);
            string S = Console.ReadLine()!;

            for (int i = 0; i < Q; i++)
            {
                string[] query = Console.ReadLine()!.Split();

                switch (query[0])
                {
                    case "pop_back":
                        S = S.Substring(0, S.Length - 1);
                        break;
                    case "front":
                        Console.WriteLine(S[0]);
                        break;
                    case "back":
                        Console.WriteLine(S[S.Length - 1]);
                        break;
                    case "sort":
                        int l = int.Parse(query[1]) - 1; // Convert to 0-based indexing
                        int r = int.Parse(query[2]) - 1; // Convert to 0-based indexing
                        string sortedSubstring = new string(S.Substring(l, r - l + 1).ToCharArray());
                        char[] sortedChars = sortedSubstring.ToCharArray();
                        Array.Sort(sortedChars);
                        S = S.Substring(0, l) + new string(sortedChars) + S.Substring(r + 1);
                        break;
                    case "reverse":
                        l = int.Parse(query[1]) - 1; // Convert to 0-based indexing
                        r = int.Parse(query[2]) - 1; // Convert to 0-based indexing
                        char[] reversedChars = S.Substring(l, r - l + 1).ToCharArray();
                        Array.Reverse(reversedChars);
                        S = S.Substring(0, l) + new string(reversedChars) + S.Substring(r + 1);
                        break;
                    case "print":
                        int pos = int.Parse(query[1]) - 1; // Convert to 0-based indexing
                        Console.WriteLine(S[pos]);
                        break;
                    case "substr":
                        l = int.Parse(query[1]) - 1; // Convert to 0-based indexing
                        r = int.Parse(query[2]) - 1; // Convert to 0-based indexing
                        Console.WriteLine(S.Substring(l, r - l + 1));
                        break;
                    case "push_back":
                        char x = char.Parse(query[1]);
                        S += x;
                        break;
                }
            }
        }
    }
}