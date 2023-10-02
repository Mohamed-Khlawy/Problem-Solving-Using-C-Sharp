namespace Sheet__4__Strings__MainFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size_numberOfQueries = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int size = size_numberOfQueries[0];
            int numberOfQueries = size_numberOfQueries[1];

            string word = Console.ReadLine()!;
            List<char> chars = word.ToList();

            while (numberOfQueries-- > 0)
            {
                //string[] query = Console.ReadLine()!.Split();
                //int leftIndex;
                //int rightIndex;
                //int position;
                //char newChar;
                //char[] Substring;
                //string subWord = "";
                //string newWord = "";

                //switch (query[0])
                //{
                //    case ("pop_back"):
                        
                //        for(int i = 0;i<word.Length-1;i++)
                //        {
                //            newWord += word[i];
                //        }
                //        word = newWord;
                //        newWord = "";
                //        break;

                //    case ("front"):
                //        Console.WriteLine(word[0]);
                //        break;

                //    case ("back"):
                //        Console.WriteLine(word[word.Length - 1]);
                //        break;

                //    case ("sort"):
                //        leftIndex = int.Parse(query[1]) - 1;
                //        rightIndex = int.Parse(query[2]) - 1;

                //        Substring = word.Substring(leftIndex, rightIndex - leftIndex + 1).ToCharArray();

                //        Array.Sort(Substring);

                //        subWord = new string(Substring);

                //        newWord = word.Substring(0, leftIndex) + subWord + word.Substring(rightIndex);
                        
                //        word = newWord;

                //        newWord = "";

                //        break;

                //    case ("reverse"):
                //        leftIndex = int.Parse(query[1]) - 1;
                //        rightIndex = int.Parse(query[2]) - 1;

                //        Substring = word.Substring(leftIndex, rightIndex - leftIndex + 1).ToCharArray();

                //        Array.Reverse(Substring);

                //        subWord = new string(Substring);

                //        newWord = word.Substring(0, leftIndex) + subWord + word.Substring(rightIndex);

                //        word = newWord;

                //        newWord = "";

                //        break;

                //    case ("print"):
                //        position = int.Parse(query[1]) - 1;

                //        Console.WriteLine(word[position]);

                //        break;

                //    case ("substr"):
                //        leftIndex = int.Parse(query[1]) - 1;
                //        rightIndex = int.Parse(query[2]) - 1;

                //        for(int i = leftIndex; i<= rightIndex; i++)
                //        {
                //            Console.Write(word[i]);
                //        }

                //        Console.WriteLine();
                //        break;

                //    case ("push_back"):
                //        newChar = char.Parse(query[1]);

                //        word += newChar;

                //        break;
                //}
            }
        }
    }
}