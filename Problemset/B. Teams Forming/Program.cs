namespace B._Teams_Forming
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1092/B
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine()!);

            int[] skills = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Array.Sort(skills);

            int minProblems = 0;

            for (int i = 0; i < numberOfStudents - 1; i += 2)
            {
                minProblems += skills[i + 1] - skills[i];
            }

            //Console.Write("******************** ");

            Console.WriteLine(minProblems);
        }
    }
}
