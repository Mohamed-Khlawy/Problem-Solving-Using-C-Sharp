namespace B._All_Distinct
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1692/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                // Note ==> 2 Ways to get Distinct Elements in list:
                // 1) HashSet
                // 2) First List.Distinct().ToList()

                //HashSet<int> hash_set = new HashSet<int>(numbers);

                //List<int> distinct = new List<int>(hash_set);

                List<int> distinct = numbers.Distinct().ToList();

                int total_repeats = 0;
                double total_operations = 0;
                int max_length = 0;

                foreach (int number in distinct)
                {
                    total_repeats += numbers.Where(x => x == number).Count() - 1;
                }

                total_operations = Math.Ceiling((double)total_repeats / 2) * 2;

                max_length = numbers.Count - (int)total_operations;

                Console.WriteLine(max_length);
            }
        }
    }
}
