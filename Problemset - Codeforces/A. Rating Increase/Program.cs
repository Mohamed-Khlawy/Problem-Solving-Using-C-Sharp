namespace A._Rating_Increase
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1913/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] ratingString = Console.ReadLine()!.ToCharArray();

                List<char> firstRatingList = new List<char>() { ratingString[0] };
                List<char> secondRatingList = new List<char>() { '0' };

                //Console.Write("************************ ");

                for (int i = 1; i < ratingString.Length; i++)
                {
                    if (ratingString[i] == '0') firstRatingList.Add('0');

                    else
                    {
                        for (int j = i; j < ratingString.Length; j++)
                        {
                            secondRatingList.Add(ratingString[j]);
                        }

                        break;
                    }
                }

                int firstRating = int.Parse(string.Join("", firstRatingList));
                int secondRating = int.Parse(string.Join("", secondRatingList));

                Console.WriteLine(firstRating < secondRating
                    ? $"{firstRating} {secondRating}"
                    : -1);
            }
        }
    }
}
