namespace B._Mahmoud_and_a_Triangle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/766/B

        // Proof of Idea : https://www.tutorialspoint.com/possible-to-form-a-triangle-from-array-values-in-cplusplus
        static void Main(string[] args)
        {
            int number_of_lines = int.Parse(Console.ReadLine()!);

            List<int> lines = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            lines.Sort();

            for (int i = 0; i < number_of_lines - 2; i++)
            {
                if (lines[i] + lines[i + 1] > lines[i + 2])
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            Console.WriteLine("NO");
        }
    }
}
