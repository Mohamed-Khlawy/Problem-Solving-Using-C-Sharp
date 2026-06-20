namespace B._Shoe_Shuffling
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1691/B
        public static void PerformShuffling(ref List<int> equalNumbers)
        {
            equalNumbers.Insert(0, equalNumbers[^1]);
            equalNumbers.RemoveAt(equalNumbers.Count - 1);
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfStudents = int.Parse(Console.ReadLine()!);

                int[] studentsShoes =
                    Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

                List<int> shuffeledShoes = new List<int>(numberOfStudents);

                List<int> equality = new List<int>();

                bool successfullyShuffeling = true;

                for (int i = 0; i < numberOfStudents; i++)
                {
                    equality.Add(i + 1);

                    for (int j = i + 1; j < numberOfStudents; j++)
                    {
                        if (studentsShoes[i] != studentsShoes[j]) break;

                        equality.Add(j + 1);

                        i = j;
                    }

                    if (equality.Count == 1)
                    {
                        successfullyShuffeling = false;
                        break;
                    }

                    PerformShuffling(ref equality);

                    shuffeledShoes.AddRange(equality);

                    equality.Clear();
                }

                //Console.Write("********************* ");

                Console.WriteLine(successfullyShuffeling
                    ? string.Join(" ", shuffeledShoes)
                    : -1);
            }
        }
    }
}
