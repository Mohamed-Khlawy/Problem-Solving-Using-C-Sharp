namespace B._Squares_and_Cubes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1619/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                HashSet<int> polycarp_likes = new HashSet<int>();

                for (int i = 1; i * i <= number; i++)
                {
                    polycarp_likes.Add(i * i);
                }

                for (int i = 1; i * i * i <= number; i++)
                {
                    polycarp_likes.Add(i * i * i);
                }

                //Console.Write("********************************** ");

                Console.WriteLine(polycarp_likes.Count);
            }
        }
    }
}
