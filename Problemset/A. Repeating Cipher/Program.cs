namespace A._Repeating_Cipher
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1095/A
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);

            string ciphertext = Console.ReadLine()!;

            int increment_index = 0;

            string plaintext = string.Empty;

            for (int i = 0; i < size; i++)
            {
                plaintext += ciphertext[i];

                i += increment_index;

                increment_index++;
            }

            Console.WriteLine(plaintext);
        }
    }
}
