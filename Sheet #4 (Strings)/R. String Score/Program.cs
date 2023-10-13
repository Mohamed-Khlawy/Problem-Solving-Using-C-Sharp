namespace R._String_Score
{
    internal class Program
    {
        //I got Time Limit Exceeded with this code but it's right and got accepted with C++
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            List<char> chars = Console.ReadLine()!.ToList();

            long totalScore = 0;

            for (int i = 0; i < chars.Count; i++)
            {
                if (i == chars.Count - 1 && (chars[i] == 'X' || chars[i] == 'Y' || chars[i] == 'Z'))
                {
                    break;
                }

                switch (chars[i])
                {
                    case 'V':
                        totalScore += 5;
                        break;
                    case 'W':
                        totalScore += 2;
                        break;
                    case 'X':
                        chars.RemoveAt(i + 1);
                        break;
                    case 'Y':
                        char nextChar = chars[i + 1];

                        chars.RemoveAt(i + 1);

                        chars.Add(nextChar);
                        break;
                    case 'Z':
                        if (chars[i + 1] == 'V')
                        {
                            totalScore /= 5;
                            chars.RemoveAt(i + 1);
                        }
                        else if (chars[i + 1] == 'W')
                        {
                            totalScore /= 2;
                            chars.RemoveAt(i + 1);
                        }
                        break;
                }
            }

            Console.WriteLine(totalScore);
        }
    }
}