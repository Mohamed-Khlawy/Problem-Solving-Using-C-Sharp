namespace A._Kamilka_and_the_Sheep
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2092/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfSheeps = int.Parse(Console.ReadLine()!);

                int[] sheeps = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Array.Sort(sheeps);

                int maxPleasure = sheeps[numberOfSheeps - 1] - sheeps[0];

                //Console.Write("****************************** ");

                Console.WriteLine(maxPleasure);
            }
        }
    }
}
