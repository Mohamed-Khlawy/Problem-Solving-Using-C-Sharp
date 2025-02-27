namespace C._Letters
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/978/C
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int numberOfDormitories = input[0]; /// n
            int numberOfLetters = input[1];     /// m

            List<long> roomsPerDormitories = Console.ReadLine()!.Split().Select(long.Parse).ToList();
            long[] letters = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

            int lettersIndex = 0;

            for (int i = 1; i < numberOfDormitories; i++)
            {
                roomsPerDormitories[i] += roomsPerDormitories[i - 1];
            }

            roomsPerDormitories.Insert(0, 0);

            for (int i = 0; i < roomsPerDormitories.Count - 1; i++)
            {
                while (lettersIndex < letters.Length &&
                    letters[lettersIndex] >= roomsPerDormitories[i] &&
                    letters[lettersIndex] <= roomsPerDormitories[i + 1])
                {
                    Console.WriteLine(i + 1 + " " +
                        (letters[lettersIndex] - roomsPerDormitories[i]));

                    lettersIndex++;
                }
            }

            Console.WriteLine();
        }
    }
}
