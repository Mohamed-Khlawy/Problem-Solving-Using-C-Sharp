namespace C._Odd_Even_Increments
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1669/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                int[] numbersAraay = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                bool isEven = false;
                bool isOdd = false;
                bool weCan = true;

                if (numbersAraay[0] % 2 == 0)
                {
                    isEven = true;
                }
                else
                {
                    isOdd = true;
                }

                for (int i = 2; i < numbersAraay.Length; i += 2)
                {
                    if ((numbersAraay[i] % 2 == 0 && !isEven) ||
                        (numbersAraay[i] % 2 != 0 && !isOdd))
                    {
                        weCan = false;
                    }
                }

                if (weCan)
                {
                    isEven = false;
                    isOdd = false;

                    if (numbersAraay[1] % 2 == 0)
                    {
                        isEven = true;
                    }
                    else
                    {
                        isOdd = true;
                    }

                    for (int i = 3; i < numbersAraay.Length; i += 2)
                    {
                        if ((numbersAraay[i] % 2 == 0 && !isEven) ||
                            (numbersAraay[i] % 2 != 0 && !isOdd))
                        {
                            weCan = false;
                        }
                    }

                    if (weCan)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}