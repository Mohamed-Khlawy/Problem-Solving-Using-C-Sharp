namespace A._To_My_Critics
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1850/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                bool found = false;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    int j = 0;
                    while (j < numbersArray.Length)
                    {
                        if (j != i)
                        {
                            int sum = numbersArray[j] + numbersArray[i];
                            if (sum >= 10)
                            {
                                found = true;
                                break;
                            }
                        }

                        j++;
                    }
                }

                if (found)
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