namespace B._Lovely_Palindromes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/688/B
        static void Main(string[] args)
        {
            string number = Console.ReadLine()!;

            char[] char_array = number.ToCharArray();

            Array.Reverse(char_array);

            string reverse_number = new string(char_array);

            string palindrome_string = number + reverse_number;

            Console.WriteLine(palindrome_string);
        }
    }
}
