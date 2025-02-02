namespace A._Regular_Bracket_Sequence
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1469/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<char> bracketSequence = Console.ReadLine()!
                                            .Select(c => char.Parse(c.ToString()))
                                            .ToList();

                bool weCanDoIt = true;

                /// No way to do it with (ODD) number of characters
                if (bracketSequence.Count % 2 != 0)
                {
                    weCanDoIt = false;
                }

                else /// Even number of characters
                {
                    int openingBrackets = 0; /// (
                    int questionMarks = 0;   /// ?

                    for (int i = 0; i < bracketSequence.Count; i++)
                    {
                        if (bracketSequence[i] == '(' && i != bracketSequence.Count - 1)
                            openingBrackets++;

                        else if (bracketSequence[i] == '?') questionMarks++;

                        else if (bracketSequence[i] == ')' && i != 0)
                        {
                            if (openingBrackets > 0) openingBrackets--;

                            else if (questionMarks > 0) questionMarks--;

                            else
                            {
                                weCanDoIt = false;
                                break;
                            }

                        }

                        else
                        {
                            weCanDoIt = false;
                            break;
                        }
                    }
                }

                //Console.Write("********************* ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
