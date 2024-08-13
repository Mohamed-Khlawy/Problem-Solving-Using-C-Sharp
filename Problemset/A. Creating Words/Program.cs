namespace A._Creating_Words
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1985/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<string> matt = Console.ReadLine()!.Split().ToList();

                string a = matt[0];
                string b = matt[1];

                char[] chars_a = a.ToCharArray();
                char[] chars_b = b.ToCharArray();

                char first_a = chars_a[0];
                char first_b = chars_b[0];

                chars_a[0] = first_b;
                chars_b[0] = first_a;

                string new_a = new string(chars_a);
                string new_b = new string(chars_b);

                Console.WriteLine(new_a + " " + new_b);
            }
        }
    }
}
