namespace B._Angry_Monk
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1992/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int length_of_casserole = n_k[0];
                int number_of_pieces = n_k[1];

                List<int> pieces = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                pieces.Sort();

                int min_operations = 0;

                for (int i = 0; i < pieces.Count - 1; i++)
                {
                    if (pieces[i] != 1)
                    {
                        number_of_pieces += pieces[i] - 1;
                        min_operations += pieces[i] - 1;
                    }
                }

                min_operations += number_of_pieces - 1;

                //Console.Write("*** ");
                Console.WriteLine(min_operations);
            }
        }
    }
}
