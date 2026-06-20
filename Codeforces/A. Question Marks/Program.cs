namespace A._Question_Marks
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1993/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_chars = int.Parse(Console.ReadLine()!);

                string chars = Console.ReadLine()!;

                int[] chars_frequency = new int[4];

                int tim_score = 0;

                for (int i = 0; i < chars.Length; i++)
                {
                    switch (chars[i])
                    {
                        case 'A':
                            chars_frequency[0]++;
                            break;

                        case 'B':
                            chars_frequency[1]++;
                            break;

                        case 'C':
                            chars_frequency[2]++;
                            break;

                        case 'D':
                            chars_frequency[3]++;
                            break;
                    }
                }

                for (int i = 0; i < chars_frequency.Length; i++)
                {
                    if (chars_frequency[i] >= number_of_chars)
                    {
                        tim_score += number_of_chars;
                    }

                    else
                    {
                        tim_score += chars_frequency[i];
                    }
                }

                //Console.Write("**************************************** ");

                Console.WriteLine(tim_score);
            }
        }
    }
}
