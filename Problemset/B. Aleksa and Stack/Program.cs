namespace B._Aleksa_and_Stack
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1878/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int list_size = int.Parse(Console.ReadLine()!);

                int curr_element = 1;

                for (int i = 0; i < list_size; i++)
                {
                    if (i == list_size - 1)
                    {
                        Console.WriteLine(curr_element);
                        break;
                    }

                    else
                    {
                        Console.Write(curr_element + " ");

                        curr_element += 2;
                    }
                }
            }
        }
    }
}
