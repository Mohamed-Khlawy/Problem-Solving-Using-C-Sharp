namespace A._Alice_and_Books
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1978/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfBooks = int.Parse(Console.ReadLine()!);

                int[] books = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int highestBookIndex = books[^1];

                books[^1] = 0; /// To avoid getting the same book 2 times.

                int highestBookPages = books.Max();

                //Console.Write("************************* ");

                Console.WriteLine(highestBookIndex + highestBookPages);
            }
        }
    }
}
