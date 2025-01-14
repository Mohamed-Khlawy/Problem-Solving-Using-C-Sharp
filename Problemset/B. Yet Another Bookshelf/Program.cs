namespace B._Yet_Another_Bookshelf
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1433/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_places = int.Parse(Console.ReadLine()!);

                List<int> bookshelf = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int first_book_position = bookshelf.IndexOf(1);

                int last_book_position = bookshelf.LastIndexOf(1);

                List<int> subBookshelf = bookshelf.Skip(first_book_position)
                                                  .Take(last_book_position - first_book_position + 1)
                                                  .ToList();

                int number_of_zeros_in_sub = subBookshelf.Count(x => x == 0);

                //Console.Write("************************************ ");

                Console.WriteLine(number_of_zeros_in_sub);
            }
        }
    }
}
