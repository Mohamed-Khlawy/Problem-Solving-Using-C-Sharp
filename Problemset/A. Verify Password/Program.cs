namespace A._Verify_Password
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1976/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string password = Console.ReadLine()!;

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                bool strong_password = true;

                bool we_get_first_char = false;

                int last_digit = 0;

                int last_char_index = 0;

                for (int i = 0; i < size; i++)
                {
                    if (char.IsLetter(password[i]))
                    {
                        we_get_first_char = true;

                        int current_char_index = alphabet.IndexOf(password[i]);

                        if (current_char_index < last_char_index)
                        {
                            strong_password = false;
                            break;
                        }

                        last_char_index = current_char_index;
                    }

                    else if (char.IsDigit(password[i]) && !we_get_first_char)
                    {
                        int current_digit = int.Parse(password[i].ToString());

                        if (current_digit < last_digit)
                        {
                            strong_password = false;
                            break;
                        }

                        last_digit = current_digit;
                    }

                    else
                    {
                        strong_password = false;
                        break;
                    }
                }

                //Console.Write("******************************************* ");

                if (strong_password)
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
