namespace B._Decoding
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/746/B
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);

            List<char> ciphertext = Console.ReadLine()!
                                    .Select(c => char.Parse(c.ToString()))
                                    .ToList();

            char[] plaintext = new char[size];

            if (size % 2 == 0) // Even Size
            {
                int middle_index = size / 2 - 1;

                bool plus_middle = false;
                bool minus_middle = false;
                int counter = 1;

                for (int i = 0; i < size - 1; i++)
                {
                    if (i == 0)
                    {
                        plaintext[middle_index] = ciphertext[i];
                        plus_middle = true;
                    }

                    else
                    {
                        if (plus_middle)
                        {
                            plaintext[middle_index + counter] = ciphertext[i];
                            minus_middle = true;
                            plus_middle = false;
                        }

                        else // minus_middle = true
                        {
                            plaintext[middle_index - counter] = ciphertext[i];
                            minus_middle = false;
                            plus_middle = true;
                            counter++;
                        }
                    }
                }

                plaintext[size - 1] = ciphertext[size - 1];
            }

            else // Odd Size
            {
                int middle_index = size / 2;

                bool plus_middle = false;
                bool minus_middle = false;
                int counter = 1;

                for (int i = 0; i < size; i++)
                {
                    if (i == 0)
                    {
                        plaintext[middle_index] = ciphertext[i];
                        minus_middle = true;
                    }

                    else
                    {
                        if (minus_middle)
                        {
                            plaintext[middle_index - counter] = ciphertext[i];
                            minus_middle = false;
                            plus_middle = true;
                        }

                        else // plus_middle = true
                        {
                            plaintext[middle_index + counter] = ciphertext[i];
                            minus_middle = true;
                            plus_middle = false;
                            counter++;
                        }
                    }
                }
            }

            //Console.Write("********************************* ");

            Console.WriteLine(string.Join("", plaintext));
        }
    }
}
