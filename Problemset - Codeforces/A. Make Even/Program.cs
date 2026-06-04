namespace A._Make_Even
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1611/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                //Console.Write("*** ");

                if (number % 2 == 0)
                {
                    Console.WriteLine(0);
                }

                else
                {
                    string number_as_string = number.ToString();
                    bool is_there_even_digit = false;

                    for (int i = 0; i < number_as_string.Length; i++)
                    {
                        if ((int)number_as_string[i] % 2 == 0)
                        {
                            is_there_even_digit = true;
                            break;
                        }
                    }

                    if (is_there_even_digit)
                    {
                        char[] number_as_char_array = number_as_string.ToCharArray();
                        Array.Reverse(number_as_char_array);
                        number_as_string = new string(number_as_char_array);

                        if (int.Parse(number_as_string) % 2 == 0)
                        {
                            Console.WriteLine(1);
                        }

                        else
                        {
                            Console.WriteLine(2);
                        }
                    }

                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
            }
        }
    }
}
