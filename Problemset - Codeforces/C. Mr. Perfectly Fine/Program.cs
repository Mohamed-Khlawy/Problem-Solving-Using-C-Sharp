namespace C._Mr._Perfectly_Fine
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1829/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_books = int.Parse(Console.ReadLine()!);

                int min_time_for_01 = int.MaxValue;
                int min_time_for_10 = int.MaxValue;
                int min_time_for_11 = int.MaxValue;

                bool change_the_01 = false;
                bool change_the_10 = false;
                bool change_the_11 = false;

                for (int i = 0; i < number_of_books; i++)
                {
                    List<string> book_i = Console.ReadLine()!.Split().ToList();

                    int book_time = int.Parse(book_i[0]);
                    string book_skills = book_i[1];

                    if (book_skills == "01")
                    {
                        min_time_for_01 = Math.Min(min_time_for_01, book_time);
                        change_the_01 = true;
                    }

                    else if (book_skills == "10")
                    {
                        min_time_for_10 = Math.Min(min_time_for_10, book_time);
                        change_the_10 = true;
                    }

                    else if (book_skills == "11")
                    {
                        min_time_for_11 = Math.Min(min_time_for_11, book_time);
                        change_the_11 = true;
                    }
                }

                //Console.Write("************************ ");

                if (!change_the_01 || !change_the_10)
                {
                    if (change_the_11)
                    {
                        Console.WriteLine(min_time_for_11);
                    }

                    else
                    {
                        Console.WriteLine(-1);
                    }
                }

                else // change_the_01 = (true) and change_the_10 = (true)
                {
                    int sum_of_01_10 = min_time_for_01 + min_time_for_10;

                    if (change_the_11)
                    {
                        Console.WriteLine(Math.Min(sum_of_01_10, min_time_for_11));
                    }

                    else
                    {
                        Console.WriteLine(sum_of_01_10);
                    }
                }
            }
        }
    }
}
