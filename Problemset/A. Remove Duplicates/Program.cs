namespace A._Remove_Duplicates
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/978/A
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);

            List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            numbers.Reverse();

            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            numbers = new List<int>(uniqueNumbers);

            numbers.Reverse();

            //Console.Write("************************ ");

            Console.WriteLine(numbers.Count);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
