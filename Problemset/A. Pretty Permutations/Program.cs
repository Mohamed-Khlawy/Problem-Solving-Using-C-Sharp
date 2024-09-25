namespace A._Pretty_Permutations
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1541/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_cats = int.Parse(Console.ReadLine()!);

                List<int> reording_cats = Enumerable.Range(1, number_of_cats).ToList();


                for (int i = 0; i < reording_cats.Count - 1; i++)
                {
                    (reording_cats[i], reording_cats[i + 1]) =
                        (reording_cats[i + 1], reording_cats[i]);
                    i++;
                }

                if (reording_cats.Count % 2 != 0)
                {
                    (reording_cats[reording_cats.Count - 1], reording_cats[reording_cats.Count - 2])
                     = (reording_cats[reording_cats.Count - 2], reording_cats[reording_cats.Count - 1]);
                }

                for (int i = 0; i < reording_cats.Count; i++)
                {
                    if (i == reording_cats.Count - 1)
                    {
                        Console.WriteLine(reording_cats[i]);
                    }

                    else
                    {
                        Console.Write(reording_cats[i] + " ");
                    }
                }
            }
        }
    }
}
