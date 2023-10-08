namespace A._Magic_Numbers
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/320/A
        static void Main(string[] args)
        {
            string number = Console.ReadLine()!;

            if (number[0] != '1' || number.Contains("444"))
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                bool notOneNorFour = false;

                for (int i = 1; i < number.Length; i++)
                {
                    if (number[i] != '1' && number[i] != '4')
                    {
                        notOneNorFour = true;
                        break;
                    }
                }

                if (!notOneNorFour)
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