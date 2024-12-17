namespace A._We_Got_Everything_Covered_
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1925/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int string_length = input[0];
                int first_alphabet_letters = input[1];

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                char[] main_cahrs = new char[first_alphabet_letters];

                for (int i = 0; i < first_alphabet_letters; i++)
                {
                    main_cahrs[i] = alphabet[i];
                }

                string main_string = new string(main_cahrs);

                //Console.Write("*********************************** ");

                for (int i = 0; i < string_length; i++)
                {
                    Console.Write(main_string);
                }

                Console.WriteLine();
            }
        }
    }
}
