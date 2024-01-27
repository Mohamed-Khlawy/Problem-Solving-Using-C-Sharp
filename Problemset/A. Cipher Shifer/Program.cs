namespace A._Cipher_Shifer
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/1840/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests > 0)
            {
                tests--;

                int length = int.Parse(Console.ReadLine()!);

                string encrypted_message = Console.ReadLine()!;

                string plaintext = "";

                plaintext += encrypted_message[0];

                int p = 0;

                bool flag = false;

                for (int e = 1; e < length; e++)
                {
                    if (flag == true)
                    {
                        plaintext += encrypted_message[e];

                        flag = false;

                        continue;
                    }

                    if (encrypted_message[e] == plaintext[p])
                    {
                        flag = true;

                        p++;
                    }
                }

                Console.WriteLine(plaintext);
            }
        }
    }
}
