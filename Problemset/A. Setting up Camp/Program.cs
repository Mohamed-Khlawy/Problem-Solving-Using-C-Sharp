namespace A._Setting_up_Camp
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1945/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int introvertPeople = input[0]; /// a
                int extrovertPeople = input[1]; /// b
                int universalPeople = input[2]; /// c

                bool weCan = true;

                long numberOfTents = 0;

                if (extrovertPeople != 0 && extrovertPeople < 3)
                {
                    int diff = 3 - extrovertPeople;

                    if (diff <= universalPeople)
                    {
                        extrovertPeople += diff;
                        universalPeople -= diff;
                    }

                    else
                    {
                        weCan = false;
                    }
                }

                else /// extrovertPeople >= 3
                {
                    int mod = extrovertPeople % 3;

                    if (mod == 1 && universalPeople >= 2)
                    {
                        extrovertPeople += 2;
                        universalPeople -= 2;
                    }

                    else if (mod == 2 && universalPeople >= 1)
                    {
                        extrovertPeople += 1;
                        universalPeople -= 1;
                    }

                    else if (mod != 0)
                    {
                        weCan = false;
                    }
                }

                //Console.Write("************************************** ");

                if (weCan)
                {
                    int extrovertTents = extrovertPeople / 3;

                    int universalTents = (int)Math.Ceiling((double)universalPeople / 3);

                    numberOfTents =
                        introvertPeople + extrovertTents + universalTents;

                    Console.WriteLine(numberOfTents);
                }

                else
                {
                    Console.WriteLine(-1);
                }
            }
    }
}
