namespace C._Numeric_String_Template
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2000/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfStrings = int.Parse(Console.ReadLine()!);

                Dictionary<int, char> myDict = new Dictionary<int, char>();

                List<char> takenChars = new List<char>();

                while (numberOfStrings-- > 0)
                {
                    string word = Console.ReadLine()!;

                    bool thisWordMatchTheTemplate = true;

                    if (word.Length == size)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (myDict.TryGetValue(numbers[i], out char value))
                            {
                                if (value != word[i])
                                {
                                    thisWordMatchTheTemplate = false;
                                    break;
                                }
                            }

                            else if (takenChars.Contains(word[i]))
                            {
                                thisWordMatchTheTemplate = false;
                                break;
                            }

                            else
                            {
                                myDict.Add(numbers[i], word[i]);
                                takenChars.Add(word[i]);
                            }
                        }

                        myDict.Clear();
                        takenChars.Clear();
                    }

                    else
                    {
                        thisWordMatchTheTemplate = false;
                    }

                    //Console.Write("**************************** ");

                    Console.WriteLine(thisWordMatchTheTemplate ? "YES" : "NO");
                }
            }
        }
    }
}
