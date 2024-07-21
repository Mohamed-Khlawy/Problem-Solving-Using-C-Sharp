namespace A._Erasing_Zeroes
{
    internal class Program
    {
        //Problem Link : https://codeforces.com/problemset/problem/1303/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string str = Console.ReadLine()!;

                int first_index = str.IndexOf('1');
                int last_index = str.LastIndexOf('1');

                int zeros_to_remove = 0;

                for (int i = first_index + 1; i < last_index; i++)
                {
                    if (str[i] == '0')
                    {
                        zeros_to_remove++;
                    }
                }

                //Console.Write("*** ");
                Console.WriteLine(zeros_to_remove);
            }
        }
    }
}
