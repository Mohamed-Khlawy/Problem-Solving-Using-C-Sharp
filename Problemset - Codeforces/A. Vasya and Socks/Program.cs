namespace A._Vasya_and_Socks
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/460/A
        static void Main(string[] args)
        {
            string[] n_m = Console.ReadLine()!.Split().ToArray();
            int n = int.Parse(n_m[0]);
            int m = int.Parse(n_m[1]);
            int copy_n = n;

            int newPairs = 0;

            while (copy_n / m != newPairs)
            {
                newPairs = copy_n / m;
                copy_n = n + newPairs;
            }

            Console.WriteLine(copy_n);
        }
    }
}