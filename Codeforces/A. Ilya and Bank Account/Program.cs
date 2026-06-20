namespace A._Ilya_and_Bank_Account
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/313/A
        static void Main(string[] args)
        {
            string number = Console.ReadLine()!;

            if (int.Parse(number) > 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                string removeLast = number.Substring(0, number.Length - 1);

                string removeBeforeLast = number.Substring(0, number.Length - 2);
                removeBeforeLast += number[number.Length - 1];

                Console.WriteLine(Math.Max(int.Parse(removeBeforeLast), int.Parse(removeLast)));
            }
        }
    }
}