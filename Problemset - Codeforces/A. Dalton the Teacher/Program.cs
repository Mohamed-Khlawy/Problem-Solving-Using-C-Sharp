namespace A._Dalton_the_Teacher
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1855/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfStudents = int.Parse(Console.ReadLine()!);

                List<int> students = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int unHappyStudents = 0;

                for (int i = 0; i < numberOfStudents; i++)
                {
                    if (students[i] == i + 1)
                    {
                        unHappyStudents++;
                    }
                }

                int minMoves = (int)Math.Ceiling((double)unHappyStudents / 2);

                //Console.Write("************************************ ");

                Console.WriteLine(minMoves);
            }
        }
    }
}
