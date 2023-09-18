namespace B._Lecture
{
    internal class Program
    {
        //Proplem Link: https://codeforces.com/problemset/problem/499/BB
        static void Main(string[] args)
        {
            int[] lectureWords_languageWords = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int numberOfLectureWords = lectureWords_languageWords[0];
            int languageWords = lectureWords_languageWords[1];

            string[] firstLanguage = new string[languageWords];
            string[] secondLanguage = new string[languageWords];

            for (int i = 0; i < languageWords; i++)
            {
                string[] equalWords = Console.ReadLine()!.Split();

                firstLanguage[i] = equalWords[0];
                secondLanguage[i] = equalWords[1];
            }

            string[] lectureWords = Console.ReadLine()!.Split();
            string[] lectureSummary = new string[numberOfLectureWords];

            for (int i = 0; i < numberOfLectureWords; i++)
            {
                int wordIndex = Array.IndexOf(firstLanguage, lectureWords[i]);

                if (firstLanguage[wordIndex].Length > secondLanguage[wordIndex].Length)
                {
                    lectureSummary[i] = secondLanguage[wordIndex];
                }

                else
                {
                    lectureSummary[i] = firstLanguage[wordIndex];
                }
            }

            for (int i = 0; i < numberOfLectureWords; i++)
            {
                Console.Write(lectureSummary[i] + " ");
            }
        }
    }
}