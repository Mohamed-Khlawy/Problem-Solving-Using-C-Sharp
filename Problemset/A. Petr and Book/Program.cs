namespace A._Petr_and_Book
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/139/A
        static void Main(string[] args)
        {
            int number_of_pages = int.Parse(Console.ReadLine()!);

            List<int> pages_per_day = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int read_for_now = 0;

            int index_of_days = 0;

            while (read_for_now < number_of_pages)
            {
                read_for_now += pages_per_day[index_of_days % 7];

                index_of_days++;
            }

            int finishing_day = index_of_days % 7 == 0 ? 7 : index_of_days % 7;

            //Console.Write("******************************** ");

            Console.WriteLine(finishing_day);
        }
    }
}
