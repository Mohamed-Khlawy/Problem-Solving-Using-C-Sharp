namespace A._Diverse_Team
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/988/A
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int numberOfStudents = input[0]; /// n
            int teamSize = input[1];         /// k

            int[] studentsRatings = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            HashSet<int> uniqueRatings = new HashSet<int>(studentsRatings);

            int[] uniqueIndices = Array.Empty<int>();

            bool weCanFormTeam = false;

            if (uniqueRatings.Count >= teamSize)
            {
                weCanFormTeam = true;

                uniqueIndices = new int[teamSize];

                int uniqueIndex = 0;

                for (int i = 0; i < numberOfStudents; i++)
                {
                    if (studentsRatings[i] == uniqueRatings.ElementAt(uniqueIndex))
                    {
                        uniqueIndices[uniqueIndex] = i + 1;

                        if (uniqueIndex < teamSize - 1) uniqueIndex++;

                        else break;
                    }
                }
            }

            //Console.WriteLine("************************** ");

            Console.WriteLine(weCanFormTeam
                ? $"YES\n{string.Join(" ", uniqueIndices)}"
                : "NO");
        }
    }
}
