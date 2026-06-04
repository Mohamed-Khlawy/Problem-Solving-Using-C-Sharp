namespace B._Polycarp_Writes_a_String_from_Memory
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1702/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<char> str = Console.ReadLine()!
                                .Select(c => char.Parse(c.ToString()))
                                .ToList();

                int minNumberOfDays = 0;
                int tempCharsCounter = 0;

                string tempStr = string.Empty;

                for (int i = 0; i < str.Count; i++)
                {
                    if (!tempStr.Contains(str[i]))
                    {
                        if (tempCharsCounter < 3)
                        {
                            tempStr += str[i];
                            tempCharsCounter++;
                        }

                        else
                        {
                            minNumberOfDays++;
                            tempCharsCounter = 1;
                            tempStr = string.Empty;
                            tempStr += str[i];
                        }
                    }
                }

                if (tempCharsCounter > 0) minNumberOfDays++;

                //Console.Write("********************* ");

                Console.WriteLine(minNumberOfDays);
            }
        }
    }
}
