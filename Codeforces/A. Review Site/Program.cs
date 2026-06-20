namespace A._Review_Site
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1511/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfReviewers = int.Parse(Console.ReadLine()!);

                List<int> reviewers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int maxNumberOfUpvotes =
                    reviewers.Where(reviewer => reviewer == 1 || reviewer == 3).Count();

                //Console.Write("************************** ");

                Console.WriteLine(maxNumberOfUpvotes);
            }
        }
    }
}
