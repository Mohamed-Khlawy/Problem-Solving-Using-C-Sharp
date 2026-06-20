namespace A._Oath_of_the_Night_s_Watch
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/768/A
        static void Main(string[] args)
        {
            int numberOfStewards = int.Parse(Console.ReadLine()!);

            List<int> stewards = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            stewards.Sort();

            int JohnStewards = 0;

            int strongest = stewards[0];
            int weakest = stewards[^1];

            for (int i = 1; i < stewards.Count - 1; i++)
            {
                if (stewards[i] > strongest && stewards[i] < weakest)
                {
                    JohnStewards++;
                }
            }

            //Console.Write("********************************** ");

            Console.WriteLine(JohnStewards);
        }
    }
}
